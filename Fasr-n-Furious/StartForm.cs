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

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PLayButton_Click(object sender, EventArgs e)
        {
            Hide();
            GameForm gameForm = new GameForm();
            gameForm.Show();
        }
    }
}
