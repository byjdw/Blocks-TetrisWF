using AS_Coursework.@internal;
using AS_Coursework.io;
using AS_Coursework.io.audio;
using AS_Coursework.models;
using System;
using System.Windows.Forms;

namespace AS_Coursework.forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SessionManager.SplashForm = this;
        }

        private void LoginButton_OnClick(object sender, EventArgs e)
        {

            var valid = false;
            Player? loggedInPlayer = null;
            for (var i = 0; i < GameIOManager.GetPlayers().Count; i++)
                if (GameIOManager.GetPlayers()[i].Username == txt_username.Text && GameIOManager.GetPlayers()[i].Password ==
                    GameIOManager.GetHashString(txt_password.Text))
                {
                    valid = true;
                    loggedInPlayer = GameIOManager.GetPlayers()[i];
                }

            if (valid && !loggedInPlayer.Equals(null))
            {
                AudioController.PlaySoundEffect("dialog");
                MessageBox.Show("Welcome Back, " + loggedInPlayer.Username + "!\nYou are now logged in.",
                    "Login Success",
                    MessageBoxButtons.OK);
                SessionManager.CurrentPlayer = loggedInPlayer;
                AudioController.PlaySoundEffect("ok");
                new GameMenu().Show();
                Hide();
            }
            else
            {
                AudioController.PlaySoundEffect("caution");
                MessageBox.Show("You have entered an invalid username/password combination.", "Login Error");
            }

            txt_username.Text = "";
            txt_password.Text = "";
        }

        private void ExitButton_OnClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void RegisterButton_OnClick(object sender, EventArgs e)
        {
            AudioController.PlaySoundEffect("select");
            Form registerForm = new Register();
            registerForm.Show();
            Hide();
        }

        private void GuestButton_OnClick(object sender, EventArgs e)
        {
            AudioController.PlaySoundEffect("alert");
            var playAsGuest =
                MessageBox.Show(
                    "Are you sure you want to play as a Guest?\nThe ability to save your game and publish your score will be disabled.",
                    "Blocks · Confirmation Dialouge", MessageBoxButtons.YesNo);
            if (playAsGuest == DialogResult.Yes)
            {
                SessionManager.CurrentPlayer = new Player
                {
                    IsGuest = true,
                    Avatar = 7,
                    Username = "Guest",
                };
                AudioController.PlaySoundEffect("ok");
                new GameMenu().Show();
                Hide();
            }
            else
            {
                AudioController.PlaySoundEffect("cancel");
            }
        }

        private void Form_OnVisibilityChange(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
        }
    }
}