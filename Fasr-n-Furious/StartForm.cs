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
    public partial class StartForm : Form
    {

        public StartForm()
        {
            InitializeComponent();
        }

        #region StartForm buttons hover
        private void PlayButton_MouseEnter(object sender, EventArgs e)
        {
            PlayButton.ForeColor = Color.White;
            PlayButton.BackColor = Color.Green;
        }

        private void PlayButton_MouseLeave(object sender, EventArgs e)
        {
            PlayButton.ForeColor = Color.Black;
            PlayButton.BackColor = Color.FromArgb(200, 255, 255, 255);
        }

        private void LeaderboardButton_MouseEnter(object sender, EventArgs e)
        {
            LeaderboardButton.ForeColor = Color.White;
            LeaderboardButton.BackColor = Color.Yellow;
        }

        private void LeaderboardButton_MouseLeave(object sender, EventArgs e)
        {
            LeaderboardButton.ForeColor = Color.Black;
            LeaderboardButton.BackColor = Color.FromArgb(200, 255, 255, 255);
        }

        private void LoginButton_MouseEnter(object sender, EventArgs e)
        {
            LoginButton.ForeColor = Color.White;
            LoginButton.BackColor = Color.Red;
        }

        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.ForeColor = Color.Black;
            LoginButton.BackColor = Color.FromArgb(200, 255, 255, 255);
        }
        #endregion

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Hide();
            GameForm gameForm = new GameForm();
            gameForm.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }


        private void LeaderboardButton_Click(object sender, EventArgs e)
        {
            Hide();
            LeaderForm leaderForm = new LeaderForm();
            leaderForm.Show();
        }
        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
