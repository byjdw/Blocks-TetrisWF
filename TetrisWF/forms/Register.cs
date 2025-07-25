﻿using AS_Coursework.exceptions;
using AS_Coursework.@internal;
using AS_Coursework.io;
using AS_Coursework.io.audio;
using AS_Coursework.models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AS_Coursework.forms
{

    public partial class Register : Form
    {
        // Validation
        private bool ValidForename;
        private bool ValidSurname;
        private bool ValidUsername;
        private bool ValidPassword;
        private bool ValidPasswordConfirm;

        // Player Data
        private int AvatarIndex;
        private Player NewPlayer;

        public Register()
        {
            InitializeComponent();
            NewPlayer = new Player();
            AvatarIndex = new Random().Next(0, 6);
            pic_playerAvatar.Image = GameIOManager.Avatars[AvatarIndex];
            ValidForename = false;
            ValidSurname = false;
            ValidUsername = false;
            ValidPassword = false;
            ValidPasswordConfirm = false;
            ClearErrMsgs();
        }

        public void ClearErrMsgs()
        {
            // clears error label placeholder text
            lbl_forenameError.Text = "";
            lbl_surnameError.Text = "";
            lbl_usernameError.Text = "";
            lbl_passwordError.Text = "";
            lbl_passwordConfirmError.Text = "";
        }

        private void RegisterPlayerButton_OnClick(object sender, EventArgs e)
        {
            bool valid = true;
            if (!ValidForename) valid = false;
            if (!ValidSurname) valid = false;
            if (!ValidUsername) valid = false;
            if (!ValidPassword) valid = false;
            if (!ValidPasswordConfirm) valid = false;
            if (valid)
                try
                {
                    NewPlayer.Avatar = AvatarIndex;
                    AudioController.PlaySoundEffect("dialog");
                    GameIOManager.AddPlayer(NewPlayer);
                    MessageBox.Show("Welcome, " + NewPlayer.Username + "!" +
                                    "\nYou may now login." +
                                    "\nHave fun!", "Blocks · Account Registered");
                    AudioController.PlaySoundEffect("ok");
                    SessionManager.SplashForm!.Show();
                    Close();
                }
                catch (InvalidPlayerException ipe)
                {
                    AudioController.PlaySoundEffect("caution");
                    MessageBox.Show(ipe.Message, "Blocks · Registration Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
                    txt_username.Text = "";
                }
            else
            {
                AudioController.PlaySoundEffect("caution");
                MessageBox.Show(
                    "There was a problem registering your account, please review and correct the errors presented.",
                    "Registration Error"
                    );
            }
        }

        private void Forename_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                NewPlayer.Forename = txt_forename.Text;
                lbl_forenameError.Text = "";
                ValidForename = true;
            }
            catch (InvalidPlayerException ipe)
            {

                lbl_forenameError.Text = ipe.Message;
                ValidForename = false;
            }
        }

        private void Surname_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                NewPlayer.Surname = txt_surname.Text;
                lbl_surnameError.Text = "";
                ValidSurname = true;
            }
            catch (InvalidPlayerException ipe)
            {
                lbl_surnameError.Text = ipe.Message;
                ValidSurname = false;
            }
        }

        private void Username_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                NewPlayer.Username = txt_username.Text;
                lbl_usernameError.Text = "";
                ValidUsername = true;
            }
            catch (InvalidPlayerException ipe)
            {
                lbl_usernameError.Text = ipe.Message;
                ValidUsername = false;
           }
        }

        private void Password_ValueChanged(object sender, EventArgs e)
        {
            if (txt_password.Text.Length < 8)
            {
                lbl_passwordError.Text = "Must be >8 chars long.";
                ValidPassword = false;
            }
            else
            {
                NewPlayer.Password = GameIOManager.GetHashString(txt_password.Text);
                lbl_passwordError.Text = "";
                ValidPassword = true;
            }
        }

        private void PasswordConfirm_ValueChanged(object sender, EventArgs e)
        {
            if (txt_password.Text != txt_passwordConfirm.Text)
            {
                lbl_passwordConfirmError.Text = "Your passwords do not match!";
                ValidPasswordConfirm = false;
            }
            else
            {
                lbl_passwordConfirmError.Text = "";
                ValidPasswordConfirm = true;
            }
        }

        private void CycleAvatarBackwardsButton_OnClick(object sender, EventArgs e)
        {
            AudioController.PlaySoundEffect("rotate");
            if (AvatarIndex != 0) AvatarIndex -= 1;
            else AvatarIndex = 6;
            if (AvatarIndex <= 6) pic_playerAvatar.Image = GameIOManager.Avatars[AvatarIndex];
        }

        private void CycleAvatarForwardButton_OnClick(object sender, EventArgs e)
        {
            AudioController.PlaySoundEffect("rotate");
            if (AvatarIndex != 6) AvatarIndex += 1;
            else AvatarIndex = 0;
            if (AvatarIndex <= 6) pic_playerAvatar.Image = GameIOManager.Avatars[AvatarIndex];
        }

        private void ExitButton_OnClick(object sender, EventArgs e)
        {
            Close();
            AudioController.PlaySoundEffect("cancel");
        }

        private void Form_OnClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.SplashForm!.Show();
        }
    }
}