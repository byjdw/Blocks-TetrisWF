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
            pic_PlayerAvatar.Image = IOManager.Avatars[player.Avatar];
            lbl_name.Text = player.Forename + " " + player.Surname;
            lbl_username.Text = player.Username;
            lbl_HighScore.Text = player.HighScore.ToString();
            lbl_TotalScore.Text = player.AllScore.ToString();
            lbl_PRs.Text = player.PersonalRecords.ToString();
            lbl_BlocksPlaced.Text = player.BlocksPlaced.ToString();
            lbl_GamesPlayed.Text = player.Games.ToString();
            lbl_Moves.Text = player.ClearedLines + " Lines";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void ProfilePane_FormClosing(object sender, FormClosingEventArgs e)
        {
            AudioController.PlaySoundEffect("cancel");
            SessionManager.MainMenuForm.Show();
        }
    }
}