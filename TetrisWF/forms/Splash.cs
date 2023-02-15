using AS_Coursework.game;
using AS_Coursework.@internal;
using AS_Coursework.models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            DialogResult choice = MessageBox.Show("DEV MODE - SKIP TO GAMEPLAY?", "Blocks · Confirmation Dialouge", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                GameSession newGameSession = new GameSession();
                SessionManager.CurrentPlayer = new Player()
                {
                    Username = "Guest",
                    IsGuest = true,
                };
                SessionManager.CurrentPlayer.CurrentSession = newGameSession;
                new GameWindow().Show();
                this.Hide();
            }
        }

        private void btn_RegisterOnClick(object sender, EventArgs e)
        {
            Form registerForm = new Registration(this);
            registerForm.Show();
            this.Hide();
        }

        private void btn_LoginOnClick(object sender, EventArgs e)
        {
            Form loginForm = new Login(this);
            loginForm.Show();
            this.Hide();
        }

        private void Splash_VisibilityChange(object sender, EventArgs e)
        {
            Player? CurrentPlayer = SessionManager.CurrentPlayer;
            if (CurrentPlayer != null)
            {
                lbl_currentPlayer.Text = CurrentPlayer.Username;
                if (CurrentPlayer.Avatar != null)
                {
                    pictureBox1.Image = CurrentPlayer.Avatar;
                }
            }
            else
            {
                lbl_currentPlayer.Text = "Guest";

            }
        }

        private void btn_ExitProgram_Click(object sender, EventArgs e)
        {
            DialogResult quit = MessageBox.Show("Are you sure you want to quit?", "Blocks · Confirmation Dialouge", MessageBoxButtons.YesNo);
            if (quit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            GameSession newGameSession = new GameSession();
            if (SessionManager.CurrentPlayer == null)
            {
                DialogResult playAsGuest = MessageBox.Show("You aren't logged in, would you like to play as a Guest?", "Blocks · Confirmation Dialouge", MessageBoxButtons.YesNo);
                if (playAsGuest == DialogResult.Yes)
                {
                    SessionManager.CurrentPlayer = new Player()
                    {
                        Username = "Guest",
                        IsGuest = true,
                    };
                }
                else
                {
                    return;
                }
            }
            SessionManager.CurrentPlayer.CurrentSession = newGameSession;
            new GameWindow().Show();
            this.Hide();
        }

        private void btn_ContinueGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("shut up nerd");
        }

        private void CurrentUser_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.Drawing.Image selected = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = new Bitmap(selected);
                }
                catch
                {
                    // ignored
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}