using AS_Coursework.@internal;
using AS_Coursework.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_Coursework.game
{
    public partial class GameWindow : Form
    {
        GameSession gameSession;
        public GameWindow()
        {
            InitializeComponent();
            List<Image> block = new List<Image>
            {
                Properties.Resources.Board_L,
                Properties.Resources.Board_Line,
                Properties.Resources.Board_Reverse_L,
                Properties.Resources.Board_S,
                Properties.Resources.Board_Square,
                Properties.Resources.Board_T,
                Properties.Resources.Board_Z,
            };
            List<Image> blockfull = new List<Image>
            {
                Properties.Resources.Avatar_L,
                Properties.Resources.Avatar_Line,
                Properties.Resources.Avatar_Reverse_L,
                Properties.Resources.Avatar_S,
                Properties.Resources.Avatar_Square,
                Properties.Resources.Avatar_T,
                Properties.Resources.Avatar_Z,
            };
            for (int c = 0; c < (tlp_GameBoard.ColumnCount * tlp_GameBoard.RowCount); c++)
            {
                // for (int r = 0; r < (tlp_GameBoard.RowCount); r++)
                // {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = block[new Random().Next(0, 6)];
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Margin = new Padding(0);
                tlp_GameBoard.Controls.Add(pictureBox);
                // }
            }
            pic_hold.Image = blockfull[new Random().Next(0, 6)];
            pic_nextUp1.Image = blockfull[new Random().Next(0, 6)];
            pic_nextUp2.Image = blockfull[new Random().Next(0, 6)];
            pic_nextUp3.Image = blockfull[new Random().Next(0, 6)];
            this.gameSession = new GameSession();
            lbl_currentPlayer.Text = SessionManager.CurrentPlayer!.Username;
            pic_userAvatar.Image = SessionManager.CurrentPlayer!.Avatar;
            Block CurrentBlock = new Block(0, 1, false, 0, 0);
            int[,] blockPositions = CurrentBlock.positionOffsets;
            for (int i = 0; i < CurrentBlock.positionOffsets.Length; i++)
            {
                    //Control control = tlp_GameBoard.GetControlFromPosition(
                    //    blockPositions[i, 0], blockPositions[i, 1]);
                    //(control as PictureBox).Image = CurrentBlock.blockTile;
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
            if (!this.Visible) return;
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
