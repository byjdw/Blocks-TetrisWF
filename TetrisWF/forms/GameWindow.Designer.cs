using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework.game
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_nextUpQueue = new Label();
            lbl_heldBlock = new Label();
            slbl_playingAs = new Label();
            pic_userAvatar = new controls.CircularPictureBox();
            lbl_currentPlayer = new Label();
            tlp_GameBoard = new TableLayoutPanel();
            pic_hold = new PictureBox();
            pic_nextUp1 = new PictureBox();
            pic_nextUp2 = new PictureBox();
            pic_nextUp3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_userAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_hold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp3).BeginInit();
            SuspendLayout();
            // 
            // lbl_nextUpQueue
            // 
            lbl_nextUpQueue.AutoSize = true;
            lbl_nextUpQueue.Location = new Point(384, 178);
            lbl_nextUpQueue.Margin = new Padding(2, 0, 2, 0);
            lbl_nextUpQueue.Name = "lbl_nextUpQueue";
            lbl_nextUpQueue.Size = new Size(32, 15);
            lbl_nextUpQueue.TabIndex = 2;
            lbl_nextUpQueue.Text = "Next";
            // 
            // lbl_heldBlock
            // 
            lbl_heldBlock.AutoSize = true;
            lbl_heldBlock.Location = new Point(383, 75);
            lbl_heldBlock.Margin = new Padding(2, 0, 2, 0);
            lbl_heldBlock.Name = "lbl_heldBlock";
            lbl_heldBlock.Size = new Size(33, 15);
            lbl_heldBlock.TabIndex = 4;
            lbl_heldBlock.Text = "Hold";
            // 
            // slbl_playingAs
            // 
            slbl_playingAs.AutoSize = true;
            slbl_playingAs.Location = new Point(524, 6);
            slbl_playingAs.Name = "slbl_playingAs";
            slbl_playingAs.Size = new Size(60, 15);
            slbl_playingAs.TabIndex = 11;
            slbl_playingAs.Text = "Playing as";
            // 
            // pic_userAvatar
            // 
            pic_userAvatar.Image = Properties.Resources.Guest;
            pic_userAvatar.Location = new Point(470, 6);
            pic_userAvatar.Margin = new Padding(2, 1, 2, 1);
            pic_userAvatar.Name = "pic_userAvatar";
            pic_userAvatar.Size = new Size(50, 50);
            pic_userAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_userAvatar.TabIndex = 10;
            pic_userAvatar.TabStop = false;
            // 
            // lbl_currentPlayer
            // 
            lbl_currentPlayer.AutoSize = true;
            lbl_currentPlayer.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_currentPlayer.Location = new Point(524, 21);
            lbl_currentPlayer.Name = "lbl_currentPlayer";
            lbl_currentPlayer.Size = new Size(42, 15);
            lbl_currentPlayer.TabIndex = 9;
            lbl_currentPlayer.Text = "Guest";
            // 
            // tlp_GameBoard
            // 
            tlp_GameBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp_GameBoard.ColumnCount = 10;
            tlp_GameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameBoard.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tlp_GameBoard.Location = new Point(17, 21);
            tlp_GameBoard.Margin = new Padding(0);
            tlp_GameBoard.Name = "tlp_GameBoard";
            tlp_GameBoard.RowCount = 15;
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666667F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666667F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666667F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666667F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666667F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666667F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666667F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666667F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666667F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666667F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666667F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666667F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666667F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666667F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666667F));
            tlp_GameBoard.Size = new Size(351, 459);
            tlp_GameBoard.TabIndex = 12;
            // 
            // pic_hold
            // 
            pic_hold.Location = new Point(384, 91);
            pic_hold.Margin = new Padding(2, 1, 2, 1);
            pic_hold.Name = "pic_hold";
            pic_hold.Size = new Size(184, 79);
            pic_hold.SizeMode = PictureBoxSizeMode.Zoom;
            pic_hold.TabIndex = 13;
            pic_hold.TabStop = false;
            // 
            // pic_nextUp1
            // 
            pic_nextUp1.Location = new Point(384, 194);
            pic_nextUp1.Margin = new Padding(2, 1, 2, 1);
            pic_nextUp1.Name = "pic_nextUp1";
            pic_nextUp1.Size = new Size(184, 79);
            pic_nextUp1.SizeMode = PictureBoxSizeMode.Zoom;
            pic_nextUp1.TabIndex = 15;
            pic_nextUp1.TabStop = false;
            // 
            // pic_nextUp2
            // 
            pic_nextUp2.Location = new Point(384, 276);
            pic_nextUp2.Margin = new Padding(2, 1, 2, 1);
            pic_nextUp2.Name = "pic_nextUp2";
            pic_nextUp2.Size = new Size(184, 79);
            pic_nextUp2.SizeMode = PictureBoxSizeMode.Zoom;
            pic_nextUp2.TabIndex = 16;
            pic_nextUp2.TabStop = false;
            // 
            // pic_nextUp3
            // 
            pic_nextUp3.Location = new Point(384, 358);
            pic_nextUp3.Margin = new Padding(2, 1, 2, 1);
            pic_nextUp3.Name = "pic_nextUp3";
            pic_nextUp3.Size = new Size(184, 79);
            pic_nextUp3.SizeMode = PictureBoxSizeMode.Zoom;
            pic_nextUp3.TabIndex = 17;
            pic_nextUp3.TabStop = false;
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(593, 480);
            ControlBox = false;
            Controls.Add(pic_nextUp3);
            Controls.Add(pic_nextUp2);
            Controls.Add(pic_nextUp1);
            Controls.Add(pic_hold);
            Controls.Add(tlp_GameBoard);
            Controls.Add(slbl_playingAs);
            Controls.Add(pic_userAvatar);
            Controls.Add(lbl_currentPlayer);
            Controls.Add(lbl_heldBlock);
            Controls.Add(lbl_nextUpQueue);
            Margin = new Padding(2, 1, 2, 1);
            Name = "GameWindow";
            Text = "Blocks · Game in Progress";
            ((System.ComponentModel.ISupportInitialize)pic_userAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_hold).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_score;
        private Label lbl_nextUpQueue;
        private Label lbl_time;
        private Label lbl_heldBlock;
        private PictureBox pic_heldBlock;
        private PictureBox pic_upNextQueue;
        private Label slbl_playingAs;
        private controls.CircularPictureBox pic_userAvatar;
        private Label lbl_currentPlayer;
        private TableLayoutPanel tlp_GameBoard;
        private PictureBox pic_hold;
        private PictureBox pictureBox2;
        private PictureBox pic_nextUp1;
        private PictureBox pic_nextUp2;
        private PictureBox pic_nextUp3;
    }
}