using Fasr_n_Furious.CarsDataSetTableAdapters;
using Microsoft.Reporting.WinForms;
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
    public partial class LeaderForm : Form
    {
        public LeaderForm()
        {
            InitializeComponent();
        }

        private void LeaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HomeLabel_Click(object sender, EventArgs e)
        {
            Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void LeaderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carsDataSet.show_players_top_scores' table. You can move, or remove it, as needed.
            this.show_players_top_scoresTableAdapter.Fill(this.carsDataSet.show_players_top_scores);
            this.CarsReportViewer.RefreshReport();
        }
    }
}
