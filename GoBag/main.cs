using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Windows.Input;

namespace GoBag
{
    public partial class main : Form
    {
        //Drag form variables
        int mov;
        int movX;
        int movY;

        //SQLITE variables
        private static string dbCommand = "";
        private static BindingSource bindingSrc;

        private static string dbPath = Application.StartupPath + "\\" + "database.db;";
        private static string conString = "Data Source=" + dbPath + "Version=3;New=False;Compress=True;";

        private static SQLiteConnection connection = new SQLiteConnection(conString);
        private static SQLiteCommand command = new SQLiteCommand("", connection);
        private static string sql;





        public main()
        {
            InitializeComponent();
            expireWarning.BringToFront();
            this.dataView.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            this.expire2NextYearDataView.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            this.expireNextYearDataView.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            this.expireDataView.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            this.autoId_textbox.Enabled = false;
        }


        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }

        }

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void mainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void navbar_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void navbar_close_Enter(object sender, EventArgs e)
        {
            navbar_close.Image = Image.FromFile(@"assets\images\navbar_close_hover.png");
        }

        private void navbar_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void navbar_close_MouseLeave(object sender, EventArgs e)
        {
            navbar_close.Image = Image.FromFile(@"assets\images\navbar_close.png");
        }

        private void expireWarning_button_Click(object sender, EventArgs e)
        {
            expireWarning.BringToFront();
        }

        private void editButton_button_Click(object sender, EventArgs e)
        {
            edit.BringToFront();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (addButton.Text == "Add")
                {
                    addButton.Text = "Cancel";
                    positionLabel.Text = "Position: 0/0";
                    dataView.ClearSelection();
                    dataView.Enabled = false;
                }
                else
                {
                    addButton.Text = "Add";
                    updateDataBinding();
                    return;
                }

                TextBox txt;
                foreach (Control c in insertBox.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        txt = (TextBox)c;
                        txt.DataBindings.Clear();
                        txt.Text = "";
                        if (txt.Name.Equals("name_textbox"))
                        {
                            if (txt.CanFocus)
                            {
                                txt.Focus();
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (addButton.Text.Equals("Cancel"))
            {
                return;
            }
            updateDataBinding();
        }

        private void addCmdParameters()
        {
            command.Parameters.Clear();
            command.CommandText = sql;

            command.Parameters.AddWithValue("Name", name_textbox.Text.Trim());
            command.Parameters.AddWithValue("Description", description_textbox.Text.Trim());
            command.Parameters.AddWithValue("Piece", piece_textbox.Text.Trim());
            command.Parameters.AddWithValue("Expiration", expiration_textbox.Text.Trim());
            command.Parameters.AddWithValue("More", more_textbox.Text.Trim());

            if (dbCommand.ToUpper() == "UPDATE")
            {
                command.Parameters.AddWithValue("AutoID", autoId_textbox.Text.Trim());
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // addCmdParameters();

            if (string.IsNullOrEmpty(name_textbox.Text.Trim()) || string.IsNullOrEmpty(piece_textbox.Text.Trim()) || string.IsNullOrEmpty(expiration_textbox.Text.Trim()))
            {
                MessageBox.Show("Please fill in the required fields.", "Add to database warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            openConnection();
            try
            {
                if (addButton.Text == "Add")
                {
                    if (autoId_textbox.Text.Trim() == "" || string.IsNullOrEmpty(autoId_textbox.Text.Trim()))
                    {
                        MessageBox.Show("Please select an item.");
                        return;
                    }

                    if(MessageBox.Show("ID: " + autoId_textbox.Text.Trim() + " -- Do you want to update the selected record? ", "Update selected record", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }
                    dbCommand = "UPDATE";

                    sql = "UPDATE supplies SET Name = @Name, Description = @Description, Piece = @Piece, Expiration = @Expiration, More = @More";
                    addCmdParameters();

                }
                else if (addButton.Text.Equals("Cancel"))
                {
                    DialogResult result;
                    result = MessageBox.Show("Do you want to add a new supplies record? (Y/N)", "Insert in database", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dbCommand = "INSERT";
                        sql = "INSERT INTO supplies(Name, Description, Piece, Expiration, More) " + "VALUES(@Name, @Description, @Piece, @Expiration, @More)";
                        addCmdParameters();
                    }
                    else
                    {
                        return;
                    }

                    int executeResult = command.ExecuteNonQuery();
                    if (executeResult == -1)
                    {
                        MessageBox.Show("Data was not saved!", "Fail to save data.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Your SQL " + dbCommand + " Query has been executed successfully.", "Database has been saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateDataBinding();
                        addButton.Text = "Add";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString(), "Error while saving data.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbCommand = "";
                closeConnection();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(addButton.Text == "Cancel")
            {
                return;
            }

            if(autoId_textbox.Text.Trim() == "" | string.IsNullOrEmpty(autoId_textbox.Text.Trim()))
            {
                MessageBox.Show("Please select an item from the list.", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            openConnection();

            try
            {
                if (MessageBox.Show("ID: " + autoId_textbox.Text.Trim() + "-- Do you want to delete the selected record?", "Delted Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }

                dbCommand = "DELETE";
                sql = "DELETE FROM supplies WHERE AutoID = @AutoID";

                command.Parameters.Clear();
                command.CommandText = sql;
                command.Parameters.AddWithValue("AutoID", autoId_textbox.Text.Trim());

                int executeResult = command.ExecuteNonQuery();
                if (executeResult == 1)
                {
                    MessageBox.Show("Your SQL " + dbCommand + " Query has been executed successfully", "Deleted data successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateDataBinding();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString(), "Error while deleting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbCommand = "";
                closeConnection();
            }
        }


        private void main_Load(object sender, EventArgs e)
        {
            openConnection();
            updateDataBinding();
            getExpirationData();
            get2NextYearExpirationData();
            getNextYearExpirationData();
            closeConnection();
        }

        private void displayPosition()
        {
            positionLabel.Text = "Position: " + Convert.ToString(bindingSrc.Position + 1) + "/" + bindingSrc.Count.ToString();
        }

        private void updateDataBinding(SQLiteCommand cmd = null)
        {
            try
            {
                TextBox tb;

                foreach (Control c in insertBox.Controls)
                {
                    if(c.GetType() == typeof(TextBox))
                    {
                        tb = (TextBox)c;
                        tb.DataBindings.Clear();
                        tb.Text = "";
                    }
                }

                dbCommand = "SELECT";

                sql = "SELECT * FROM supplies ORDER BY AutoID ASC";

                if(cmd == null)
                {
                    command.CommandText = sql;
                }
                else
                {
                    command = cmd;
                }

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataSet dataSt = new DataSet();
                adapter.Fill(dataSt, "supplies");

                bindingSrc = new BindingSource();
                bindingSrc.DataSource = dataSt.Tables["supplies"];

                autoId_textbox.DataBindings.Add("Text", bindingSrc, "AutoID");
                name_textbox.DataBindings.Add("Text", bindingSrc, "Name");
                description_textbox.DataBindings.Add("Text", bindingSrc, "Description");
                piece_textbox.DataBindings.Add("Text", bindingSrc, "Piece");
                expiration_textbox.DataBindings.Add("Text", bindingSrc, "Expiration");
                more_textbox.DataBindings.Add("Text", bindingSrc, "More");

                dataView.Enabled = true;
                dataView.DataSource = bindingSrc;

                dataView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dataView.Columns[0].Width = 70;

                displayPosition();
                getExpirationData();
                get2NextYearExpirationData();
                getNextYearExpirationData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data binding error: " + ex.Message.ToString(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void closeConnection()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
                //MessageBox.Show("The connection is : " + connection.State.ToString());
            }
        }

        private void openConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
                //MessageBox.Show("The connection is : " + connection.State.ToString());
            }
        }

        private void dataView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void moveFirst_button_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveFirst();
            displayPosition();
        }

        private void movePrevious_button_Click(object sender, EventArgs e)
        {
            bindingSrc.MovePrevious();
            displayPosition();
        }

        private void moveNext_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveNext();
            displayPosition();
        }

        private void moveLast_button_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveLast();
            displayPosition();
        }

        private void dataView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                displayPosition();
            }
            catch (Exception) 
            {

            }

        }

        private void getExpirationData()
        {
            int currentYear = DateTime.Now.Year;
            currentYear_label.Text = currentYear.ToString();
            openConnection();

            // 현재 연도와 일치하는 레코드만 선택하는 SQL 쿼리
            string sql = $"SELECT Name, Expiration FROM supplies WHERE Expiration LIKE '{currentYear}%'";

            // SQLiteCommand 및 DataAdapter 사용
            using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
            using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
            {
                // DataTable에 결과 저장
                DataTable dt = new DataTable();
                da.Fill(dt);

                // DataGridView에 데이터 바인딩
                expireDataView.DataSource = dt;
            }
            expireDataView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            expireDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void getNextYearExpirationData()
        {
            int currentYear = DateTime.Now.Year;
            nextYear_label.Text = (currentYear + 1).ToString();
            openConnection();

            // 현재 연도와 일치하는 레코드만 선택하는 SQL 쿼리
            string sql = $"SELECT Name, Expiration FROM supplies WHERE Expiration LIKE '{currentYear + 1}%'";

            // SQLiteCommand 및 DataAdapter 사용
            using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
            using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
            {
                // DataTable에 결과 저장
                DataTable dt = new DataTable();
                da.Fill(dt);

                // DataGridView에 데이터 바인딩
                expireNextYearDataView.DataSource = dt;
            }
            expireNextYearDataView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            expireNextYearDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void get2NextYearExpirationData()
        {
            int currentYear = DateTime.Now.Year;
            next2Year_label.Text = (currentYear + 2).ToString();

            openConnection();

            // 현재 연도와 일치하는 레코드만 선택하는 SQL 쿼리
            string sql = $"SELECT Name, Expiration FROM supplies WHERE Expiration LIKE '{currentYear + 2}%'";

            // SQLiteCommand 및 DataAdapter 사용
            using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
            using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
            {
                // DataTable에 결과 저장
                DataTable dt = new DataTable();
                da.Fill(dt);

                // DataGridView에 데이터 바인딩
                expire2NextYearDataView.DataSource = dt;
            }
            expire2NextYearDataView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            expire2NextYearDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void expireWarningButton_MouseEnter(object sender, EventArgs e)
        {
            expireWarningButton.ForeColor = Color.LightGray;
        }

        private void editButton_button_MouseEnter(object sender, EventArgs e)
        {
            editButton.ForeColor = Color.LightGray;
        }

        private void expireWarningButton_MouseLeave(object sender, EventArgs e)
        {
            expireWarningButton.ForeColor = Color.White;
        }

        private void editButton_MouseLeave(object sender, EventArgs e)
        {
            editButton.ForeColor = Color.White;
        }

        private void editButton_MouseDown(object sender, MouseEventArgs e)
        {

            editButton.ForeColor = Color.LightGray;
        }

        private void howtouse_button_Click(object sender, EventArgs e)
        {
            howtouse_panel.BringToFront();

        }
    }
}
