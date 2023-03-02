using AS_Coursework.enums;
using AS_Coursework.@internal;
using AS_Coursework.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_Coursework.game
{
    public partial class GameWindow : Form
    {
        int boardWidth;
        int boardHeight;
        GameSession gameSession;
        List<Image> tiles = new List<Image>
            {
                Properties.Resources.Board_L,
                Properties.Resources.Board_Line,
                Properties.Resources.Board_Reverse_L,
                Properties.Resources.Board_S,
                Properties.Resources.Board_Square,
                Properties.Resources.Board_T,
                Properties.Resources.Board_Z,
            };
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

        Block currentBlock;

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
                tlp_GameBoard.Controls.Add(pictureBox);
            }
            this.gameSession = new GameSession();
            currentBlock = new Block(BlockType.LINE, boardWidth, boardHeight);
            lbl_currentPlayer.Text = SessionManager.CurrentPlayer!.Username;
            pic_userAvatar.Image = SessionManager.CurrentPlayer!.Avatar;
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
            currentBlock.AdjustY(this, 1);
            if (currentBlock.Idle)
            {
                currentBlock = GameSession.
            }
        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    currentBlock.AdjustX(this, -1);
                    break;
                case Keys.Right:
                    currentBlock.AdjustX(this, 1);
                    break;
                case Keys.Down:
                    GameTimer.Interval = 100;
                    break;
                case Keys.Up:
                    break;
                case Keys.Space:
                    break;
            }
        }

        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    GameTimer.Interval = 1000;
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
