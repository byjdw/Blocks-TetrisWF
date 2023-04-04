using AS_Coursework.@internal;
using AS_Coursework.io;
using AS_Coursework.models;
using System;
using System.Windows.Forms;

namespace AS_Coursework.forms.game
{

    public partial class GameEnd : Form
    {
        private int exitTimer;
        private GameSession session;

        public GameEnd(GameSession session, int hs)
        {
            InitializeComponent();
            this.session = session;
            lbl_score.Text = session.Score.ToString();
            var hstxt = lbl_HighScore.Text;
            if (session.Score > hs)
            {
                lbl_GameStatus.Text = "Well Done!";
                hstxt = hstxt.Replace("{0}", "greater");
            }
            else
            {
                lbl_GameStatus.Text = "That's too bad...";
                hstxt = hstxt.Replace("{0}", "less");
            }

            hstxt = hstxt.Replace("{1}", hs.ToString());
            if (SessionManager.CurrentPlayer.IsGuest) hstxt = "";
            lbl_HighScore.Text = hstxt;
            ReturnToMenuTimer.Start();
            lbl_SecondsRemaining.Text = 15 + " seconds...";
        }

        private void ReturnToMenuTimer_Tick(object sender, EventArgs e)
        {
            exitTimer++;
            if (exitTimer == 16)
            {
                Close();
            }
            else if (exitTimer == 1) DataManager.PlaySoundEffect("gameover");

            lbl_SecondsRemaining.Text = (15 - exitTimer) + " seconds...";
        }

        private void btn_ExitProgram_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GameEnd_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataManager.PlaySoundEffect("cancel");
            SessionManager.MainMenuForm.Show();
        }
    }
}