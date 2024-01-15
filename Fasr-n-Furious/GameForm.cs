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
    public partial class GameForm : Form
    {
        Random rand = new Random();
        private bool isPaused = false;
        private int mapSpeed = 0;
        private int mapHeight = 650;
        private int points = 0;
        private int enemy1TopLocation = -150;
        private int enemy2TopLocation = -400;

        public GameForm()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //map and enemy cars movement speed
            MapPictureBox.Top += mapSpeed;
            MapPictureBox2.Top += mapSpeed;
            EnemyPictureBox.Top += mapSpeed;
            EnemyPictureBox2.Top += mapSpeed;

            //points
            points += mapSpeed;
            Points.Text = Convert.ToString(points);

            //acceleration at the beginning
            if (mapSpeed < 17) mapSpeed ++;

            //map movement
            if (MapPictureBox.Top >= mapHeight)
            {
                MapPictureBox.Top = 0;
                MapPictureBox2.Top = -mapHeight;
            }

            //setting enemy location randomly 
            if (EnemyPictureBox.Top >= mapHeight)
            {
                EnemyPictureBox.Top = enemy1TopLocation;
                EnemyPictureBox.Left = rand.Next(150, 300);
            }
            if (EnemyPictureBox2.Top >= mapHeight)
            {
                EnemyPictureBox2.Top = enemy2TopLocation;
                EnemyPictureBox2.Left = rand.Next(300, 560);
            }

            //stopping the game when lose
            if (CarPictureBox.Bounds.IntersectsWith(EnemyPictureBox.Bounds) || CarPictureBox.Bounds.IntersectsWith(EnemyPictureBox2.Bounds))
            {
                timer.Stop();
                LosePanel.Visible = true;
                CurrentPointsLabel.Text = Convert.ToString(points);   
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            int carSpeed = 25;

            //car controls
            if (!isPaused)
            {
                if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && CarPictureBox.Left >= 150)
                {
                    CarPictureBox.Left -= carSpeed;
                }
                else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && CarPictureBox.Right <= 695)
                {
                    CarPictureBox.Left += carSpeed;
                }
                else if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && CarPictureBox.Top <= 560)
                {
                    CarPictureBox.Top += carSpeed;
                }
                else if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && CarPictureBox.Top >= 20)
                {
                    CarPictureBox.Top -= carSpeed;
                }
            }

            //keys for close, pause, resume
            if (e.KeyCode == Keys.P)
            {
                timer.Stop();
                isPaused = true;
            }
            else if (e.KeyCode == Keys.R && !(CarPictureBox.Bounds.IntersectsWith(EnemyPictureBox.Bounds) || CarPictureBox.Bounds.IntersectsWith(EnemyPictureBox2.Bounds)))
            {
                timer.Start();
                isPaused = false;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Hide();
                StartForm startForm = new StartForm();
                startForm.Show();
            }
        }

        //restart game
        private void RestartButton_Click(object sender, EventArgs e)
        {
            EnemyPictureBox.Top = enemy1TopLocation;
            EnemyPictureBox2.Top = enemy2TopLocation;
            CarPictureBox.Top = mapHeight - CarPictureBox.Height;
            CarPictureBox.Left = MapPictureBox.Width / 2;
            points = 0;
            mapSpeed = 5;
            LosePanel.Visible = false;
            timer.Start();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
