namespace Fasr_n_Furious
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdminLabel = new System.Windows.Forms.Label();
            this.ActionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TableComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.VerifiedComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.RoleTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.InfoDeleteButton = new System.Windows.Forms.Button();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.InfoUpdateButton = new System.Windows.Forms.Button();
            this.InfoInsertButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.TableActionLabel = new System.Windows.Forms.Label();
            this.RolePanel = new System.Windows.Forms.Panel();
            this.RoleDeleteButton = new System.Windows.Forms.Button();
            this.RoleUpdateButton = new System.Windows.Forms.Button();
            this.RoleInsertButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.RoleNameTextBox = new System.Windows.Forms.TextBox();
            this.RoleIdTextBox = new System.Windows.Forms.TextBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LastnameTextBox = new System.Windows.Forms.TextBox();
            this.InfoNameTextBox = new System.Windows.Forms.TextBox();
            this.InfoIdTextBox = new System.Windows.Forms.TextBox();
            this.RacePanel = new System.Windows.Forms.Panel();
            this.RaceDeleteButton = new System.Windows.Forms.Button();
            this.RaceUpdateButton = new System.Windows.Forms.Button();
            this.RaceInsertButton = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.PointsLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.PointsTextBox = new System.Windows.Forms.TextBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.RaceUserIdTextBox = new System.Windows.Forms.TextBox();
            this.RaceIdTextBox = new System.Windows.Forms.TextBox();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.UserPanel.SuspendLayout();
            this.RolePanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.RacePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel.Location = new System.Drawing.Point(12, 9);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(66, 22);
            this.AdminLabel.TabIndex = 0;
            this.AdminLabel.Text = "Admin";
            // 
            // ActionComboBox
            // 
            this.ActionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActionComboBox.FormattingEnabled = true;
            this.ActionComboBox.Items.AddRange(new object[] {
            "insert",
            "update",
            "delete"});
            this.ActionComboBox.Location = new System.Drawing.Point(157, 74);
            this.ActionComboBox.Name = "ActionComboBox";
            this.ActionComboBox.Size = new System.Drawing.Size(121, 21);
            this.ActionComboBox.TabIndex = 1;
            this.ActionComboBox.TextChanged += new System.EventHandler(this.ActionComboBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose action";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose table";
            // 
            // TableComboBox
            // 
            this.TableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableComboBox.FormattingEnabled = true;
            this.TableComboBox.Items.AddRange(new object[] {
            "Users",
            "UserInfos",
            "Roles",
            "Races"});
            this.TableComboBox.Location = new System.Drawing.Point(16, 74);
            this.TableComboBox.Name = "TableComboBox";
            this.TableComboBox.Size = new System.Drawing.Size(121, 21);
            this.TableComboBox.TabIndex = 3;
            this.TableComboBox.TextChanged += new System.EventHandler(this.TableComboBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(304, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(731, 445);
            this.dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data";
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.Color.Transparent;
            this.UserPanel.Controls.Add(this.VerifiedComboBox);
            this.UserPanel.Controls.Add(this.label10);
            this.UserPanel.Controls.Add(this.DeleteButton);
            this.UserPanel.Controls.Add(this.label7);
            this.UserPanel.Controls.Add(this.label6);
            this.UserPanel.Controls.Add(this.UpdateButton);
            this.UserPanel.Controls.Add(this.label11);
            this.UserPanel.Controls.Add(this.label5);
            this.UserPanel.Controls.Add(this.InsertButton);
            this.UserPanel.Controls.Add(this.label4);
            this.UserPanel.Controls.Add(this.EmailTextBox);
            this.UserPanel.Controls.Add(this.PasswordTextBox);
            this.UserPanel.Controls.Add(this.UsernameTextBox);
            this.UserPanel.Controls.Add(this.RoleTextBox);
            this.UserPanel.Controls.Add(this.IdTextBox);
            this.UserPanel.Location = new System.Drawing.Point(16, 163);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(262, 324);
            this.UserPanel.TabIndex = 7;
            this.UserPanel.Visible = false;
            // 
            // VerifiedComboBox
            // 
            this.VerifiedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VerifiedComboBox.FormattingEnabled = true;
            this.VerifiedComboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.VerifiedComboBox.Location = new System.Drawing.Point(79, 195);
            this.VerifiedComboBox.Name = "VerifiedComboBox";
            this.VerifiedComboBox.Size = new System.Drawing.Size(100, 21);
            this.VerifiedComboBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Role ID";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(93, 277);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(93, 277);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Verified";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Username";
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(93, 277);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 12;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(79, 106);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmailTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(79, 152);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(79, 64);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.UsernameTextBox.TabIndex = 1;
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.Location = new System.Drawing.Point(79, 239);
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.Size = new System.Drawing.Size(100, 20);
            this.RoleTextBox.TabIndex = 5;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(79, 22);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 0;
            // 
            // InfoDeleteButton
            // 
            this.InfoDeleteButton.Location = new System.Drawing.Point(93, 275);
            this.InfoDeleteButton.Name = "InfoDeleteButton";
            this.InfoDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.InfoDeleteButton.TabIndex = 15;
            this.InfoDeleteButton.Text = "Delete";
            this.InfoDeleteButton.UseVisualStyleBackColor = true;
            this.InfoDeleteButton.Click += new System.EventHandler(this.InfoDeleteButton_Click);
            // 
            // SexComboBox
            // 
            this.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.SexComboBox.Location = new System.Drawing.Point(79, 193);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(100, 21);
            this.SexComboBox.TabIndex = 14;
            // 
            // InfoUpdateButton
            // 
            this.InfoUpdateButton.Location = new System.Drawing.Point(92, 275);
            this.InfoUpdateButton.Name = "InfoUpdateButton";
            this.InfoUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.InfoUpdateButton.TabIndex = 13;
            this.InfoUpdateButton.Text = "Update";
            this.InfoUpdateButton.UseVisualStyleBackColor = true;
            this.InfoUpdateButton.Click += new System.EventHandler(this.InfoUpdateButton_Click);
            // 
            // InfoInsertButton
            // 
            this.InfoInsertButton.Location = new System.Drawing.Point(93, 275);
            this.InfoInsertButton.Name = "InfoInsertButton";
            this.InfoInsertButton.Size = new System.Drawing.Size(75, 23);
            this.InfoInsertButton.TabIndex = 12;
            this.InfoInsertButton.Text = "Insert";
            this.InfoInsertButton.UseVisualStyleBackColor = true;
            this.InfoInsertButton.Click += new System.EventHandler(this.InfoInsertButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Sex";
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(79, 237);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountryTextBox.TabIndex = 5;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(79, 151);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AgeTextBox.TabIndex = 2;
            // 
            // TableActionLabel
            // 
            this.TableActionLabel.AutoSize = true;
            this.TableActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableActionLabel.Location = new System.Drawing.Point(99, 132);
            this.TableActionLabel.Name = "TableActionLabel";
            this.TableActionLabel.Size = new System.Drawing.Size(88, 16);
            this.TableActionLabel.TabIndex = 15;
            this.TableActionLabel.Text = "table action";
            // 
            // RolePanel
            // 
            this.RolePanel.BackColor = System.Drawing.Color.Transparent;
            this.RolePanel.Controls.Add(this.RoleDeleteButton);
            this.RolePanel.Controls.Add(this.RoleUpdateButton);
            this.RolePanel.Controls.Add(this.RoleInsertButton);
            this.RolePanel.Controls.Add(this.label14);
            this.RolePanel.Controls.Add(this.label15);
            this.RolePanel.Controls.Add(this.RoleNameTextBox);
            this.RolePanel.Controls.Add(this.RoleIdTextBox);
            this.RolePanel.Location = new System.Drawing.Point(16, 163);
            this.RolePanel.Name = "RolePanel";
            this.RolePanel.Size = new System.Drawing.Size(262, 147);
            this.RolePanel.TabIndex = 16;
            this.RolePanel.Visible = false;
            // 
            // RoleDeleteButton
            // 
            this.RoleDeleteButton.Location = new System.Drawing.Point(92, 103);
            this.RoleDeleteButton.Name = "RoleDeleteButton";
            this.RoleDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.RoleDeleteButton.TabIndex = 15;
            this.RoleDeleteButton.Text = "Delete";
            this.RoleDeleteButton.UseVisualStyleBackColor = true;
            this.RoleDeleteButton.Click += new System.EventHandler(this.RoleDeleteButton_Click);
            // 
            // RoleUpdateButton
            // 
            this.RoleUpdateButton.Location = new System.Drawing.Point(92, 103);
            this.RoleUpdateButton.Name = "RoleUpdateButton";
            this.RoleUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.RoleUpdateButton.TabIndex = 13;
            this.RoleUpdateButton.Text = "Update";
            this.RoleUpdateButton.UseVisualStyleBackColor = true;
            this.RoleUpdateButton.Click += new System.EventHandler(this.RoleUpdateButton_Click);
            // 
            // RoleInsertButton
            // 
            this.RoleInsertButton.Location = new System.Drawing.Point(92, 103);
            this.RoleInsertButton.Name = "RoleInsertButton";
            this.RoleInsertButton.Size = new System.Drawing.Size(75, 23);
            this.RoleInsertButton.TabIndex = 12;
            this.RoleInsertButton.Text = "Insert";
            this.RoleInsertButton.UseVisualStyleBackColor = true;
            this.RoleInsertButton.Click += new System.EventHandler(this.RoleInsertButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(108, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(117, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "ID";
            // 
            // RoleNameTextBox
            // 
            this.RoleNameTextBox.Location = new System.Drawing.Point(79, 64);
            this.RoleNameTextBox.Name = "RoleNameTextBox";
            this.RoleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.RoleNameTextBox.TabIndex = 1;
            // 
            // RoleIdTextBox
            // 
            this.RoleIdTextBox.Location = new System.Drawing.Point(79, 22);
            this.RoleIdTextBox.Name = "RoleIdTextBox";
            this.RoleIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.RoleIdTextBox.TabIndex = 0;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.InfoPanel.Controls.Add(this.InfoDeleteButton);
            this.InfoPanel.Controls.Add(this.InfoUpdateButton);
            this.InfoPanel.Controls.Add(this.SexComboBox);
            this.InfoPanel.Controls.Add(this.InfoInsertButton);
            this.InfoPanel.Controls.Add(this.label8);
            this.InfoPanel.Controls.Add(this.label9);
            this.InfoPanel.Controls.Add(this.label12);
            this.InfoPanel.Controls.Add(this.label13);
            this.InfoPanel.Controls.Add(this.label16);
            this.InfoPanel.Controls.Add(this.label17);
            this.InfoPanel.Controls.Add(this.CountryTextBox);
            this.InfoPanel.Controls.Add(this.LastnameTextBox);
            this.InfoPanel.Controls.Add(this.InfoNameTextBox);
            this.InfoPanel.Controls.Add(this.AgeTextBox);
            this.InfoPanel.Controls.Add(this.InfoIdTextBox);
            this.InfoPanel.Location = new System.Drawing.Point(16, 163);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(262, 324);
            this.InfoPanel.TabIndex = 16;
            this.InfoPanel.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(114, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Age";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(100, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Lastname";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(107, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(106, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "User ID";
            // 
            // LastnameTextBox
            // 
            this.LastnameTextBox.Location = new System.Drawing.Point(79, 106);
            this.LastnameTextBox.Name = "LastnameTextBox";
            this.LastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastnameTextBox.TabIndex = 3;
            // 
            // InfoNameTextBox
            // 
            this.InfoNameTextBox.Location = new System.Drawing.Point(79, 64);
            this.InfoNameTextBox.Name = "InfoNameTextBox";
            this.InfoNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.InfoNameTextBox.TabIndex = 1;
            // 
            // InfoIdTextBox
            // 
            this.InfoIdTextBox.Location = new System.Drawing.Point(79, 22);
            this.InfoIdTextBox.Name = "InfoIdTextBox";
            this.InfoIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.InfoIdTextBox.TabIndex = 0;
            // 
            // RacePanel
            // 
            this.RacePanel.BackColor = System.Drawing.Color.Transparent;
            this.RacePanel.Controls.Add(this.RaceDeleteButton);
            this.RacePanel.Controls.Add(this.RaceUpdateButton);
            this.RacePanel.Controls.Add(this.RaceInsertButton);
            this.RacePanel.Controls.Add(this.label20);
            this.RacePanel.Controls.Add(this.PointsLabel);
            this.RacePanel.Controls.Add(this.DurationLabel);
            this.RacePanel.Controls.Add(this.label23);
            this.RacePanel.Controls.Add(this.PointsTextBox);
            this.RacePanel.Controls.Add(this.DurationTextBox);
            this.RacePanel.Controls.Add(this.RaceUserIdTextBox);
            this.RacePanel.Controls.Add(this.RaceIdTextBox);
            this.RacePanel.Location = new System.Drawing.Point(16, 163);
            this.RacePanel.Name = "RacePanel";
            this.RacePanel.Size = new System.Drawing.Size(262, 245);
            this.RacePanel.TabIndex = 17;
            this.RacePanel.Visible = false;
            // 
            // RaceDeleteButton
            // 
            this.RaceDeleteButton.Location = new System.Drawing.Point(93, 193);
            this.RaceDeleteButton.Name = "RaceDeleteButton";
            this.RaceDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.RaceDeleteButton.TabIndex = 15;
            this.RaceDeleteButton.Text = "Delete";
            this.RaceDeleteButton.UseVisualStyleBackColor = true;
            this.RaceDeleteButton.Click += new System.EventHandler(this.RaceDeleteButton_Click);
            // 
            // RaceUpdateButton
            // 
            this.RaceUpdateButton.Location = new System.Drawing.Point(92, 193);
            this.RaceUpdateButton.Name = "RaceUpdateButton";
            this.RaceUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.RaceUpdateButton.TabIndex = 13;
            this.RaceUpdateButton.Text = "Update";
            this.RaceUpdateButton.UseVisualStyleBackColor = true;
            this.RaceUpdateButton.Click += new System.EventHandler(this.RaceUpdateButton_Click);
            // 
            // RaceInsertButton
            // 
            this.RaceInsertButton.Location = new System.Drawing.Point(92, 193);
            this.RaceInsertButton.Name = "RaceInsertButton";
            this.RaceInsertButton.Size = new System.Drawing.Size(75, 23);
            this.RaceInsertButton.TabIndex = 12;
            this.RaceInsertButton.Text = "Insert";
            this.RaceInsertButton.UseVisualStyleBackColor = true;
            this.RaceInsertButton.Click += new System.EventHandler(this.RaceInsertButton_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(106, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "User ID";
            // 
            // PointsLabel
            // 
            this.PointsLabel.AutoSize = true;
            this.PointsLabel.Location = new System.Drawing.Point(110, 90);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(36, 13);
            this.PointsLabel.TabIndex = 8;
            this.PointsLabel.Text = "Points";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(107, 48);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(47, 13);
            this.DurationLabel.TabIndex = 7;
            this.DurationLabel.Text = "Duration";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(106, 6);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Race ID";
            // 
            // PointsTextBox
            // 
            this.PointsTextBox.Location = new System.Drawing.Point(79, 106);
            this.PointsTextBox.Name = "PointsTextBox";
            this.PointsTextBox.Size = new System.Drawing.Size(100, 20);
            this.PointsTextBox.TabIndex = 3;
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(79, 64);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(100, 20);
            this.DurationTextBox.TabIndex = 1;
            // 
            // RaceUserIdTextBox
            // 
            this.RaceUserIdTextBox.Location = new System.Drawing.Point(79, 151);
            this.RaceUserIdTextBox.Name = "RaceUserIdTextBox";
            this.RaceUserIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.RaceUserIdTextBox.TabIndex = 2;
            // 
            // RaceIdTextBox
            // 
            this.RaceIdTextBox.Location = new System.Drawing.Point(79, 22);
            this.RaceIdTextBox.Name = "RaceIdTextBox";
            this.RaceIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.RaceIdTextBox.TabIndex = 0;
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold);
            this.LogoutLabel.Location = new System.Drawing.Point(14, 565);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(63, 18);
            this.LogoutLabel.TabIndex = 17;
            this.LogoutLabel.Text = "Log Out";
            this.LogoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(901, 48);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(134, 20);
            this.SearchTextBox.TabIndex = 18;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(839, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 18);
            this.label18.TabIndex = 19;
            this.label18.Text = "Search:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 595);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.RacePanel);
            this.Controls.Add(this.LogoutLabel);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.RolePanel);
            this.Controls.Add(this.TableActionLabel);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TableComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActionComboBox);
            this.Controls.Add(this.AdminLabel);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            this.RolePanel.ResumeLayout(false);
            this.RolePanel.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.RacePanel.ResumeLayout(false);
            this.RacePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.ComboBox ActionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TableComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button InfoInsertButton;
        private System.Windows.Forms.Button InfoUpdateButton;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.Label TableActionLabel;
        private System.Windows.Forms.Button InfoDeleteButton;
        private System.Windows.Forms.Panel RolePanel;
        private System.Windows.Forms.Button RoleDeleteButton;
        private System.Windows.Forms.Button RoleUpdateButton;
        private System.Windows.Forms.Button RoleInsertButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox RoleNameTextBox;
        private System.Windows.Forms.TextBox RoleIdTextBox;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ComboBox VerifiedComboBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox RoleTextBox;
        private System.Windows.Forms.TextBox LastnameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox InfoNameTextBox;
        private System.Windows.Forms.TextBox InfoIdTextBox;
        private System.Windows.Forms.Label LogoutLabel;
        private System.Windows.Forms.Panel RacePanel;
        private System.Windows.Forms.Button RaceDeleteButton;
        private System.Windows.Forms.Button RaceUpdateButton;
        private System.Windows.Forms.Button RaceInsertButton;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label PointsLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox PointsTextBox;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.TextBox RaceUserIdTextBox;
        private System.Windows.Forms.TextBox RaceIdTextBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label18;
    }
}