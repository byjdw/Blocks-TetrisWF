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

namespace AS_Coursework.forms
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            Player player = SessionManager.CurrentPlayer;
            pic_PlayerAvatar.Image = DataManager.Avatars[player.Avatar];
            lbl_name.Text = player.Forename + " " + player.Surname;
            lbl_username.Text = player.Username;
            lbl_HighScore.Text = player.HighScore.ToString();
            lbl_TotalScore.Text = player.AllScore.ToString();
            lbl_PRs.Text = player.PersonalRecords.ToString();
            lbl_BlocksPlaced.Text = player.BlocksPlaced.ToString();
            lbl_GamesPlayed.Text = player.Games.ToString();
            lbl_Moves.Text = player.Ticks.ToString();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
            SessionManager.MainMenuForm.Show();
        }
    }
}
