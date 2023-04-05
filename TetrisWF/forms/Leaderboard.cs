using AS_Coursework.@internal;
using AS_Coursework.io;
using AS_Coursework.io.audio;
using AS_Coursework.models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AS_Coursework.forms
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
            var sortedPlayerArray = new List<Player>(IOManager.GetPlayers());
            sortedPlayerArray.Sort((b, a) => a.HighScore.CompareTo(b.HighScore));
            for (int i = 0; i < tlp_Scoreboard.RowCount - 1; i++)
            {
                Player player;
                try
                {
                    player = sortedPlayerArray[i];
                }
                catch
                {
                    player = new Player() { Username = "-----" };
                }
                Label PlayerLabel = GetLabelFromCoordinates(1, i + 1);
                PlayerLabel.Text = player.Username;
                Label ScoreLabel = GetLabelFromCoordinates(2, i + 1);
                if (player.HighScore == 0) ScoreLabel.Text = "-----";
                else ScoreLabel.Text = player.HighScore.ToString();
            }
        }

        public Label? GetLabelFromCoordinates(int x, int y)
        {
            Control control;
            try
            {
                control = tlp_Scoreboard.GetControlFromPosition(x, y);
            }
            catch
            {
                return null;
            }

            return (Label)control;
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