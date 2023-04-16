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
            var sortedPlayerArray = new List<Player>(GameIOManager.GetPlayers());
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

        /// <summary>
        ///     This function returns a label control from a specified position on a scoreboard table layout panel.
        /// </summary>
        /// <param name="x">The column index of the control in the TableLayoutPanel.</param>
        /// <param name="y">The y parameter represents the vertical position of the control in the
        /// TableLayoutPanel. It is used to locate a control in the specified row.</param>
        /// <returns>
        /// The method is returning a Label object or null if there is no control at the specified coordinates.
        /// </returns>
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