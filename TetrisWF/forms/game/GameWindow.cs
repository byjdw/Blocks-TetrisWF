﻿using AS_Coursework.enums;
using AS_Coursework.@internal;
using AS_Coursework.io;
using AS_Coursework.io.audio;
using AS_Coursework.models;
using AS_Coursework.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_Coursework.forms.game
{

    public partial class GameWindow : Form
    {
        private readonly int gameInterval;

        private readonly GameSession session;

        private int exitTicks;

        bool musicMuted;

        public GameWindow()
        {
            InitializeComponent();
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

            for (var c = 0; c < tlp_GameIndicator.ColumnCount * tlp_GameIndicator.RowCount; c++)
            {
                var pictureBox = new PictureBox();
                pictureBox.Image = Resources.Empty;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Margin = new Padding(0);
                tlp_GameIndicator.Controls.Add(pictureBox);
            }

            bool musicMuted = false;
            session = new GameSession(this);
            lbl_Player.Text = SessionManager.CurrentPlayer!.Username;
            pic_PlayerAvatar.Image = GameIOManager.Avatars[SessionManager.CurrentPlayer!.Avatar];
            gameInterval = GameTimer.Interval;
            BackgroundImage = GameIOManager.Backgrounds[Random.Shared.Next(0, GameIOManager.Backgrounds.Count - 1)];
        }

        public GameWindow(GameState gameState)
        {
            InitializeComponent();
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

            for (var c = 0; c < tlp_GameIndicator.ColumnCount * tlp_GameIndicator.RowCount; c++)
            {
                var pictureBox = new PictureBox();
                pictureBox.Image = Resources.Empty;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Margin = new Padding(0);
                tlp_GameIndicator.Controls.Add(pictureBox);
            }

            session = new GameSession(this, gameState);
            lbl_Player.Text = SessionManager.CurrentPlayer!.Username;
            pic_PlayerAvatar.Image = GameIOManager.Avatars[SessionManager.CurrentPlayer!.Avatar];
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

        public TableLayoutControlCollection Cells
        {
            get => tlp_GameBoard.Controls;
        }


        public List<Image> Tiles
        {
            get
            {
                var tiles = new List<Image>();
                foreach (PictureBox cell in tlp_GameBoard.Controls)
                {
                    var image = cell.Image;
                    if (Convert.ToString(cell.Tag)!.Equals("Empty")) image.Tag = "Empty";
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

        private async void GameWindow_VisibilityChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                AudioController.StopBackgroundMusic();
            }
            else
            {
                UpdateHud();
                await PlayStartCutscene();
                AudioController.PlayBackgroundMusic();
            }
        }

        /// <summary>
        ///     This function plays a start cutscene for the game, including a countdown and sound effects.
        /// </summary>
        private async Task PlayStartCutscene()
        {
            tlp_GameIndicator.Visible = true;
            List<Color> Colors = new List<Color>()
            {
                Color.Red,
                Color.DodgerBlue,
                Color.Lime,
                Color.Gold
            };
            for (int i = 3; i > 0; i--)
            {
                foreach (PictureBox Cell in tlp_GameIndicator.Controls)
                {
                    Cell.Image = GameIOManager.Tiles[Random.Shared.Next(0, GameIOManager.Tiles.Count - 1)];
                }
                Color c = Colors[Random.Shared.Next(0, Colors.Count - 1)];
                // Update the label with the current countdown number
                lbl_Countdown.Text = i.ToString();
                lbl_Countdown.BackColor = c;
                Colors.Remove(c);
                // Play the sound effect for the current countdown number
                Task.Run(() => AudioController.PlaySoundEffect("count"));
                if (i == 1)
                {
                    GameTimer.Start();
                }
                // Wait for 1 second before moving to the next countdown number
                await Task.Delay(1000);
            }
            ClearPauseIndicator();
            tlp_GameIndicator.Visible = false;

            // Update the label to indicate the end of the cutscene
            Task.Run(() => AudioController.PlaySoundEffect("start"));
            lbl_Countdown.Text = "GO!";
            lbl_Countdown.BackColor = Colors[0];
            await Task.Delay(1000);
            lbl_Countdown.Visible = false;
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
                    session.MoveHorizontally(-1);
                    break;
                case Keys.Right:
                    session.MoveHorizontally(1);
                    break;
                case Keys.Down:
                    GameTimer.Interval = 35;
                    break;
                case Keys.A:
                    session.MoveHorizontally(-1);
                    break;
                case Keys.D:
                    session.MoveHorizontally(1);
                    break;
                case Keys.S:
                    GameTimer.Interval = 35;
                    break;
                case Keys.M:
                    if (musicMuted)
                    {
                        AudioController.PlayBackgroundMusic();
                        musicMuted = false;
                    }
                    else
                    {
                        AudioController.StopBackgroundMusic();
                        musicMuted = true;
                    }
                    break;
                case Keys.Tab:
                    if (!SessionManager.DebugMode) return;
                    GameTimer.Stop();
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
                    session.RotateClockwise();
                    break;
                case Keys.W:
                    if (!GameTimer.Enabled) return;
                    session.RotateClockwise();
                    break;
                case Keys.Down:
                    if (!GameTimer.Enabled) return;
                    GameTimer.Interval = Convert.ToInt32((double)gameInterval / session.Multiplier);
                    break;
                case Keys.S:
                    if (!GameTimer.Enabled) return;
                    GameTimer.Interval = Convert.ToInt32((double)gameInterval / session.Multiplier);
                    break;
                case Keys.Tab:
                    GameTimer.Start();
                    break;
                case Keys.F10:
                    if (!SessionManager.DebugMode)
                    {
                        SessionManager.DebugMode = true;
                        lbl_DebugModeEnabled.Visible = true;
                    }
                    else
                    {
                        SessionManager.DebugMode = false;
                        lbl_DebugModeEnabled.Visible = false;
                    }
                    break;
                case Keys.Enter:
                    ChangeWallpaper();
                    break;
                case Keys.Q:
                    if (!SessionManager.DebugMode) return;
                    if (GameTimer.Enabled) return;
                    session.CurrentBlock.Hide(this);
                    RemoveRow(boardHeight - 1);
                    session.MoveHorizontally(0);
                    break;
                case Keys.Escape:
                    if (!ExitTimer.Enabled) return;
                    ExitTimer.Stop();
                    GameTimer.Start();
                    HidePauseIndicator();
                    ClearPauseIndicator();
                    exitTicks = 0;
                    break;
            }
        }

        /// <summary>
        ///     The function hides the pause indicator and its associated text labels.
        /// </summary>
        private void HidePauseIndicator()
        {
            tlp_GameIndicator.Visible = false;
            lbl_IndicatorText1.Visible = false;
            lbl_IndicatorText2.Visible = false;
            lbl_IndicatorText3.Visible = false;
            lbl_IndicatorText4.Visible = false;
        }

        /// <summary>
        ///     The function clears the pause indicator by setting the image of each PictureBox in a
        ///     TableLayoutPanel to an empty resource.
        /// </summary>
        private void ClearPauseIndicator()
        {
            foreach (PictureBox Cell in tlp_GameIndicator.Controls)
            {
                Cell.Image = Resources.Empty;
            }
        }

        /// <summary>
        ///     The function returns a PictureBox control from a TableLayoutPanel based on its coordinates, or null
        ///     if it doesn't exist.
        /// </summary>
        /// <param name="x">The x-coordinate of the cell on the game board.</param>
        /// <param name="y">The y parameter of the cell on the game board.</param>
        /// <returns>
        /// A PictureBox control or null if there is no control at the specified position in the
        /// TableLayoutPanel.
        /// </returns>
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

        /// <summary>
        /// This function removes a row of images from a game board and updates the game session statistics.
        /// </summary>
        /// <param name="row">The row parameter is an integer that represents the index of the row to be removed
        /// from the game board.</param>
        public void RemoveRow(int row)
        {
            var tiles = new List<Image>(Tiles);
            var tags = new List<string>(Tags);

            tiles.RemoveRange(tlp_GameBoard.Controls.Count - boardWidth * (boardHeight - row), boardWidth);
            tags.RemoveRange(tlp_GameBoard.Controls.Count - boardWidth * (boardHeight - row), boardWidth);
            for (var i = 0; i < boardWidth; i++)
            {
                tiles.Insert(0, Resources.Empty);
                tags.Insert(0, "Empty");
            }

            ForceRender(tiles, tags);
            session.LinesCleared += 1;
            if (session.LinesCleared > 5 && session.LinesCleared % 10 == 0 && session.Multiplier < 9.90)
            {
                session.Multiplier += 0.20;
                AudioController.PlaySoundEffect("levelup");

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
                    var newTile = GameIOManager.Tiles[(int)Enum.Parse(typeof(BlockType), tile)];
                    newTile.Tag = tile;
                    tiles.Add(newTile);
                }
                else
                {
                    tiles.Add(Resources.Empty);
                }

            return tiles;
        }

        /// <summary>
        /// The function updates the images and tags of PictureBox controls in a TableLayoutPanel with the
        /// provided lists of images and tags.
        /// </summary>
        /// <param name="tiles">A list of Image objects representing the images to be displayed on a game
        /// board.</param>
        /// <param name="tags">The `tags` parameter is a list of strings that contains tags for each image in
        /// the `tiles` list. These tags can be used to identify and manipulate specific images in the
        /// `tlp_GameBoard` control.</param>
        public void ForceRender(List<Image> tiles, List<string> tags)
        {
            for (var i = 0; i < tlp_GameBoard.Controls.Count; i++)
            {
                (tlp_GameBoard.Controls[i] as PictureBox).Image = tiles[i];
                tlp_GameBoard.Controls[i].Tag = tags[i];
            }
        }

        /// <summary>
        ///     Checks for full lines in a game board and removes them, updating the score and HUD
        ///     accordingly.
        /// </summary>
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

        /// <summary>
        ///     Stops the game timer, triggers a game over cutscene, displays the player's high score,
        ///     ends the game session, hides the current game window, and disposes of it.
        /// </summary>
        public async void GameOver()
        {
            GameTimer.Stop();
            Halt = true;
            await GameOverCutscene();
            new GameEnd(session, SessionManager.CurrentPlayer.HighScore).Show();
            session.GameOver();
            Hide();
            Dispose();
        }

        /// <summary>
        ///     Plays a game over cutscene by hiding the current block, stopping background music, and
        ///     changing the images of non-empty cells on the game board.
        /// </summary>
        private async Task GameOverCutscene()
        {
            session.CurrentBlock.Hide(this);
            AudioController.StopBackgroundMusic();
            await Task.Delay(250);
            foreach (PictureBox Cell in Cells)
            {
                if (!Convert.ToString(Cell.Tag).Equals("Empty"))
                    Cell.Image = Resources.Board_Z;
            }
            await Task.Delay(2250);
        }

        /// <summary>
        ///     Updates the game's heads-up display with information about the player's held block,
        ///     block queue, score, lines cleared, and game speed.
        /// </summary>
        private void UpdateHud()
        {
            if (session.HeldBlock != null)
            {
                var hudImg = pic_Hold;
                var index = (int)session.HeldBlock.Type;
                var previewImg = GameIOManager.Previews[index];
                hudImg.Image = previewImg;
            }

            pic_Queue1.Image = GameIOManager.Previews[(int)session.BlockQueue[0].Type];
            pic_Queue2.Image = GameIOManager.Previews[(int)session.BlockQueue[1].Type];
            Pic_Queue3.Image = GameIOManager.Previews[(int)session.BlockQueue[2].Type];
            pic_nextUp4.Image = GameIOManager.Previews[(int)session.BlockQueue[3].Type];
            lbl_GameScore.Text = session.Score.ToString();
            lbl_LinesCleared.Text = session.LinesCleared.ToString() + " Lines";
            lbl_GameSpeed.Text = Math.Round(session.Multiplier, 2).ToString("0.00") + "x Speed";
        }

        private void Form_OnClosing(object sender, FormClosingEventArgs e)
        {
            AudioController.StopBackgroundMusic();
            GameOver();
        }

        private async void ExitTimer_Tick(object sender, EventArgs e)
        {
            if (exitTicks < boardHeight)
            {
                if (ExitTimer.Enabled)
                {
                    GameTimer.Stop();
                    exitTicks++;
                    lbl_IndicatorText1.Visible = true;
                    lbl_IndicatorText2.Visible = true;
                    lbl_IndicatorText3.Visible = true;
                    lbl_IndicatorText4.Visible = true;
                    tlp_GameIndicator.Visible = true;
                    // Console.WriteLine(exitTicks);
                    var totalTiles = boardWidth * boardHeight;
                    var startIndex = totalTiles - boardWidth * exitTicks;
                    for (var i = startIndex; i < totalTiles; i++)
                        (tlp_GameIndicator.Controls[i] as PictureBox).Image = GameIOManager.Tiles[Random.Shared.Next(0, GameIOManager.Tiles.Count - 1)];
                    AudioController.PlaySoundEffect("rotate");
                }
            }
            else
            {
                ExitTimer.Stop();
                AudioController.PlaySoundEffect("pause");
                AudioController.StopBackgroundMusic();
                lbl_IndicatorText1.Visible = false;
                lbl_IndicatorText2.Visible = false;
                lbl_IndicatorText4.Visible = false;
                if (SessionManager.CurrentPlayer.IsGuest)
                {
                    lbl_IndicatorText3.Visible = false;
                    ForceRenderIndicator(Resources.Ghost);
                    GameOver();
                    return;
                }

                lbl_IndicatorText3.Text = "SAVING...";
                ForceRenderIndicator(Resources.Board_S);
                await Task.Delay(2500);
                session.Save(this, TilesToString(Tiles), Tags);
            }
        }

        /// <summary>
        ///     The function updates the image of all PictureBox controls in a TableLayoutPanel to a specified
        ///     image.
        /// </summary>
        /// <param name="Image">The Image parameter is an object that represents a graphic image. In this
        /// method, it is used as the boardTile parameter, which is the image that will be set as the image of
        /// each PictureBox control in the tlp_GameIndicator container.</param>
        private void ForceRenderIndicator(Image boardTile)
        {
            foreach (PictureBox Cell in tlp_GameIndicator.Controls)
            {
                Cell.Image = boardTile;
            }
        }

        /// <summary>
        ///     This function changes the wallpaper by selecting a random image from a list of available
        ///     backgrounds.
        /// </summary>
        public void ChangeWallpaper()
        {
            BackgroundImage = GameIOManager.Backgrounds[Random.Shared.Next(0, GameIOManager.Backgrounds.Count - 1)];
        }
    }
}