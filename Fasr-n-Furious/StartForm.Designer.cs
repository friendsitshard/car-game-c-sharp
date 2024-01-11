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
            this.PLayButton = new System.Windows.Forms.Button();
            this.LeaderbordButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PLayButton
            // 
            this.PLayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PLayButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PLayButton.FlatAppearance.BorderSize = 0;
            this.PLayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PLayButton.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLayButton.Location = new System.Drawing.Point(122, 62);
            this.PLayButton.Name = "PLayButton";
            this.PLayButton.Size = new System.Drawing.Size(240, 80);
            this.PLayButton.TabIndex = 0;
            this.PLayButton.Text = "PLAY";
            this.PLayButton.UseVisualStyleBackColor = false;
            this.PLayButton.Click += new System.EventHandler(this.PLayButton_Click);
            // 
            // LeaderbordButton
            // 
            this.LeaderbordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeaderbordButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LeaderbordButton.FlatAppearance.BorderSize = 0;
            this.LeaderbordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LeaderbordButton.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderbordButton.Location = new System.Drawing.Point(122, 152);
            this.LeaderbordButton.Name = "LeaderbordButton";
            this.LeaderbordButton.Size = new System.Drawing.Size(240, 80);
            this.LeaderbordButton.TabIndex = 1;
            this.LeaderbordButton.Text = "LEADERBORD";
            this.LeaderbordButton.UseVisualStyleBackColor = false;
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
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegisterLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RegisterLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.Location = new System.Drawing.Point(139, 329);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(209, 18);
            this.RegisterLabel.TabIndex = 2;
            this.RegisterLabel.Text = "Haven\'t account? Register!";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fasr_n_Furious.Properties.Resources.start_form_bg;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LeaderbordButton);
            this.Controls.Add(this.PLayButton);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast-n-Furious";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PLayButton;
        private System.Windows.Forms.Button LeaderbordButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label RegisterLabel;
    }
}