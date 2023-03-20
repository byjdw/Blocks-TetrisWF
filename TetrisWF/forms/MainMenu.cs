using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AS_Coursework.game;
using AS_Coursework.@internal;
using AS_Coursework.io;
using AS_Coursework.Properties;

namespace AS_Coursework;

public partial class MainMenu : Form
{
    private readonly Form parentForm;

    private readonly List<Image> profilePictures = new()
    {
        Resources.Avatar_L,
        Resources.Avatar_Line,
        Resources.Avatar_Reverse_L,
        Resources.Avatar_S,
        Resources.Avatar_Square,
        Resources.Avatar_T,
        Resources.Avatar_Z,
        Resources.Guest
    };

    public MainMenu(Form parentForm)
    {
        InitializeComponent();
        this.parentForm = parentForm;
    }

    private void Splash_VisibilityChange(object sender, EventArgs e)
    {
        var CurrentPlayer = SessionManager.CurrentPlayer;
        if (CurrentPlayer != null)
        {
            lbl_currentPlayer.Text = CurrentPlayer.Username;
            if (CurrentPlayer.Avatar != null)
                pic_PlayerAvatar.Image = profilePictures[SessionManager.CurrentPlayer!.Avatar];
        }
        else
        {
            lbl_currentPlayer.Text = "Guest";
        }
    }

    private void btn_ExitProgram_Click(object sender, EventArgs e)
    {
        var quit = MessageBox.Show("Are you sure you want to quit?", "Blocks · Confirmation Dialouge",
            MessageBoxButtons.YesNo);
        if (quit == DialogResult.Yes) Close();
    }

    private void btn_StartGame_Click(object sender, EventArgs e)
    {
        new GameWindow().Show();
        Close();
    }

    private void btn_ContinueGame_Click(object sender, EventArgs e)
    {
        if (SessionManager.CurrentPlayer.PreviousGameState != null)
        {
            new GameWindow(SessionManager.CurrentPlayer.PreviousGameState).Show();
            Close();
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

    private void btn_Exit_Click(object sender, EventArgs e)
    {
        DataManager.FinishUp();
        Environment.Exit(0);
    }

    private void btn_ChangeUser_Click(object sender, EventArgs e)
    {
        parentForm.Show();
        Close();
    }

    private void pictureBox2_DoubleClick(object sender, EventArgs e)
    {
        MessageBox.Show("you found secret :)");
    }
}