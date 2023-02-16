using AS_Coursework.@internal;
using AS_Coursework.io;
using AS_Coursework.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_Coursework
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            lbl_usernameError.Text = "";
            lbl_passwordError.Text = "";
        }

        private void loginUser_onClick(object sender, EventArgs e)
        {
            bool valid = false;
            Player? loggedInPlayer = null;
            for (int i = 0; i < DataManager.getPlayers().Count; i++)
            {
                if (DataManager.getPlayers()[i].Username == txt_username.Text && DataManager.getPlayers()[i].Password == DataManager.getHashString(txt_password.Text))
                {
                    valid = true;
                    loggedInPlayer = DataManager.getPlayers()[i];
                }
                SessionManager.CurrentPlayer = loggedInPlayer;
            }
            if (valid && !loggedInPlayer.Equals(null))
            {
                MessageBox.Show("Welcome Back, " + loggedInPlayer.Username + "!\nYou are now logged in.", "Login Success", MessageBoxButtons.OK);
                new MainMenu(this).Show();
                this.Hide();
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
            DataManager.FinishUp();
            Environment.Exit(0);
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Form registerForm = new Registration(this);
            registerForm.Show();
            this.Hide();
        }

        private void btn_Guest_Click(object sender, EventArgs e)
        {
            DialogResult playAsGuest = MessageBox.Show("Are you sure you want to play as a Guest?\nThe ability to save your game and publish your score will be disabled.", "Blocks · Confirmation Dialouge", MessageBoxButtons.YesNo);
            if (playAsGuest == DialogResult.Yes)
            {
                SessionManager.CurrentPlayer = new Player()
                {
                    Username = "Guest",
                    IsGuest = true,
                };
                new MainMenu(this).Show();
                this.Hide();
            }
        }
    }
}
