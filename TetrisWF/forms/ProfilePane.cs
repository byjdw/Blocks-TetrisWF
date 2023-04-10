using AS_Coursework.@internal;
using AS_Coursework.io;
using AS_Coursework.io.audio;
using System;
using System.Windows.Forms;

namespace AS_Coursework.forms
{

    public partial class ProfilePane : Form
    {
        public ProfilePane()
        {
            InitializeComponent();
            var player = SessionManager.CurrentPlayer;
            pic_PlayerAvatar.Image = GameIOManager.Avatars[player.Avatar];
            lbl_name.Text = player.Forename + " " + player.Surname;
            lbl_username.Text = player.Username;
            string statistics = "";
            statistics += player.HighScore.ToString() + "\n";
            statistics += player.AllScore.ToString() + "\n";
            statistics += player.PersonalRecords.ToString() + "\n";
            statistics += player.BlocksPlaced.ToString() + "\n";
            statistics += player.Games.ToString() + "\n";
            statistics += player.ClearedLines;
            lbl_Statistics.Text = statistics;
        }

        private void ExitButton_OnClick(object sender, EventArgs e)
        {

            Close();
        }

        private void Form_OnClosing(object sender, FormClosingEventArgs e)
        {
            AudioController.PlaySoundEffect("cancel");
            SessionManager.MainMenuForm.Show();
        }
    }
}