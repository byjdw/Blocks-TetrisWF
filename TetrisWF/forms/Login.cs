using System;
using System.Windows.Forms;
using AS_Coursework.@internal;
using AS_Coursework.forms;
using AS_Coursework.models;
using AS_Coursework.io;

namespace AS_Coursework.forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SessionManager.SplashForm = this;
        }

        private void loginUser_onClick(object sender, EventArgs e)
        {
            var valid = false;
            Player? loggedInPlayer = null;
            for (var i = 0; i < DataManager.GetPlayers().Count; i++)
                if (DataManager.GetPlayers()[i].Username == txt_username.Text && DataManager.GetPlayers()[i].Password ==
                    DataManager.GetHashString(txt_password.Text))
                {
                    valid = true;
                    loggedInPlayer = DataManager.GetPlayers()[i];
                }

            if (valid && !loggedInPlayer.Equals(null))
            {
                MessageBox.Show("Welcome Back, " + loggedInPlayer.Username + "!\nYou are now logged in.",
                    "Login Success",
                    MessageBoxButtons.OK);
                SessionManager.CurrentPlayer = loggedInPlayer;
                new GameMenu().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("You have entered an invalid username/password combination.", "Login Error");
            }

            txt_username.Text = "";
            txt_password.Text = "";
        }

        private void btn_ExitProgram_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Form registerForm = new Register();
            registerForm.Show();
            Hide();
        }

        private void btn_Guest_Click(object sender, EventArgs e)
        {
            var playAsGuest =
                MessageBox.Show(
                    "Are you sure you want to play as a Guest?\nThe ability to save your game and publish your score will be disabled.",
                    "Blocks · Confirmation Dialouge", MessageBoxButtons.YesNo);
            if (playAsGuest == DialogResult.Yes)
            {
                SessionManager.CurrentPlayer = new Player
                {
                    Username = "Guest",
                    Avatar = 7,
                    IsGuest = true
                };
                new GameMenu().Show();
                Hide();
            }
        }

        private void Splash_VisibleChanged(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
        }
    }
}