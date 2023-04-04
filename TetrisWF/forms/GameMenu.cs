using AS_Coursework.forms.game;
using AS_Coursework.@internal;
using AS_Coursework.io;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework.forms
{

    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
            SessionManager.MainMenuForm = this;
        }

        private void Splash_VisibilityChange(object sender, EventArgs e)
        {
            var CurrentPlayer = SessionManager.CurrentPlayer;
            if (CurrentPlayer != null)
            {
                lbl_currentPlayer.Text = CurrentPlayer.Username;
                if (CurrentPlayer.Avatar != null)
                    pic_PlayerAvatar.Image = DataManager.Avatars[SessionManager.CurrentPlayer!.Avatar];
            }
            else
            {
                lbl_currentPlayer.Text = "Guest";
            }

            if (CurrentPlayer.IsGuest)
            {
                btn_OpenStatisticsForm.Text = "🚫";
                btn_OpenStatisticsForm.ForeColor = Color.IndianRed;
            }
            else
            {
                btn_OpenStatisticsForm.Text = "📊";
                btn_OpenStatisticsForm.ForeColor = Color.Black;
            }

            if (CurrentPlayer.PreviousGameState == null) btn_ContinueGame.BackColor = Color.Gray;
            else btn_ContinueGame.BackColor = Color.Gold;
        }

        private void btn_ExitProgram_Click(object sender, EventArgs e)
        {
            DataManager.PlaySoundEffect("caution");
            var quit = MessageBox.Show("Are you sure you want to quit?", "Blocks · Confirmation Dialouge",
                MessageBoxButtons.YesNo);
            if (quit == DialogResult.Yes)
            {
                DataManager.PlaySoundEffect("ok");
                Environment.Exit(0);
            }
            else DataManager.PlaySoundEffect("cancel");
        }

        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            if (SessionManager.CurrentPlayer.PreviousGameState != null)
            {
                DataManager.PlaySoundEffect("alert");
                var response = MessageBox.Show(
                    "Starting a new game will overwrite your existing one," +
                    "\nare you sure you want to start a new game?",
                    "Blocks · Notifcation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (response.Equals(DialogResult.Yes))
                {
                    DataManager.PlaySoundEffect("ok");
                    SessionManager.CurrentPlayer.ClearGameState();
                    new GameWindow().Show();
                    Hide();
                }
                else
                {
                    DataManager.PlaySoundEffect("cancel");
                }
            }
            else
            {
                new GameWindow().Show();
                Hide();
            }

        }

        private void btn_ContinueGame_Click(object sender, EventArgs e)
        {
            if (SessionManager.CurrentPlayer.PreviousGameState != null)
            {
                DataManager.PlaySoundEffect("select");
                new GameWindow(SessionManager.CurrentPlayer.PreviousGameState).Show();
                Hide();
            }
            else
            {
                DataManager.PlaySoundEffect("alert");
                MessageBox.Show("You don't have a saved game to continue.",
                    "Blocks · Notifcation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                DataManager.PlaySoundEffect("cancel");
            }

        }

        private void btn_ChangeUser_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("you found secret :)");
        }

        private void btn_OpenStatisticsForm_Click(object sender, EventArgs e)
        {
            if (SessionManager.CurrentPlayer.IsGuest) return;
            DataManager.PlaySoundEffect("select");
            new ProfilePane().Show();
            Hide();
        }

        private void btn_OpenLeaderboardForm_Click(object sender, EventArgs e)
        {
            DataManager.PlaySoundEffect("select");
            new Leaderboard().Show();
            Hide();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            DataManager.PlaySoundEffect("select");
            new HelpPane().Show();
            Hide();
        }

        private void GameMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataManager.PlaySoundEffect("select");
            SessionManager.SplashForm?.Show();
        }
    }
}