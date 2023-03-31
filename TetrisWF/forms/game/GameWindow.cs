using AS_Coursework.enums;
using AS_Coursework.@internal;
using AS_Coursework.io;
using AS_Coursework.models;
using AS_Coursework.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace AS_Coursework.forms.game
{

    public partial class GameWindow : Form
    {
        private readonly int gameInterval;

        private readonly GameSession session;
        private readonly SoundPlayer soundPlayer;


        private Block? currentBlock;
        private int exitTicks;

        public GameWindow()
        {
            InitializeComponent();
            lbl_dbgPlayerInfo.Text = $"SessionManager -> CurrentPlayer:\n{SessionManager.CurrentPlayer}";
            for (var c = 0; c < tlp_GameBoard.ColumnCount * tlp_GameBoard.RowCount; c++)
            {
                var pictureBox = new PictureBox();
                pictureBox.Image = Resources.Empty;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Margin = new Padding(0);
                pictureBox.Tag = "Empty";
                tlp_GameBoard.Controls.Add(pictureBox);
            }

            for (var c = 0; c < tlp_pauseIndicator.ColumnCount * tlp_pauseIndicator.RowCount; c++)
            {
                var pictureBox = new PictureBox();
                pictureBox.Image = Resources.Empty;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Margin = new Padding(0);
                tlp_pauseIndicator.Controls.Add(pictureBox);
            }

            session = new GameSession(this);
            soundPlayer = new SoundPlayer();
            lbl_currentPlayer.Text = SessionManager.CurrentPlayer!.Username;
            pic_userAvatar.Image = DataManager.Avatars[SessionManager.CurrentPlayer!.Avatar];
            gameInterval = GameTimer.Interval;
        }

        public GameWindow(GameState gameState)
        {
            InitializeComponent();
            lbl_dbgPlayerInfo.Text = $"SessionManager -> CurrentPlayer:\n{SessionManager.CurrentPlayer}";
            for (var c = 0; c < tlp_GameBoard.ColumnCount * tlp_GameBoard.RowCount; c++)
            {
                var pictureBox = new PictureBox();
                pictureBox.Image = Resources.Empty;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Margin = new Padding(0);
                pictureBox.Tag = "Empty";
                tlp_GameBoard.Controls.Add(pictureBox);
            }

            for (var c = 0; c < tlp_pauseIndicator.ColumnCount * tlp_pauseIndicator.RowCount; c++)
            {
                var pictureBox = new PictureBox();
                pictureBox.Image = Resources.Empty;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Margin = new Padding(0);
                tlp_pauseIndicator.Controls.Add(pictureBox);
            }

            session = new GameSession(this, gameState);
            soundPlayer = new SoundPlayer();
            lbl_currentPlayer.Text = SessionManager.CurrentPlayer!.Username;
            pic_userAvatar.Image = DataManager.Avatars[SessionManager.CurrentPlayer!.Avatar];
            gameInterval = GameTimer.Interval;
            ForceRender(TilesFromString(gameState.Tiles), gameState.Tags);
        }

        public int Interval
        {
            get => GameTimer.Interval;
            set => GameTimer.Interval = value;
        }

        public int boardWidth => tlp_GameBoard.ColumnCount;
        public int boardHeight => tlp_GameBoard.RowCount;
        public bool Tick => GameTimer.Enabled;
        public bool Halt { get; private set; }
    
        public TableLayoutControlCollection Cells {
            get => tlp_GameBoard.Controls;
       }


        public List<Image> Tiles
        {
            get
            {
                var tiles = new List<Image>();
                foreach (PictureBox tile in tlp_GameBoard.Controls)
                {
                    var image = tile.Image;
                    if (Convert.ToString(tile.Tag)!.Equals("Empty")) image.Tag = "Empty";
                    tiles.Add(image);
                }

                return tiles;
            }
        }

        public List<string> Tags
        {
            get
            {
                var tags = new List<string>();
                foreach (PictureBox tile in tlp_GameBoard.Controls) tags.Add((string)tile.Tag);
                return tags;
            }
        }

        private void startCutscene()
        {
        }

        private void pic_GameScreen_Click(object sender, EventArgs e)
        {
        }

        private void GameWindow_VisibilityChanged(object sender, EventArgs e)
        {
            if (!Visible) return;
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
            if (Halt) return;
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
                    session.AdjustX(-1);
                    break;
                case Keys.Right:
                    session.AdjustX(1);
                    break;
                case Keys.Down:
                    GameTimer.Interval = 35;
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
                    GameTimer.Interval = Convert.ToInt32((double) gameInterval / session.Multiplier);
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
                    for (var i = 0; i < boardWidth * boardHeight; i++)
                        (tlp_pauseIndicator.Controls[i] as PictureBox)!.Image = Resources.Empty;
                    exitTicks = 0;
                    break;
            }
        }

        public PictureBox? GetCellFromCoordinates(int x, int y)
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

        public void Clear()
        {
            for (int i = 0; i < boardHeight; i++)
            {
                RemoveRow(16);
            }
        }

        public void RemoveRow(int row)
        {
            var tiles = new List<Image>();
            var tags = new List<string>();
            foreach (PictureBox tile in tlp_GameBoard.Controls)
            {
                tiles.Add(tile.Image);
                tags.Add((string)tile.Tag);
            }

            tiles.RemoveRange(tlp_GameBoard.Controls.Count - boardWidth * (boardHeight - row), boardWidth);
            tags.RemoveRange(tlp_GameBoard.Controls.Count - boardWidth * (boardHeight - row), boardWidth);
            for (var i = 0; i < boardWidth; i++)
            {
                tiles.Insert(0, Resources.Empty);
                tags.Insert(0, "Empty");
            }

            ForceRender(tiles, tags);
            session.ClearedLines += 1;
            if (session.ClearedLines > 5 && session.ClearedLines % 5 == 0 && session.Multiplier < 9.95)
            {
                session.Multiplier += 0.10;
            }
        }

        public List<string> TilesToString(List<Image> tilesimg)
        {
            var tiles = new List<string>();
            foreach (var tile in tilesimg)
                if (tile.Tag != null && tile.Tag != "Empty")
                    tiles.Add(tile.Tag!.ToString()!);
                else
                    tiles.Add("Empty");

            return tiles;
        }

        public List<Image> TilesFromString(List<string> tilesstr)
        {
            var tiles = new List<Image>();
            foreach (var tile in tilesstr)
                if (tile != "Empty")
                {
                    var newTile = DataManager.Tiles[(int)Enum.Parse(typeof(BlockType), tile)];
                    newTile.Tag = tile;
                    tiles.Add(newTile);
                }
                else
                {
                    tiles.Add(Resources.Empty);
                }

            return tiles;
        }

        public void ForceRender(List<Image> tiles, List<string> tags)
        {
            for (var i = 0; i < tlp_GameBoard.Controls.Count; i++)
            {
                (tlp_GameBoard.Controls[i] as PictureBox).Image = tiles[i];
                tlp_GameBoard.Controls[i].Tag = tags[i];
            }
        }

        public void CheckLines()
        {
            var lines = 0;
            for (var i = 0; i < boardHeight; i++)
            {
                var full = true;
                for (var j = 0; j < boardWidth; j++)
                    if (Convert.ToString(GetCellFromCoordinates(j, i).Tag).Equals("Empty")
                        || Convert.ToString(GetCellFromCoordinates(j, i).Tag).Equals("Ghost"))
                        full = false;
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
            Halt = true;
            currentBlock = null;
            new GameEnd(session, SessionManager.CurrentPlayer.HighScore).Show();
            session.GameOver();
            soundPlayer.Stop();
            Close();
        }

        private void UpdateHud()
        {
            if (session.HeldBlock != null)
            {
                var hudImg = pic_hold;
                var index = (int)session.HeldBlock.Type;
                var previewImg = DataManager.Previews[index];
                hudImg.Image = previewImg;
            }

            pic_nextUp1.Image = DataManager.Previews[(int)session.BlockQueue[0].Type];
            pic_nextUp2.Image = DataManager.Previews[(int)session.BlockQueue[1].Type];
            pic_nextUp3.Image = DataManager.Previews[(int)session.BlockQueue[2].Type];
            pic_nextUp4.Image = DataManager.Previews[(int)session.BlockQueue[3].Type];
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
                    var totalTiles = boardWidth * boardHeight;
                    var startIndex = totalTiles - boardWidth * exitTicks;
                    for (var i = startIndex; i < totalTiles; i++)
                        (tlp_pauseIndicator.Controls[i] as PictureBox).Image = Resources.Board_Reverse_L;
                }
            }
            else
            {
                ExitTimer.Stop();
                session.Save(this, TilesToString(Tiles), Tags);
            }
        }
    }
}