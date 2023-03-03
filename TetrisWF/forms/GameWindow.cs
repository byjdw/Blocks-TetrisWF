using AS_Coursework.enums;
using AS_Coursework.@internal;
using AS_Coursework.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace AS_Coursework.game
{
    public partial class GameWindow : Form
    {
        int boardWidth;
        int boardHeight;
        int gameInterval;
        GameSession gameSession;
        List<Image> preview = new List<Image>
            {
                Properties.Resources.Full_L,
                Properties.Resources.Full_Line,
                Properties.Resources.Full_Reverse_L,
                Properties.Resources.Full_S,
                Properties.Resources.Full_Square,
                Properties.Resources.Full_T,
                Properties.Resources.Full_Z,
            };

        Block? currentBlock;

        public GameWindow()
        {
            InitializeComponent();
            lbl_dbgPlayerInfo.Text = "SessionManager -> CurrentPlayer:\n" + SessionManager.CurrentPlayer.ToString();
            boardHeight = tlp_GameBoard.RowCount;
            boardWidth = tlp_GameBoard.ColumnCount;
            for (int c = 0; c < (tlp_GameBoard.ColumnCount * tlp_GameBoard.RowCount); c++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Properties.Resources.Empty;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Margin = new Padding(0);
                pictureBox.Tag = "Empty";
                tlp_GameBoard.Controls.Add(pictureBox);
            }
            this.gameSession = new GameSession();
            lbl_currentPlayer.Text = SessionManager.CurrentPlayer!.Username;
            pic_userAvatar.Image = SessionManager.CurrentPlayer!.Avatar;
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
            currentBlock = new Block(BlockType.LINE, boardWidth, boardHeight);
            pic_hold.Image = preview[new Random().Next(0, 6)];
            pic_nextUp1.Image = preview[new Random().Next(0, 6)];
            pic_nextUp2.Image = preview[new Random().Next(0, 6)];
            pic_nextUp3.Image = preview[new Random().Next(0, 6)];
            pic_nextUp4.Image = preview[new Random().Next(0, 6)];
            GameTimer.Start();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (currentBlock != null)
            {
                currentBlock.Descend(this);
                if (currentBlock.Idle)
                {
                    label1.Text = "Block Idle";
                    GameTimer.Interval = gameInterval;
                    currentBlock = null;
                }
            }
            else
            {
                currentBlock = new Block(BlockType.LINE, boardWidth, boardHeight);
            }

        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (currentBlock == null) return;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Console.WriteLine("Left Key -> x-1");
                    currentBlock.AdjustX(this, -1);
                    break;
                case Keys.Right:
                    Console.WriteLine("Right Key -> x+1");
                    currentBlock.AdjustX(this, 1);
                    break;
                case Keys.Down:
                    if (currentBlock == null) return;
                    GameTimer.Interval = 75;
                    break;
                case Keys.Up:
                    currentBlock.FastFall(this);
                    break;
                case Keys.Space:
                    currentBlock.Rotate(this);
                    break;
            }
        }

        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (currentBlock == null) return;
            switch (e.KeyCode)
            {
                case Keys.Down:
                    GameTimer.Interval = gameInterval;
                    break;
            }
        }


        public PictureBox GetTileFromCoordinates(int x, int y)
        {
            Control control = tlp_GameBoard.GetControlFromPosition(x, y);
            return ((PictureBox)control);
        }

        public void UpdateDebugInfo(string m)
        {
            label1.Text = m;
        }


    }
}

