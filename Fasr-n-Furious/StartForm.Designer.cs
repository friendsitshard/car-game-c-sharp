using System.Drawing;

namespace Fasr_n_Furious
{
    partial class StartForm
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
            this.PlayButton = new System.Windows.Forms.Button();
            this.LeaderboardButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayButton.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(122, 62);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(240, 80);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "PLAY";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            this.PlayButton.MouseEnter += new System.EventHandler(this.PlayButton_MouseEnter);
            this.PlayButton.MouseLeave += new System.EventHandler(this.PlayButton_MouseLeave);
            // 
            // LeaderboardButton
            // 
            this.LeaderboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeaderboardButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LeaderboardButton.FlatAppearance.BorderSize = 0;
            this.LeaderboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LeaderboardButton.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderboardButton.Location = new System.Drawing.Point(122, 152);
            this.LeaderboardButton.Name = "LeaderboardButton";
            this.LeaderboardButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LeaderboardButton.Size = new System.Drawing.Size(240, 80);
            this.LeaderboardButton.TabIndex = 1;
            this.LeaderboardButton.Text = "LEADERBOARD";
            this.LeaderboardButton.UseVisualStyleBackColor = false;
            this.LeaderboardButton.Click += new System.EventHandler(this.LeaderboardButton_Click);
            this.LeaderboardButton.MouseEnter += new System.EventHandler(this.LeaderboardButton_MouseEnter);
            this.LeaderboardButton.MouseLeave += new System.EventHandler(this.LeaderboardButton_MouseLeave);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(122, 243);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(240, 80);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "SIGN IN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            this.LoginButton.MouseEnter += new System.EventHandler(this.LoginButton_MouseEnter);
            this.LoginButton.MouseLeave += new System.EventHandler(this.LoginButton_MouseLeave);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegisterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.Location = new System.Drawing.Point(139, 329);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(209, 18);
            this.RegisterLabel.TabIndex = 2;
            this.RegisterLabel.Text = "Haven\'t account? Register!";
            this.RegisterLabel.Click += new System.EventHandler(this.RegisterLabel_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fasr_n_Furious.Properties.Resources.start_form_bg;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LeaderboardButton);
            this.Controls.Add(this.PlayButton);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast-n-Furious";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button LeaderboardButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label RegisterLabel;
    }
}