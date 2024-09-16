namespace GoBag
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.navbar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.navbar_picture_logo = new System.Windows.Forms.PictureBox();
            this.navbar_minimize = new System.Windows.Forms.Button();
            this.navbar_close = new System.Windows.Forms.Button();
            this.navbar_icon = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.expireWarningButton = new System.Windows.Forms.Button();
            this.sidebar_copyright = new System.Windows.Forms.Label();
            this.sidebar_version = new System.Windows.Forms.Label();
            this.expireWarning = new System.Windows.Forms.Panel();
            this.currentYear_label = new System.Windows.Forms.Label();
            this.nextYear_label = new System.Windows.Forms.Label();
            this.next2Year_label = new System.Windows.Forms.Label();
            this.expire2NextYearDataView = new System.Windows.Forms.DataGridView();
            this.expireNextYearDataView = new System.Windows.Forms.DataGridView();
            this.expireDataView = new System.Windows.Forms.DataGridView();
            this.warning_title = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Panel();
            this.positionLabel = new System.Windows.Forms.Label();
            this.insertBox = new System.Windows.Forms.GroupBox();
            this.moveLast_button = new System.Windows.Forms.Button();
            this.movePrevious_button = new System.Windows.Forms.Button();
            this.moveNext_button = new System.Windows.Forms.Button();
            this.moveFirst_button = new System.Windows.Forms.Button();
            this.autoId_label = new System.Windows.Forms.Label();
            this.autoId_textbox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.expiration_textbox = new System.Windows.Forms.TextBox();
            this.more_textbox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.piece_textbox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.more_label = new System.Windows.Forms.Label();
            this.expiration_label = new System.Windows.Forms.Label();
            this.piece_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.editDatabase_title = new System.Windows.Forms.Label();
            this.howtouse_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.howtouse_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navbar_picture_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbar_icon)).BeginInit();
            this.sidebar.SuspendLayout();
            this.expireWarning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expire2NextYearDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expireNextYearDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expireDataView)).BeginInit();
            this.edit.SuspendLayout();
            this.insertBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.howtouse_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.navbar.Controls.Add(this.label1);
            this.navbar.Controls.Add(this.navbar_picture_logo);
            this.navbar.Controls.Add(this.navbar_minimize);
            this.navbar.Controls.Add(this.navbar_close);
            this.navbar.Controls.Add(this.navbar_icon);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(1264, 32);
            this.navbar.TabIndex = 0;
            this.navbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.navbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseMove);
            this.navbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "V 1.0.0";
            // 
            // navbar_picture_logo
            // 
            this.navbar_picture_logo.Image = global::GoBag.Properties.Resources.navbar_picture_logo;
            this.navbar_picture_logo.Location = new System.Drawing.Point(15, 4);
            this.navbar_picture_logo.Name = "navbar_picture_logo";
            this.navbar_picture_logo.Size = new System.Drawing.Size(25, 25);
            this.navbar_picture_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.navbar_picture_logo.TabIndex = 5;
            this.navbar_picture_logo.TabStop = false;
            // 
            // navbar_minimize
            // 
            this.navbar_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navbar_minimize.FlatAppearance.BorderSize = 0;
            this.navbar_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navbar_minimize.Image = global::GoBag.Properties.Resources.navbar_minimize;
            this.navbar_minimize.Location = new System.Drawing.Point(1200, 0);
            this.navbar_minimize.Name = "navbar_minimize";
            this.navbar_minimize.Size = new System.Drawing.Size(32, 32);
            this.navbar_minimize.TabIndex = 4;
            this.navbar_minimize.UseVisualStyleBackColor = true;
            this.navbar_minimize.Click += new System.EventHandler(this.navbar_minimize_Click);
            // 
            // navbar_close
            // 
            this.navbar_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navbar_close.FlatAppearance.BorderSize = 0;
            this.navbar_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navbar_close.Image = global::GoBag.Properties.Resources.navbar_close;
            this.navbar_close.Location = new System.Drawing.Point(1232, 0);
            this.navbar_close.Name = "navbar_close";
            this.navbar_close.Size = new System.Drawing.Size(32, 32);
            this.navbar_close.TabIndex = 3;
            this.navbar_close.UseVisualStyleBackColor = true;
            this.navbar_close.Click += new System.EventHandler(this.navbar_close_Click);
            this.navbar_close.MouseEnter += new System.EventHandler(this.navbar_close_Enter);
            this.navbar_close.MouseLeave += new System.EventHandler(this.navbar_close_MouseLeave);
            // 
            // navbar_icon
            // 
            this.navbar_icon.Image = global::GoBag.Properties.Resources.navbar_logo;
            this.navbar_icon.Location = new System.Drawing.Point(32, 0);
            this.navbar_icon.Name = "navbar_icon";
            this.navbar_icon.Size = new System.Drawing.Size(100, 32);
            this.navbar_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.navbar_icon.TabIndex = 2;
            this.navbar_icon.TabStop = false;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.RoyalBlue;
            this.sidebar.Controls.Add(this.howtouse_button);
            this.sidebar.Controls.Add(this.editButton);
            this.sidebar.Controls.Add(this.expireWarningButton);
            this.sidebar.Controls.Add(this.sidebar_copyright);
            this.sidebar.Controls.Add(this.sidebar_version);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 32);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(170, 649);
            this.sidebar.TabIndex = 1;
            // 
            // editButton
            // 
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(1, 198);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(171, 37);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_button_Click);
            this.editButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.editButton_MouseDown);
            this.editButton.MouseEnter += new System.EventHandler(this.editButton_button_MouseEnter);
            this.editButton.MouseLeave += new System.EventHandler(this.editButton_MouseLeave);
            // 
            // expireWarningButton
            // 
            this.expireWarningButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expireWarningButton.FlatAppearance.BorderSize = 0;
            this.expireWarningButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expireWarningButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expireWarningButton.ForeColor = System.Drawing.Color.White;
            this.expireWarningButton.Location = new System.Drawing.Point(3, 156);
            this.expireWarningButton.Name = "expireWarningButton";
            this.expireWarningButton.Size = new System.Drawing.Size(167, 37);
            this.expireWarningButton.TabIndex = 6;
            this.expireWarningButton.Text = "Expire Warning";
            this.expireWarningButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expireWarningButton.UseVisualStyleBackColor = true;
            this.expireWarningButton.Click += new System.EventHandler(this.expireWarning_button_Click);
            this.expireWarningButton.MouseEnter += new System.EventHandler(this.expireWarningButton_MouseEnter);
            this.expireWarningButton.MouseLeave += new System.EventHandler(this.expireWarningButton_MouseLeave);
            // 
            // sidebar_copyright
            // 
            this.sidebar_copyright.AutoSize = true;
            this.sidebar_copyright.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidebar_copyright.ForeColor = System.Drawing.Color.White;
            this.sidebar_copyright.Location = new System.Drawing.Point(0, 630);
            this.sidebar_copyright.Name = "sidebar_copyright";
            this.sidebar_copyright.Size = new System.Drawing.Size(114, 17);
            this.sidebar_copyright.TabIndex = 3;
            this.sidebar_copyright.Text = "ⓒ 2024 LeeKiJoon";
            // 
            // sidebar_version
            // 
            this.sidebar_version.AutoSize = true;
            this.sidebar_version.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidebar_version.ForeColor = System.Drawing.Color.White;
            this.sidebar_version.Location = new System.Drawing.Point(120, 630);
            this.sidebar_version.Name = "sidebar_version";
            this.sidebar_version.Size = new System.Drawing.Size(47, 17);
            this.sidebar_version.TabIndex = 2;
            this.sidebar_version.Text = "V 1.0.0";
            // 
            // expireWarning
            // 
            this.expireWarning.Controls.Add(this.currentYear_label);
            this.expireWarning.Controls.Add(this.nextYear_label);
            this.expireWarning.Controls.Add(this.next2Year_label);
            this.expireWarning.Controls.Add(this.expire2NextYearDataView);
            this.expireWarning.Controls.Add(this.expireNextYearDataView);
            this.expireWarning.Controls.Add(this.expireDataView);
            this.expireWarning.Controls.Add(this.warning_title);
            this.expireWarning.Location = new System.Drawing.Point(170, 32);
            this.expireWarning.Name = "expireWarning";
            this.expireWarning.Size = new System.Drawing.Size(1094, 649);
            this.expireWarning.TabIndex = 2;
            // 
            // currentYear_label
            // 
            this.currentYear_label.AutoSize = true;
            this.currentYear_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentYear_label.ForeColor = System.Drawing.Color.Black;
            this.currentYear_label.Location = new System.Drawing.Point(168, 78);
            this.currentYear_label.Name = "currentYear_label";
            this.currentYear_label.Size = new System.Drawing.Size(158, 30);
            this.currentYear_label.TabIndex = 20;
            this.currentYear_label.Text = "Expire Warning";
            this.currentYear_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextYear_label
            // 
            this.nextYear_label.AutoSize = true;
            this.nextYear_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextYear_label.ForeColor = System.Drawing.Color.Black;
            this.nextYear_label.Location = new System.Drawing.Point(500, 78);
            this.nextYear_label.Name = "nextYear_label";
            this.nextYear_label.Size = new System.Drawing.Size(158, 30);
            this.nextYear_label.TabIndex = 19;
            this.nextYear_label.Text = "Expire Warning";
            this.nextYear_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next2Year_label
            // 
            this.next2Year_label.AutoSize = true;
            this.next2Year_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next2Year_label.ForeColor = System.Drawing.Color.Black;
            this.next2Year_label.Location = new System.Drawing.Point(842, 78);
            this.next2Year_label.Name = "next2Year_label";
            this.next2Year_label.Size = new System.Drawing.Size(158, 30);
            this.next2Year_label.TabIndex = 18;
            this.next2Year_label.Text = "Expire Warning";
            this.next2Year_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expire2NextYearDataView
            // 
            this.expire2NextYearDataView.BackgroundColor = System.Drawing.Color.White;
            this.expire2NextYearDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expire2NextYearDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expire2NextYearDataView.Location = new System.Drawing.Point(746, 122);
            this.expire2NextYearDataView.Name = "expire2NextYearDataView";
            this.expire2NextYearDataView.RowTemplate.Height = 23;
            this.expire2NextYearDataView.Size = new System.Drawing.Size(300, 465);
            this.expire2NextYearDataView.TabIndex = 17;
            // 
            // expireNextYearDataView
            // 
            this.expireNextYearDataView.BackgroundColor = System.Drawing.Color.White;
            this.expireNextYearDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expireNextYearDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expireNextYearDataView.Location = new System.Drawing.Point(398, 122);
            this.expireNextYearDataView.Name = "expireNextYearDataView";
            this.expireNextYearDataView.RowTemplate.Height = 23;
            this.expireNextYearDataView.Size = new System.Drawing.Size(327, 465);
            this.expireNextYearDataView.TabIndex = 16;
            // 
            // expireDataView
            // 
            this.expireDataView.BackgroundColor = System.Drawing.Color.White;
            this.expireDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expireDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expireDataView.Location = new System.Drawing.Point(80, 122);
            this.expireDataView.Name = "expireDataView";
            this.expireDataView.RowTemplate.Height = 23;
            this.expireDataView.Size = new System.Drawing.Size(300, 465);
            this.expireDataView.TabIndex = 15;
            // 
            // warning_title
            // 
            this.warning_title.AutoSize = true;
            this.warning_title.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_title.ForeColor = System.Drawing.Color.Black;
            this.warning_title.Location = new System.Drawing.Point(2, 3);
            this.warning_title.Name = "warning_title";
            this.warning_title.Size = new System.Drawing.Size(158, 30);
            this.warning_title.TabIndex = 14;
            this.warning_title.Text = "Expire Warning";
            // 
            // edit
            // 
            this.edit.Controls.Add(this.positionLabel);
            this.edit.Controls.Add(this.insertBox);
            this.edit.Controls.Add(this.dataView);
            this.edit.Controls.Add(this.editDatabase_title);
            this.edit.Location = new System.Drawing.Point(170, 32);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(1094, 649);
            this.edit.TabIndex = 13;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.ForeColor = System.Drawing.Color.Gray;
            this.positionLabel.Location = new System.Drawing.Point(7, 630);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(27, 17);
            this.positionLabel.TabIndex = 8;
            this.positionLabel.Text = "0/0";
            // 
            // insertBox
            // 
            this.insertBox.Controls.Add(this.moveLast_button);
            this.insertBox.Controls.Add(this.movePrevious_button);
            this.insertBox.Controls.Add(this.moveNext_button);
            this.insertBox.Controls.Add(this.moveFirst_button);
            this.insertBox.Controls.Add(this.autoId_label);
            this.insertBox.Controls.Add(this.autoId_textbox);
            this.insertBox.Controls.Add(this.saveButton);
            this.insertBox.Controls.Add(this.expiration_textbox);
            this.insertBox.Controls.Add(this.more_textbox);
            this.insertBox.Controls.Add(this.deleteButton);
            this.insertBox.Controls.Add(this.refreshButton);
            this.insertBox.Controls.Add(this.piece_textbox);
            this.insertBox.Controls.Add(this.addButton);
            this.insertBox.Controls.Add(this.description_textbox);
            this.insertBox.Controls.Add(this.more_label);
            this.insertBox.Controls.Add(this.expiration_label);
            this.insertBox.Controls.Add(this.piece_label);
            this.insertBox.Controls.Add(this.description_label);
            this.insertBox.Controls.Add(this.name_label);
            this.insertBox.Controls.Add(this.name_textbox);
            this.insertBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBox.Location = new System.Drawing.Point(7, 36);
            this.insertBox.Name = "insertBox";
            this.insertBox.Size = new System.Drawing.Size(410, 579);
            this.insertBox.TabIndex = 10;
            this.insertBox.TabStop = false;
            this.insertBox.Text = "Insert Box";
            // 
            // moveLast_button
            // 
            this.moveLast_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.moveLast_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveLast_button.FlatAppearance.BorderSize = 0;
            this.moveLast_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveLast_button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveLast_button.ForeColor = System.Drawing.Color.White;
            this.moveLast_button.Location = new System.Drawing.Point(315, 283);
            this.moveLast_button.Name = "moveLast_button";
            this.moveLast_button.Size = new System.Drawing.Size(70, 50);
            this.moveLast_button.TabIndex = 32;
            this.moveLast_button.Text = ">>";
            this.moveLast_button.UseVisualStyleBackColor = false;
            this.moveLast_button.Click += new System.EventHandler(this.moveLast_button_Click);
            // 
            // movePrevious_button
            // 
            this.movePrevious_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.movePrevious_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.movePrevious_button.FlatAppearance.BorderSize = 0;
            this.movePrevious_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movePrevious_button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movePrevious_button.ForeColor = System.Drawing.Color.White;
            this.movePrevious_button.Location = new System.Drawing.Point(117, 283);
            this.movePrevious_button.Name = "movePrevious_button";
            this.movePrevious_button.Size = new System.Drawing.Size(70, 50);
            this.movePrevious_button.TabIndex = 31;
            this.movePrevious_button.Text = "<";
            this.movePrevious_button.UseVisualStyleBackColor = false;
            this.movePrevious_button.Click += new System.EventHandler(this.movePrevious_button_Click);
            // 
            // moveNext_button
            // 
            this.moveNext_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.moveNext_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveNext_button.FlatAppearance.BorderSize = 0;
            this.moveNext_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveNext_button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveNext_button.ForeColor = System.Drawing.Color.White;
            this.moveNext_button.Location = new System.Drawing.Point(216, 283);
            this.moveNext_button.Name = "moveNext_button";
            this.moveNext_button.Size = new System.Drawing.Size(70, 50);
            this.moveNext_button.TabIndex = 30;
            this.moveNext_button.Text = ">";
            this.moveNext_button.UseVisualStyleBackColor = false;
            this.moveNext_button.Click += new System.EventHandler(this.moveNext_Click);
            // 
            // moveFirst_button
            // 
            this.moveFirst_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.moveFirst_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveFirst_button.FlatAppearance.BorderSize = 0;
            this.moveFirst_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveFirst_button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveFirst_button.ForeColor = System.Drawing.Color.White;
            this.moveFirst_button.Location = new System.Drawing.Point(18, 283);
            this.moveFirst_button.Name = "moveFirst_button";
            this.moveFirst_button.Size = new System.Drawing.Size(70, 50);
            this.moveFirst_button.TabIndex = 29;
            this.moveFirst_button.Text = "<<";
            this.moveFirst_button.UseVisualStyleBackColor = false;
            this.moveFirst_button.Click += new System.EventHandler(this.moveFirst_button_Click);
            // 
            // autoId_label
            // 
            this.autoId_label.AutoSize = true;
            this.autoId_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoId_label.ForeColor = System.Drawing.Color.Black;
            this.autoId_label.Location = new System.Drawing.Point(13, 63);
            this.autoId_label.Name = "autoId_label";
            this.autoId_label.Size = new System.Drawing.Size(34, 30);
            this.autoId_label.TabIndex = 27;
            this.autoId_label.Text = "ID";
            // 
            // autoId_textbox
            // 
            this.autoId_textbox.Location = new System.Drawing.Point(150, 66);
            this.autoId_textbox.Name = "autoId_textbox";
            this.autoId_textbox.Size = new System.Drawing.Size(254, 27);
            this.autoId_textbox.TabIndex = 28;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(11, 524);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(117, 37);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // expiration_textbox
            // 
            this.expiration_textbox.Location = new System.Drawing.Point(150, 194);
            this.expiration_textbox.Name = "expiration_textbox";
            this.expiration_textbox.Size = new System.Drawing.Size(254, 27);
            this.expiration_textbox.TabIndex = 26;
            // 
            // more_textbox
            // 
            this.more_textbox.Location = new System.Drawing.Point(150, 225);
            this.more_textbox.Name = "more_textbox";
            this.more_textbox.Size = new System.Drawing.Size(254, 27);
            this.more_textbox.TabIndex = 25;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(283, 464);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 37);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(11, 464);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(117, 37);
            this.refreshButton.TabIndex = 12;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // piece_textbox
            // 
            this.piece_textbox.Location = new System.Drawing.Point(150, 161);
            this.piece_textbox.Name = "piece_textbox";
            this.piece_textbox.Size = new System.Drawing.Size(254, 27);
            this.piece_textbox.TabIndex = 23;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(146, 464);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 37);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // description_textbox
            // 
            this.description_textbox.Location = new System.Drawing.Point(150, 130);
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(254, 27);
            this.description_textbox.TabIndex = 22;
            // 
            // more_label
            // 
            this.more_label.AutoSize = true;
            this.more_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.more_label.ForeColor = System.Drawing.Color.Black;
            this.more_label.Location = new System.Drawing.Point(13, 216);
            this.more_label.Name = "more_label";
            this.more_label.Size = new System.Drawing.Size(64, 30);
            this.more_label.TabIndex = 21;
            this.more_label.Text = "More";
            // 
            // expiration_label
            // 
            this.expiration_label.AutoSize = true;
            this.expiration_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiration_label.ForeColor = System.Drawing.Color.Black;
            this.expiration_label.Location = new System.Drawing.Point(13, 186);
            this.expiration_label.Name = "expiration_label";
            this.expiration_label.Size = new System.Drawing.Size(110, 30);
            this.expiration_label.TabIndex = 20;
            this.expiration_label.Text = "Expiration";
            // 
            // piece_label
            // 
            this.piece_label.AutoSize = true;
            this.piece_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piece_label.ForeColor = System.Drawing.Color.Black;
            this.piece_label.Location = new System.Drawing.Point(13, 156);
            this.piece_label.Name = "piece_label";
            this.piece_label.Size = new System.Drawing.Size(62, 30);
            this.piece_label.TabIndex = 19;
            this.piece_label.Text = "Piece";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.ForeColor = System.Drawing.Color.Black;
            this.description_label.Location = new System.Drawing.Point(13, 126);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(122, 30);
            this.description_label.TabIndex = 18;
            this.description_label.Text = "Description";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.Black;
            this.name_label.Location = new System.Drawing.Point(13, 96);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(70, 30);
            this.name_label.TabIndex = 16;
            this.name_label.Text = "Name";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(150, 99);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(254, 27);
            this.name_textbox.TabIndex = 17;
            // 
            // dataView
            // 
            this.dataView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(423, 45);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowTemplate.Height = 23;
            this.dataView.Size = new System.Drawing.Size(635, 592);
            this.dataView.TabIndex = 9;
            this.dataView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataView_CellMouseClick);
            this.dataView.SelectionChanged += new System.EventHandler(this.dataView_SelectionChanged);
            // 
            // editDatabase_title
            // 
            this.editDatabase_title.AutoSize = true;
            this.editDatabase_title.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDatabase_title.ForeColor = System.Drawing.Color.Black;
            this.editDatabase_title.Location = new System.Drawing.Point(2, 0);
            this.editDatabase_title.Name = "editDatabase_title";
            this.editDatabase_title.Size = new System.Drawing.Size(145, 30);
            this.editDatabase_title.TabIndex = 8;
            this.editDatabase_title.Text = "Edit Database";
            // 
            // howtouse_panel
            // 
            this.howtouse_panel.Controls.Add(this.pictureBox1);
            this.howtouse_panel.Controls.Add(this.label2);
            this.howtouse_panel.Location = new System.Drawing.Point(170, 32);
            this.howtouse_panel.Name = "howtouse_panel";
            this.howtouse_panel.Size = new System.Drawing.Size(1094, 649);
            this.howtouse_panel.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "How to use";
            // 
            // howtouse_button
            // 
            this.howtouse_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.howtouse_button.FlatAppearance.BorderSize = 0;
            this.howtouse_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.howtouse_button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howtouse_button.ForeColor = System.Drawing.Color.White;
            this.howtouse_button.Location = new System.Drawing.Point(0, 240);
            this.howtouse_button.Name = "howtouse_button";
            this.howtouse_button.Size = new System.Drawing.Size(171, 37);
            this.howtouse_button.TabIndex = 8;
            this.howtouse_button.Text = "How To Use";
            this.howtouse_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.howtouse_button.UseVisualStyleBackColor = true;
            this.howtouse_button.Click += new System.EventHandler(this.howtouse_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1037, 582);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.howtouse_panel);
            this.Controls.Add(this.expireWarning);
            this.Controls.Add(this.edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoBag V1.0.0";
            this.Load += new System.EventHandler(this.main_Load);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navbar_picture_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbar_icon)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.expireWarning.ResumeLayout(false);
            this.expireWarning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expire2NextYearDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expireNextYearDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expireDataView)).EndInit();
            this.edit.ResumeLayout(false);
            this.edit.PerformLayout();
            this.insertBox.ResumeLayout(false);
            this.insertBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.howtouse_panel.ResumeLayout(false);
            this.howtouse_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.PictureBox navbar_icon;
        private System.Windows.Forms.Button navbar_minimize;
        private System.Windows.Forms.Button navbar_close;
        private System.Windows.Forms.PictureBox navbar_picture_logo;
        private System.Windows.Forms.Label sidebar_copyright;
        private System.Windows.Forms.Label sidebar_version;
        private System.Windows.Forms.Panel expireWarning;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button expireWarningButton;
        private System.Windows.Forms.Panel edit;
        private System.Windows.Forms.Label warning_title;
        private System.Windows.Forms.Label editDatabase_title;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox insertBox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label more_label;
        private System.Windows.Forms.Label expiration_label;
        private System.Windows.Forms.Label piece_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.TextBox piece_textbox;
        private System.Windows.Forms.TextBox description_textbox;
        private System.Windows.Forms.TextBox more_textbox;
        private System.Windows.Forms.TextBox expiration_textbox;
        private System.Windows.Forms.Label autoId_label;
        private System.Windows.Forms.TextBox autoId_textbox;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Button moveLast_button;
        private System.Windows.Forms.Button movePrevious_button;
        private System.Windows.Forms.Button moveNext_button;
        private System.Windows.Forms.Button moveFirst_button;
        private System.Windows.Forms.DataGridView expireDataView;
        private System.Windows.Forms.DataGridView expire2NextYearDataView;
        private System.Windows.Forms.DataGridView expireNextYearDataView;
        private System.Windows.Forms.Label currentYear_label;
        private System.Windows.Forms.Label nextYear_label;
        private System.Windows.Forms.Label next2Year_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel howtouse_panel;
        private System.Windows.Forms.Button howtouse_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

