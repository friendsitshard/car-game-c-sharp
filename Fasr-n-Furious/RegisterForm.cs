using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fasr_n_Furious
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HomeLabel_Click(object sender, EventArgs e)
        {
            Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        #region unhide password
        private void PasswordPictureBox_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.PasswordChar == '*')
            {
                PasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
            }
        }
        private void RepasswordPictureBox_Click(object sender, EventArgs e)
        {
            if (RepasswordTextBox.PasswordChar == '*')
            {
                RepasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                RepasswordTextBox.PasswordChar = '*';
            }
        }
        #endregion

        private void CreateButton_Click(object sender, EventArgs e)
        {
            using (CarsEntities cars = new CarsEntities())
            {
                string username = UsernameTextBox.Text;
                string email = EmailTextBox.Text;
                string password = PasswordTextBox.Text;
                int role_id = 2;

                if (string.IsNullOrEmpty(UsernameTextBox.Text))
                {
                    MessageBox.Show("Username is required", "Empty field", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(EmailTextBox.Text))
                {
                    MessageBox.Show("Email is required", "Empty field", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(PasswordTextBox.Text))
                {
                    MessageBox.Show("Password is required", "Empty field", MessageBoxButtons.OK);
                }
                else if (PasswordTextBox.Text != RepasswordTextBox.Text)
                {
                    MessageBox.Show("Password don't match", "Empty field", MessageBoxButtons.OK);
                }
                else
                {
                    cars.insert_users(username, email, password, role_id);
                    cars.SaveChanges();
                    Hide();
                    StartForm startForm = new StartForm();
                    startForm.Show();
                }
            }
        }

    }
}
