using AS_Coursework.@internal;
using AS_Coursework.io;
using AS_Coursework.models;
using AS_Coursework.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework
{
    public partial class Registration : Form
    {
        Form parentForm;
        List<System.Drawing.Image> profilePictures;
        int pfpIndex;

        public Registration(Form _parentForm)
        {
            parentForm = _parentForm;
            InitializeComponent();
            lbl_forenameError.Text = "";
            lbl_surnameError.Text = "";
            lbl_usernameError.Text = "";
            lbl_passwordError.Text = "";
            lbl_passwordConfirmError.Text = "";
            profilePictures = new List<System.Drawing.Image>()
            {
                Properties.Resources.Pfp_L,
                Properties.Resources.Pfp_line,
                Properties.Resources.Pfp_rL,
                Properties.Resources.Pfp_S,
                Properties.Resources.Pfp_Square,
                Properties.Resources.Pfp_T,
                Properties.Resources.Pfp_Z,
            };
            pfpIndex = new Random().Next(0, 6);
            pic_playerAvatar.Image = profilePictures[pfpIndex];
        }

        private void Window_OnClose(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }

        private void registerPlayer_onClick(object sender, EventArgs e)
        {
            bool valid = true;
            for (int i = 0; i < DataManager.getPlayers().Count; i++)
                if (DataManager.getPlayers()[i].Username == txt_username.Text)
                {
                    lbl_usernameError.Text = "Already in use.";
                    valid = false;
                }
            if (txt_username.Text.Length == 0)
            {
                lbl_usernameError.Text = "Cannot be empty.";
                valid = false;
            }
            if (txt_forename.Text.Length == 0)
            {
                lbl_forenameError.Text = "Cannot be empty.";
                valid = false;
            }
            if (txt_surname.Text.Length == 0)
            {
                lbl_surnameError.Text = "Cannot be empty.";
                valid = false;
            }
            if (txt_password.Text.Length < 8)
            {
                lbl_passwordError.Text = "Password must be >8 chars long.";
                valid = false;
            }
            if (txt_password.Text != txt_passwordConfirm.Text)
            {
                lbl_passwordConfirmError.Text = "Your passwords do not match!";
                valid = false;
            }
            if (valid)
            {
                Player newPlayer = new Player()
                {
                    Forename = txt_forename.Text,
                    Surname = txt_surname.Text,
                    Username = txt_username.Text,
                    Password = DataManager.getHashString(txt_password.Text),
                    Avatar = pic_playerAvatar.Image
                };
                DataManager.writePlayer(newPlayer);
                MessageBox.Show("Welcome, " + newPlayer.Username + "!" +
                    "\nYou may now login." +
                    "\nHave fun!", "Blocks · Account Registered");
                txt_forename.Text = "";
                txt_surname.Text = "";
                txt_username.Text = "";
                txt_password.Text = "";
                txt_passwordConfirm.Text = "";
                pic_playerAvatar.Image = Resources.Guest;
                parentForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("There was a problem registering your account, please review and correct the errors presented.", "Registration Error");
            }
        }

        private void Forename_ValueChanged(object sender, EventArgs e)
        {
            if (txt_forename.Text.Length == 0)
                lbl_forenameError.Text = "Cannot be empty.";
            else
                lbl_forenameError.Text = "";
        }

        private void Surname_ValueChanged(object sender, EventArgs e)
        {
            if (txt_surname.Text.Length == 0)
                lbl_surnameError.Text = "Cannot be empty.";
            else
                lbl_surnameError.Text = "";
        }

        private void Username_ValueChanged(object sender, EventArgs e)
        {
            bool alreadyExists = false;
            for (int i = 0; i < DataManager.getPlayers().Count; i++)
                if (DataManager.getPlayers()[i].Username == txt_username.Text)
                    alreadyExists = true;
            if (alreadyExists)
            {
                lbl_usernameError.Text = "Already in use.";
                return;
            } else if (txt_username.Text.Length == 0)
            {
                lbl_usernameError.Text = "Cannot be empty.";
                return;
            }
            lbl_usernameError.Text = "";
        }

        private void Password_ValueChanged(object sender, EventArgs e)
        {
            if (txt_password.Text.Length < 8)
                lbl_passwordError.Text = "Password must be >8 chars long.";
            else
                lbl_passwordError.Text = "";
        }

        private void PasswordConfirm_ValueChanged(object sender, EventArgs e)
        {
            if (txt_password.Text != txt_passwordConfirm.Text)
                lbl_passwordConfirmError.Text = "Your passwords do not match!";
            else
                lbl_passwordConfirmError.Text = "";
        }

        private void btn_pickImage_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.Drawing.Image selected = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                    pic_playerAvatar.Image = new Bitmap(selected);
                }
                catch
                {
                    // ignored
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_forename.Text = "Forename";
            txt_surname.Text = "Surname";
            txt_username.Text = "acc_" + new Random().Next(0, 10000);
            txt_password.Text = "12345678";
            txt_passwordConfirm.Text = "12345678";
        }

        private void btn_CycleAvatarBack_Click(object sender, EventArgs e)
        {
            if (pfpIndex != 0)
                pfpIndex -= 1;
            else
                pfpIndex = 6;
            pic_playerAvatar.Image = profilePictures[pfpIndex];
        }

        private void btn_CycleAvatarForward_Click(object sender, EventArgs e)
        {
            if (pfpIndex != 6)
                pfpIndex += 1;
            else
                pfpIndex = 0;
            pic_playerAvatar.Image = profilePictures[pfpIndex];
        }

        private void pic_playerAvatar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DataManager.FinishUp();
            Environment.Exit(0);
        }
    }
}
