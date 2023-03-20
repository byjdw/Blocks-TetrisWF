using AS_Coursework.enums;
using AS_Coursework.@internal;
using AS_Coursework.models;
using AS_Coursework.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace AS_Coursework.game;

public partial class GameWindow : Form
{
    bool halt = false;
    private Block? currentBlock;
    private readonly int gameInterval;
    private SoundPlayer soundPlayer;
    private int exitTicks = 0;

    List<Image> tileArray = new List<System.Drawing.Image>
        {
            Resources.Board_Square,
            Resources.Board_Line,
            Resources.Board_T,
            Resources.Board_Z,
            Resources.Board_S,
            Resources.Board_L,
            Resources.Board_Reverse_L,
        };

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
        for (int c = 0; c < tlp_pauseIndicator.ColumnCount * tlp_pauseIndicator.RowCount; c++)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Resources.Empty;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Margin = new Padding(0);
            tlp_pauseIndicator.Controls.Add(pictureBox);
        }
        this.session = new GameSession(this);
        soundPlayer = new SoundPlayer();
        lbl_currentPlayer.Text = SessionManager.CurrentPlayer!.Username;
        pic_userAvatar.Image = profilePictures[SessionManager.CurrentPlayer!.Avatar];
        gameInterval = GameTimer.Interval;
    }

    public GameWindow(GameState gameState)
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
        for (int c = 0; c < tlp_pauseIndicator.ColumnCount * tlp_pauseIndicator.RowCount; c++)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Resources.Empty;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Margin = new Padding(0);
            tlp_pauseIndicator.Controls.Add(pictureBox);
        }
        this.session = new GameSession(this, gameState);
        soundPlayer = new SoundPlayer();
        lbl_currentPlayer.Text = SessionManager.CurrentPlayer!.Username;
        pic_userAvatar.Image = profilePictures[SessionManager.CurrentPlayer!.Avatar];
        gameInterval = GameTimer.Interval;
        ForceRender(TilesFromString(gameState.Tiles), gameState.Tags);
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
        session.Tick();
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
                session.AdjustX(-1);
                break;
            case Keys.Right:
                Console.WriteLine("Right Key -> x+1");
                session.AdjustX(1);
                break;
            case Keys.Down:
                GameTimer.Interval = 50;
                break;
            case Keys.Space:
                GameTimer.Interval = 1;
                break;
            case Keys.C:
                session.Hold();
                UpdateHud();
                break;
            case Keys.Escape:
                if (!ExitTimer.Enabled)
                    ExitTimer.Start();
                break;
        }
    }

    private void GameWindow_KeyUp(object sender, KeyEventArgs e)
    {
        if (session.CurrentBlock == null) return;
        switch (e.KeyCode)
        {
            case Keys.Up:
                if (!GameTimer.Enabled) return;
                session.Rotate();
                break;
            case Keys.Down:
                if (!GameTimer.Enabled) return;
                GameTimer.Interval = gameInterval;
                break;
            case Keys.Q:
                if (!GameTimer.Enabled) return;
                RemoveRow(boardHeight - 1);
                break;
            case Keys.Escape:
                ExitTimer.Stop();
                GameTimer.Start();
                tlp_pauseIndicator.Visible = false;
                lbl_exitText1.Visible = false;
                lbl_exitText2.Visible = false;
                lbl_exitText3.Visible = false;
                lbl_exitText4.Visible = false;
                for (int i = 0; i < (boardWidth * boardHeight); i++)
                {
                    (tlp_pauseIndicator.Controls[i] as PictureBox).Image = Resources.Empty;
                }
                exitTicks = 0;
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
            tags.Add((string)tile.Tag);
        }
        for (int i = 0; i < tlp_GameBoard.Controls.Count; i++)
        {
                if (tags[i] != "Empty")
                    Console.Write("[" + tags[i] + "]");
                else
                    Console.Write("[E]");
            if (((tlp_GameBoard.Controls.Count + 1) / boardWidth) == boardHeight)
            {
                Console.Write("\n");
            }
        }
        tiles.RemoveRange((tlp_GameBoard.Controls.Count) - (boardWidth * (boardHeight - row)), boardWidth);
        tags.RemoveRange((tlp_GameBoard.Controls.Count) - (boardWidth * (boardHeight - row)), boardWidth);
        for (int i = 0; i < boardWidth; i++)
        {
            tiles.Insert(0, Resources.Empty);
            tags.Insert(0, "Empty");
        }
        ForceRender(tiles, tags);
    }

    public List<String> TilesToString(List<Image> tilesimg)
    {
        List<String> tiles = new List<String>();
        foreach (Image tile in tilesimg)
        {
            if (tile.Tag != "Empty")
            {
                tiles.Add(tile.Tag.ToString());
            }
            else
            {
                tiles.Add("Empty");
            }
        }

        return tiles;
    }

    public List<Image> TilesFromString(List<String> tilesstr)
    {
        List<Image> tiles = new List<Image>();
        foreach (String tile in tilesstr)
        {
            if (tile != "Empty")
            {
                Image newTile = tileArray[(int) Enum.Parse(typeof(BlockType), tile)];
                newTile.Tag = tile;
                tiles.Add(newTile);
            }
            else
            {
                tiles.Add(Resources.Empty);
            }
        }

        return tiles;
    }


    public List<Image> Tiles
    {
        get
        {
            List<Image> tiles = new List<Image>();
            foreach (PictureBox tile in tlp_GameBoard.Controls)
            {
                Image image = tile.Image;
                if (Convert.ToString(tile.Tag).Equals("Empty")) image.Tag = "Empty";
                tiles.Add(image);
            }
            return tiles;
        }
    }

    public List<String> Tags
    {
        get
        {
            List<String> tags = new List<String>();
            foreach (PictureBox tile in tlp_GameBoard.Controls)
            {
                tags.Add((string)tile.Tag);
            }
            return tags;
        }
    }

    public void ForceRender(List<Image> tiles, List<String> tags)
    {
        for (int i = 0; i < tlp_GameBoard.Controls.Count; i++)
        {
            (tlp_GameBoard.Controls[i] as PictureBox).Image = tiles[i];
            tlp_GameBoard.Controls[i].Tag = tags[i];
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
                if (Convert.ToString(GetTileFromCoordinates(j, i).Tag).Equals("Empty")) full = false;
            }
            if (full)
            {
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
        session.GameOver();
        new GameEnd(session).Show();
        soundPlayer.Stop();
        this.Close();
    }

    private void UpdateHud()
    {
        if (session.HeldBlock != null)
        {
            PictureBox hudImg = pic_hold;
            int index = (int)session.HeldBlock.Type;
            Image previewImg = preview[index];
            hudImg.Image = previewImg;
        }
        pic_nextUp1.Image = preview[((int)session.BlockQueue[0].Type)];
        pic_nextUp2.Image = preview[((int)session.BlockQueue[1].Type)];
        pic_nextUp3.Image = preview[((int)session.BlockQueue[2].Type)];
        pic_nextUp4.Image = preview[((int)session.BlockQueue[3].Type)];
        lbl_GameScore.Text = session.Score.ToString();
    }

    private void GameWindow_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    private void ExitTimer_Tick(object sender, EventArgs e)
    {
        if (exitTicks < boardHeight)
        {
            if (ExitTimer.Enabled)
            {
                GameTimer.Stop();
                exitTicks++;
                lbl_exitText1.Visible = true;
                lbl_exitText2.Visible = true;
                lbl_exitText3.Visible = true;
                lbl_exitText4.Visible = true;
                tlp_pauseIndicator.Visible = true;
                Console.WriteLine(exitTicks);
                int totalTiles = boardWidth * boardHeight;
                int startIndex = totalTiles - (boardWidth * exitTicks);
                for (int i = startIndex; i < totalTiles; i++)
                {
                    (tlp_pauseIndicator.Controls[i] as PictureBox).Image = Resources.Board_Reverse_L;
                }
            }
        }
        else
        {
            session.Save(TilesToString(Tiles), Tags);
        }
    }
}