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
    public partial class Login : Form
    {
        Form parentForm;
        public Login(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void Window_OnClose(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
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
                MessageBox.Show("You have logged in as:\n" + loggedInPlayer.Username, "Login Success");
                parentForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You have entered an invalid username/password combination.", "Login Error");
            }

            txt_username.Text = "";
            txt_password.Text = "";
        }
    }
}
