using AS_Coursework.forms;
using AS_Coursework.game;
using AS_Coursework.@internal;
using AS_Coursework.io;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework;

public partial class MainMenu : Form
{
    public MainMenu()
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
        else lbl_currentPlayer.Text = "Guest";
        if (CurrentPlayer.PreviousGameState == null) btn_ContinueGame.BackColor = Color.Gray;
        else btn_ContinueGame.BackColor = Color.Gold;
    }

    private void btn_ExitProgram_Click(object sender, EventArgs e)
    {
        var quit = MessageBox.Show("Are you sure you want to quit?", "Blocks · Confirmation Dialouge",
            MessageBoxButtons.YesNo);
        if (quit == DialogResult.Yes) Environment.Exit(0);
    }

    private void btn_StartGame_Click(object sender, EventArgs e)
    {
        if (SessionManager.CurrentPlayer.PreviousGameState != null)
        {
            DialogResult response = MessageBox.Show("Starting a new game will overwrite your existing one,\nare you sure you want to start a new game?",
                "Blocks · Notifcation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (response.Equals(DialogResult.Yes))
            {
                SessionManager.CurrentPlayer.PreviousGameState = null;
                new GameWindow().Show();
                Hide();
            }
            else
            {
                return;
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
            new GameWindow(SessionManager.CurrentPlayer.PreviousGameState).Show();
            Hide();
        }
        else
        {
            MessageBox.Show("You don't have a saved game to continue.",
                "Blocks · Notifcation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    private void CurrentUser_DoubleClick(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
            try
            {
                var selected = Image.FromFile(openFileDialog1.FileName);
                pic_PlayerAvatar.Image = new Bitmap(selected);
            }
            catch
            {
                // ignored
            }
    }

    private void btn_ChangeUser_Click(object sender, EventArgs e)
    {
        SessionManager.SplashForm?.Show();
        Close();
    }

    private void pictureBox2_DoubleClick(object sender, EventArgs e)
    {
        MessageBox.Show("you found secret :)");
    }

    private void btn_OpenStatisticsForm_Click(object sender, EventArgs e)
    {
        new Profile().Show();
        Hide();
    }

    private void btn_OpenSettingsPane_Click(object sender, EventArgs e)
    {
        new SettingsPane().Show();
        Hide();
    }

    private void btn_OpenLeaderboardForm_Click(object sender, EventArgs e)
    {
        new Scoreboard().Show();
        Hide();
    }
}