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

        int y;
        int x;

        public GameWindow()
        {
            InitializeComponent();
            lbl_dbgPlayerInfo.Text = "SessionManager -> CurrentPlayer:\n" + SessionManager.CurrentPlayer.ToString();
            boardHeight = tlp_GameBoard.RowCount;
            boardWidth = tlp_GameBoard.ColumnCount;
            for (int c = 0; c < (tlp_GameBoard.ColumnCount * tlp_GameBoard.RowCount); c++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Properties.Resources.Board_S;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Margin = new Padding(0);
                tlp_GameBoard.Controls.Add(pictureBox);
            }
            this.gameSession = new GameSession();
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
            if (y == boardHeight) return;
            if (y != 0)
            {
                Block OldBlock = new Block(BlockType.Line, 0, x, y-1);
                foreach (var position in OldBlock)
                {
                    Image tile = GetTileFromCoordinates(position[0], position[1]);
                    tile = OldBlock.blockTile;
                }
            }
            Block CurrentBlock = new Block("line", 0, x, y);
            foreach (int[] position in CurrentBlock.positions)
            {
                Image tile = GetTileFromCoordinates(position[0], position[1]);
                tile = CurrentBlock.blockTile;
            }
            y++;
        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    x--;
                    break;
                case Keys.Right:
                    x++;
                    break;
            }
        }

        private Image GetTileFromCoordinates(int x, int y)
        {
            Control control = tlp_GameBoard.GetControlFromPosition(x, y);
            return ((PictureBox) control).Image;
        }
    }
}
