using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fasr_n_Furious
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


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

        private void HomeLabel_Click(object sender, EventArgs e)
        {
            Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (CarsEntities cars = new CarsEntities())
            {
                var con = cars.Database.Connection;
                con.Open();

                string query = "select * from users where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand(query, (SqlConnection)con);
                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters["@username"].Value = UsernameTextBox.Text;
                cmd.Parameters["@password"].Value = PasswordTextBox.Text;

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (string.IsNullOrEmpty(UsernameTextBox.Text))
                {
                    MessageBox.Show("Username field is empty.", "Error message", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(PasswordTextBox.Text))
                {
                    MessageBox.Show("Password field is empty.", "Error message", MessageBoxButtons.OK);
                }
                else if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("This user doesn't exist.", "Error message", MessageBoxButtons.OK);
                }
                else
                {
                    if (Convert.ToInt32(dt.Rows[0]["role_id"]) == 1)
                    {
                        Hide();
                        int id = Convert.ToInt32(dt.Rows[0]["user_id"]);
                        AdminForm admin = new AdminForm(id);
                        admin.Show();
                    }
                    else if(Convert.ToInt32(dt.Rows[0]["role_id"]) == 2)
                    {
                        Hide();
                        int id = Convert.ToInt32(dt.Rows[0]["user_id"]);
                        GameForm game = new GameForm(id);
                        game.Show();
                    }
                }
            }
        }
    }
}
