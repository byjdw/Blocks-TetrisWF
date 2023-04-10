using AS_Coursework.@internal;
using AS_Coursework.io.audio;
using AS_Coursework.models;
using AS_Coursework.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework.forms.game
{

    public partial class GameEnd : Form
    {
        private int exitTimer;

        public GameEnd(GameSession session, int hs)
        {
            InitializeComponent();

            lbl_score.Text = session.Score.ToString();

            bool newHighScore = session.Score > hs;
            Color color;

            if (!SessionManager.CurrentPlayer.IsGuest)
            {
                lbl_GameStatus.Text = newHighScore ? "Well Done!" : "That's too bad...";
                color = newHighScore ? Color.Green : Color.Crimson;

                if (newHighScore)
                {
                    lbl_Title.Text = "NEW HIGH SCORE";
                    lbl_HighScore.Text = $"Your new high score is - {session.Score}!";
                    pic_SideBar.BackgroundImage = Resources.Board_S; // green block
                    pic_SideBar.Image = Resources.sidebar_gameover_smile; // smile face
                    AudioController.PlaySoundEffect("win");
                }
                else
                {
                    lbl_HighScore.Text = $"Your current high score is - {hs}!";
                    pic_SideBar.BackgroundImage = Resources.Board_Z; // Red Block
                    pic_SideBar.Image = Resources.sidebar_gameover_frown; // frown face
                    AudioController.PlaySoundEffect("game_over");
                }
            }
            else
            {
                lbl_GameStatus.Text = "━━━━━";
                lbl_HighScore.Visible = false;
                color = Color.Gray;
                AudioController.PlaySoundEffect("game_over");
                lbl_HighScore.Visible = false;
            }

            lbl_SecondsRemaining.ForeColor = color;
            lbl_GameStatus.ForeColor = color;
            lbl_Title.ForeColor = color;
            btn_Skip.BackColor = color;

            ReturnTimer.Start();
            exitTimer = 0;
            lbl_SecondsRemaining.Text = "15 seconds...";
        }

        private void ReturnTimer_Tick(object sender, EventArgs e)
        {
            exitTimer++;
            if (exitTimer >= 15)
            {
                Close();
            }
            else
            {
                lbl_SecondsRemaining.Text = $"{15 - exitTimer} seconds...";
            }
        }

        private void SkipButton_OnClick(object sender, EventArgs e)
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