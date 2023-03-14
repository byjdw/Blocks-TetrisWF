using AS_Coursework.@internal;
using AS_Coursework.models;
using AS_Coursework.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Numerics;
using System.Threading.Tasks;

namespace AS_Coursework.game;

public partial class GameWindow : Form
{
    bool halt = false;
    private Block? currentBlock;
    private readonly int gameInterval;
    private SoundPlayer soundPlayer;

    List<Image> profilePictures = new List<System.Drawing.Image>
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

private List<Image> preview = new List<Image>
    {
        Resources.Preview_Square,
        Resources.Preview_Line,
        Resources.Preview_T,
        Resources.Preview_Z,
        Resources.Preview_S,
        Resources.Preview_L,
        Resources.Preview_Reverse_L
    };

    private GameSession session;

    public int Interval { get => GameTimer.Interval; set => GameTimer.Interval = value; }
    public int boardWidth { get => tlp_GameBoard.ColumnCount; }
    public int boardHeight { get => tlp_GameBoard.RowCount; }
    public bool Tick { get => GameTimer.Enabled; }
    public bool Halt { get => halt; }

    public GameWindow()
    {
        InitializeComponent();
        lbl_dbgPlayerInfo.Text = $"SessionManager -> CurrentPlayer:\n{SessionManager.CurrentPlayer.ToString()}";
        for (int c = 0; c < tlp_GameBoard.ColumnCount * tlp_GameBoard.RowCount; c++)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Resources.Empty;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Margin = new Padding(0);
            pictureBox.Tag = "Empty";
            tlp_GameBoard.Controls.Add(pictureBox);
        }

        session = new GameSession(this);
        soundPlayer = new SoundPlayer();
        lbl_currentPlayer.Text = SessionManager.CurrentPlayer!.Username;
        pic_userAvatar.Image = profilePictures[SessionManager.CurrentPlayer!.Avatar];
        gameInterval = GameTimer.Interval;
    }

    private void startCutscene()
    {
    }

    private void pic_GameScreen_Click(object sender, EventArgs e)
    {
    }

    private void GameWindow_VisibilityChanged(object sender, EventArgs e)
    {
        if (!this.Visible) return;
        UpdateHud();
        soundPlayer.SoundLocation = "X:/Documents/TetrisWF/TetrisWF/Resources/background_sfx.wav";
       // soundPlayer.PlayLooping();
        GameTimer.Start();
    }

    private void GameWindow_Load(object sender, EventArgs e)
    {
    }

    private void GameTimer_Tick(object sender, EventArgs e)
    {
        if (halt) return;
        session.Tick(this);
        UpdateHud();
    }

    private void GameWindow_KeyDown(object sender, KeyEventArgs e)
    {
        if (session.CurrentBlock == null) return;
        if (!GameTimer.Enabled) return;
        switch (e.KeyCode)
        {
            case Keys.Left:
                Console.WriteLine("Left Key -> x-1");
                session.CurrentBlock.AdjustX(this, -1);
                break;
            case Keys.Right:
                Console.WriteLine("Right Key -> x+1");
                session.CurrentBlock.AdjustX(this, 1);
                break;
            case Keys.Down:
                GameTimer.Interval = 50;
                break;
            case Keys.Space:
                GameTimer.Interval = 1;
                break;
            case Keys.C:
                session.Hold(this);
                UpdateHud();
                break;
        }
    }

    private void GameWindow_KeyUp(object sender, KeyEventArgs e)
    {
        if (session.CurrentBlock == null) return;
        if (!GameTimer.Enabled) return;
        switch (e.KeyCode)
        {
            case Keys.Up:
                session.CurrentBlock.Rotate(this);
                break;
            case Keys.Down:
                GameTimer.Interval = gameInterval;
                break;
            case Keys.Q:
                RemoveRow(boardHeight-1);
                break;
        }
    }

    public PictureBox? GetTileFromCoordinates(int x, int y)
    {
        Control control;
        try
        {
            control = tlp_GameBoard.GetControlFromPosition(x, y);
        }
        catch
        {
            return null;
        }
        return (PictureBox)control;
    }

    public void RemoveRow(int row)
    {
        List<Image> tiles = new List<Image>();
        List<String> tags = new List<String>();
        foreach (PictureBox tile in tlp_GameBoard.Controls)
        {
            tiles.Add(tile.Image);
            tags.Add((string) tile.Tag);
        }
        tiles.RemoveRange((boardHeight * boardWidth) - (boardWidth * (boardHeight - row)), boardWidth);
        tags.RemoveRange((boardHeight * boardWidth) - (boardWidth * (boardHeight - row)), boardWidth);
        for (int i = 0; i < boardWidth; i++)
        {
            tiles.Insert(0, Resources.Empty);
            tags.Insert(0, "Empty");
        }
        for (int i = 0; i < boardWidth * boardHeight; i++)
        {
            (tlp_GameBoard.Controls[i] as PictureBox).Image = tiles[i];
            (tlp_GameBoard.Controls[i] as PictureBox).Tag = tags[i];
        }
    }

    public void CheckLines()
    {
        int lines = 0;
        for (int i = 0; i < boardHeight; i++)
        {
            bool full = true;
            for (int j = 0; j < boardWidth; j++)
            {
                if (GetTileFromCoordinates(j, i).Tag == "Empty") full = false;
            }
            if (full) {
                RemoveRow(i);
                lines += 1;
            }
        }
        session.AddScore(lines, 0);
        UpdateHud();
    }

    public void GameOver()
    {
        GameTimer.Stop();
        halt = true;
        currentBlock = null;
        for (int i = 0; i < boardHeight; i++)
        {
            for (int j = 0; j < boardWidth; j++)
            {
                GetTileFromCoordinates(j, i).Image = Properties.Resources.Board_Z;
            }
        }
        Task.Delay(3000);
        new GameEnd(session).Show();
        soundPlayer.Stop();
        this.Close();
    }

    private void UpdateHud()
    {
        if (session.HeldBlock != null) 
        {
            PictureBox hudImg = pic_hold;
            int index = (int) session.HeldBlock.Type;
            Image previewImg = preview[index];
            hudImg.Image = previewImg;
        }
        pic_nextUp1.Image = preview[((int)session.BlockQueue[0].Type)];
        pic_nextUp2.Image = preview[((int)session.BlockQueue[1].Type)];
        pic_nextUp3.Image = preview[((int)session.BlockQueue[2].Type)];
        pic_nextUp4.Image = preview[((int)session.BlockQueue[3].Type)];
        lbl_GameScore.Text = session.Score.ToString();
    }
}