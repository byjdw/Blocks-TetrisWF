using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AS_Coursework.@internal;
using AS_Coursework.forms;
using AS_Coursework.models;
using AS_Coursework.io;

namespace AS_Coursework.forms
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
            var sortedPlayerArray = new List<Player>(DataManager.GetPlayers());
            sortedPlayerArray.Sort((b, a) => a.HighScore.CompareTo(b.HighScore));
            var names = new List<string>();
            foreach (var player in sortedPlayerArray) names.Add($"{player.Username} - {player.HighScore}");
            var HighScores = new List<string>();
            for (var i = 0; i < 8; i++)
                try
                {
                    HighScores.Add($"{i + 1}. {sortedPlayerArray[i].Username} - {sortedPlayerArray[i].HighScore}");
                }
                catch (ArgumentOutOfRangeException)
                {
                    HighScores.Add($"{i + 1}. N/A");
                }

            lbl_HighScore1.Text = HighScores[0];
            lbl_HighScore2.Text = HighScores[1];
            lbl_HighScore3.Text = HighScores[2];
            HighScores.RemoveRange(0, 3);
            lbl_HighScoreGeneric.Text = string.Join("\n", HighScores.ToArray());
        }

        private void btn_ExitProgram_Click(object sender, EventArgs e)
        {
            Close();
            SessionManager.MainMenuForm.Show();
        }
    }
}