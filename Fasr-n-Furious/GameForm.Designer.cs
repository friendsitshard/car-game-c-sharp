namespace Fasr_n_Furious
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.EnemyPictureBox = new System.Windows.Forms.PictureBox();
            this.CarPictureBox = new System.Windows.Forms.PictureBox();
            this.MapPictureBox = new System.Windows.Forms.PictureBox();
            this.MapPictureBox2 = new System.Windows.Forms.PictureBox();
            this.EnemyPictureBox2 = new System.Windows.Forms.PictureBox();
            this.LosePanel = new System.Windows.Forms.Panel();
            this.HighscoreLabel = new System.Windows.Forms.Label();
            this.CurrentPointsLabel = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoseLabel = new System.Windows.Forms.Label();
            this.PointsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Points = new System.Windows.Forms.Label();
            this.PlayerPanel = new System.Windows.Forms.Panel();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPictureBox2)).BeginInit();
            this.LosePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PlayerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // EnemyPictureBox
            // 
            this.EnemyPictureBox.Image = global::Fasr_n_Furious.Properties.Resources.enemy_car;
            this.EnemyPictureBox.Location = new System.Drawing.Point(199, -150);
            this.EnemyPictureBox.Name = "EnemyPictureBox";
            this.EnemyPictureBox.Size = new System.Drawing.Size(100, 130);
            this.EnemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyPictureBox.TabIndex = 3;
            this.EnemyPictureBox.TabStop = false;
            // 
            // CarPictureBox
            // 
            this.CarPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CarPictureBox.Image")));
            this.CarPictureBox.Location = new System.Drawing.Point(436, 500);
            this.CarPictureBox.Name = "CarPictureBox";
            this.CarPictureBox.Size = new System.Drawing.Size(100, 130);
            this.CarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarPictureBox.TabIndex = 1;
            this.CarPictureBox.TabStop = false;
            // 
            // MapPictureBox
            // 
            this.MapPictureBox.Image = global::Fasr_n_Furious.Properties.Resources.bg;
            this.MapPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MapPictureBox.Name = "MapPictureBox";
            this.MapPictureBox.Size = new System.Drawing.Size(840, 650);
            this.MapPictureBox.TabIndex = 0;
            this.MapPictureBox.TabStop = false;
            // 
            // MapPictureBox2
            // 
            this.MapPictureBox2.Image = global::Fasr_n_Furious.Properties.Resources.bg;
            this.MapPictureBox2.Location = new System.Drawing.Point(0, -650);
            this.MapPictureBox2.Name = "MapPictureBox2";
            this.MapPictureBox2.Size = new System.Drawing.Size(840, 650);
            this.MapPictureBox2.TabIndex = 2;
            this.MapPictureBox2.TabStop = false;
            // 
            // EnemyPictureBox2
            // 
            this.EnemyPictureBox2.Image = global::Fasr_n_Furious.Properties.Resources.enemy_car;
            this.EnemyPictureBox2.Location = new System.Drawing.Point(544, -400);
            this.EnemyPictureBox2.Name = "EnemyPictureBox2";
            this.EnemyPictureBox2.Size = new System.Drawing.Size(100, 130);
            this.EnemyPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyPictureBox2.TabIndex = 4;
            this.EnemyPictureBox2.TabStop = false;
            // 
            // LosePanel
            // 
            this.LosePanel.BackColor = System.Drawing.Color.White;
            this.LosePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LosePanel.Controls.Add(this.HomeButton);
            this.LosePanel.Controls.Add(this.HighscoreLabel);
            this.LosePanel.Controls.Add(this.CurrentPointsLabel);
            this.LosePanel.Controls.Add(this.RestartButton);
            this.LosePanel.Controls.Add(this.label2);
            this.LosePanel.Controls.Add(this.label1);
            this.LosePanel.Controls.Add(this.LoseLabel);
            this.LosePanel.Location = new System.Drawing.Point(270, 166);
            this.LosePanel.Name = "LosePanel";
            this.LosePanel.Size = new System.Drawing.Size(304, 235);
            this.LosePanel.TabIndex = 5;
            this.LosePanel.Visible = false;
            // 
            // HighscoreLabel
            // 
            this.HighscoreLabel.AutoSize = true;
            this.HighscoreLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.HighscoreLabel.Location = new System.Drawing.Point(170, 118);
            this.HighscoreLabel.Name = "HighscoreLabel";
            this.HighscoreLabel.Size = new System.Drawing.Size(27, 29);
            this.HighscoreLabel.TabIndex = 6;
            this.HighscoreLabel.Text = "0";
            // 
            // CurrentPointsLabel
            // 
            this.CurrentPointsLabel.AutoSize = true;
            this.CurrentPointsLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.CurrentPointsLabel.Location = new System.Drawing.Point(170, 77);
            this.CurrentPointsLabel.Name = "CurrentPointsLabel";
            this.CurrentPointsLabel.Size = new System.Drawing.Size(27, 29);
            this.CurrentPointsLabel.TabIndex = 5;
            this.CurrentPointsLabel.Text = "0";
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(109, 160);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(75, 23);
            this.RestartButton.TabIndex = 3;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Highscore:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your score:";
            // 
            // LoseLabel
            // 
            this.LoseLabel.AutoSize = true;
            this.LoseLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoseLabel.Location = new System.Drawing.Point(88, 32);
            this.LoseLabel.Name = "LoseLabel";
            this.LoseLabel.Size = new System.Drawing.Size(117, 29);
            this.LoseLabel.TabIndex = 0;
            this.LoseLabel.Text = "You Lose!";
            // 
            // PointsLabel
            // 
            this.PointsLabel.AutoSize = true;
            this.PointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.PointsLabel.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.PointsLabel.Location = new System.Drawing.Point(-4, 2);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(82, 25);
            this.PointsLabel.TabIndex = 6;
            this.PointsLabel.Text = "Points: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Points);
            this.panel1.Controls.Add(this.PointsLabel);
            this.panel1.Location = new System.Drawing.Point(681, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 33);
            this.panel1.TabIndex = 6;
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.BackColor = System.Drawing.Color.Transparent;
            this.Points.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.Points.Location = new System.Drawing.Point(68, 2);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(24, 25);
            this.Points.TabIndex = 7;
            this.Points.Text = "0";
            // 
            // PlayerPanel
            // 
            this.PlayerPanel.BackColor = System.Drawing.Color.Orange;
            this.PlayerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerPanel.Controls.Add(this.LogoutLabel);
            this.PlayerPanel.Controls.Add(this.UsernameLabel);
            this.PlayerPanel.Location = new System.Drawing.Point(0, 0);
            this.PlayerPanel.Name = "PlayerPanel";
            this.PlayerPanel.Size = new System.Drawing.Size(131, 62);
            this.PlayerPanel.TabIndex = 7;
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLabel.Location = new System.Drawing.Point(3, 37);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(64, 18);
            this.LogoutLabel.TabIndex = 7;
            this.LogoutLabel.Text = "Log Out";
            this.LogoutLabel.Click += new System.EventHandler(this.Logout_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.UsernameLabel.Location = new System.Drawing.Point(1, 7);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(71, 25);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "Player";
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(109, 190);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 23);
            this.HomeButton.TabIndex = 7;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.Logout_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.PlayerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LosePanel);
            this.Controls.Add(this.EnemyPictureBox2);
            this.Controls.Add(this.EnemyPictureBox);
            this.Controls.Add(this.CarPictureBox);
            this.Controls.Add(this.MapPictureBox);
            this.Controls.Add(this.MapPictureBox2);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast and Furious";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPictureBox2)).EndInit();
            this.LosePanel.ResumeLayout(false);
            this.LosePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PlayerPanel.ResumeLayout(false);
            this.PlayerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MapPictureBox;
        private System.Windows.Forms.PictureBox CarPictureBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox MapPictureBox2;
        private System.Windows.Forms.PictureBox EnemyPictureBox;
        private System.Windows.Forms.PictureBox EnemyPictureBox2;
        private System.Windows.Forms.Panel LosePanel;
        private System.Windows.Forms.Label LoseLabel;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PointsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.Label CurrentPointsLabel;
        private System.Windows.Forms.Label HighscoreLabel;
        private System.Windows.Forms.Panel PlayerPanel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label LogoutLabel;
        private System.Windows.Forms.Button HomeButton;
    }
}

