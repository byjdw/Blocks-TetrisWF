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
            components = new System.ComponentModel.Container();
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
            lbl_GameScore = new Label();
            pic_nextUp4 = new PictureBox();
            lbl_dbgVersionInfo = new Label();
            lbl_dbgPlayerInfo = new Label();
            GameTimer = new Timer(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_userAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_hold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp4).BeginInit();
            SuspendLayout();
            // 
            // lbl_nextUpQueue
            // 
            lbl_nextUpQueue.AutoSize = true;
            lbl_nextUpQueue.Location = new Point(1138, 79);
            lbl_nextUpQueue.Margin = new Padding(4, 0, 4, 0);
            lbl_nextUpQueue.Name = "lbl_nextUpQueue";
            lbl_nextUpQueue.Size = new Size(64, 32);
            lbl_nextUpQueue.TabIndex = 2;
            lbl_nextUpQueue.Text = "Next";
            // 
            // lbl_heldBlock
            // 
            lbl_heldBlock.AutoSize = true;
            lbl_heldBlock.Location = new Point(301, 79);
            lbl_heldBlock.Margin = new Padding(4, 0, 4, 0);
            lbl_heldBlock.Name = "lbl_heldBlock";
            lbl_heldBlock.Size = new Size(65, 32);
            lbl_heldBlock.TabIndex = 4;
            lbl_heldBlock.Text = "Hold";
            // 
            // slbl_playingAs
            // 
            slbl_playingAs.AutoSize = true;
            slbl_playingAs.Location = new Point(121, 1495);
            slbl_playingAs.Margin = new Padding(6, 0, 6, 0);
            slbl_playingAs.Name = "slbl_playingAs";
            slbl_playingAs.Size = new Size(120, 32);
            slbl_playingAs.TabIndex = 11;
            slbl_playingAs.Text = "Playing as";
            // 
            // pic_userAvatar
            // 
            pic_userAvatar.Image = Properties.Resources.Guest;
            pic_userAvatar.Location = new Point(20, 1495);
            pic_userAvatar.Margin = new Padding(4, 2, 4, 2);
            pic_userAvatar.Name = "pic_userAvatar";
            pic_userAvatar.Size = new Size(93, 107);
            pic_userAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_userAvatar.TabIndex = 10;
            pic_userAvatar.TabStop = false;
            // 
            // lbl_currentPlayer
            // 
            lbl_currentPlayer.AutoSize = true;
            lbl_currentPlayer.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_currentPlayer.Location = new Point(121, 1527);
            lbl_currentPlayer.Margin = new Padding(6, 0, 6, 0);
            lbl_currentPlayer.Name = "lbl_currentPlayer";
            lbl_currentPlayer.Size = new Size(81, 32);
            lbl_currentPlayer.TabIndex = 9;
            lbl_currentPlayer.Text = "Guest";
            // 
            // tlp_GameBoard
            // 
            tlp_GameBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp_GameBoard.BackColor = Color.Transparent;
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
            tlp_GameBoard.Location = new Point(366, 77);
            tlp_GameBoard.Margin = new Padding(0);
            tlp_GameBoard.Name = "tlp_GameBoard";
            tlp_GameBoard.RowCount = 17;
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_GameBoard.Size = new Size(769, 1101);
            tlp_GameBoard.TabIndex = 12;
            // 
            // pic_hold
            // 
            pic_hold.Location = new Point(20, 113);
            pic_hold.Margin = new Padding(4, 2, 4, 2);
            pic_hold.Name = "pic_hold";
            pic_hold.Size = new Size(342, 169);
            pic_hold.SizeMode = PictureBoxSizeMode.Zoom;
            pic_hold.TabIndex = 13;
            pic_hold.TabStop = false;
            // 
            // pic_nextUp1
            // 
            pic_nextUp1.Location = new Point(1138, 113);
            pic_nextUp1.Margin = new Padding(4, 2, 4, 2);
            pic_nextUp1.Name = "pic_nextUp1";
            pic_nextUp1.Size = new Size(342, 169);
            pic_nextUp1.SizeMode = PictureBoxSizeMode.Zoom;
            pic_nextUp1.TabIndex = 15;
            pic_nextUp1.TabStop = false;
            // 
            // pic_nextUp2
            // 
            pic_nextUp2.Location = new Point(1138, 288);
            pic_nextUp2.Margin = new Padding(4, 2, 4, 2);
            pic_nextUp2.Name = "pic_nextUp2";
            pic_nextUp2.Size = new Size(342, 169);
            pic_nextUp2.SizeMode = PictureBoxSizeMode.Zoom;
            pic_nextUp2.TabIndex = 16;
            pic_nextUp2.TabStop = false;
            // 
            // pic_nextUp3
            // 
            pic_nextUp3.Location = new Point(1138, 463);
            pic_nextUp3.Margin = new Padding(4, 2, 4, 2);
            pic_nextUp3.Name = "pic_nextUp3";
            pic_nextUp3.Size = new Size(342, 169);
            pic_nextUp3.SizeMode = PictureBoxSizeMode.Zoom;
            pic_nextUp3.TabIndex = 17;
            pic_nextUp3.TabStop = false;
            // 
            // lbl_GameScore
            // 
            lbl_GameScore.AutoSize = true;
            lbl_GameScore.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_GameScore.Location = new Point(717, 1549);
            lbl_GameScore.Margin = new Padding(6, 0, 6, 0);
            lbl_GameScore.Name = "lbl_GameScore";
            lbl_GameScore.Size = new Size(90, 32);
            lbl_GameScore.TabIndex = 18;
            lbl_GameScore.Text = "SCORE";
            // 
            // pic_nextUp4
            // 
            pic_nextUp4.Location = new Point(1138, 636);
            pic_nextUp4.Margin = new Padding(4, 2, 4, 2);
            pic_nextUp4.Name = "pic_nextUp4";
            pic_nextUp4.Size = new Size(342, 169);
            pic_nextUp4.SizeMode = PictureBoxSizeMode.Zoom;
            pic_nextUp4.TabIndex = 19;
            pic_nextUp4.TabStop = false;
            // 
            // lbl_dbgVersionInfo
            // 
            lbl_dbgVersionInfo.AutoSize = true;
            lbl_dbgVersionInfo.Location = new Point(22, 288);
            lbl_dbgVersionInfo.Margin = new Padding(6, 0, 6, 0);
            lbl_dbgVersionInfo.Name = "lbl_dbgVersionInfo";
            lbl_dbgVersionInfo.Size = new Size(231, 32);
            lbl_dbgVersionInfo.TabIndex = 20;
            lbl_dbgVersionInfo.Text = "tetriswf - version 1.0";
            // 
            // lbl_dbgPlayerInfo
            // 
            lbl_dbgPlayerInfo.AutoSize = true;
            lbl_dbgPlayerInfo.Location = new Point(22, 320);
            lbl_dbgPlayerInfo.Margin = new Padding(6, 0, 6, 0);
            lbl_dbgPlayerInfo.Name = "lbl_dbgPlayerInfo";
            lbl_dbgPlayerInfo.Size = new Size(128, 32);
            lbl_dbgPlayerInfo.TabIndex = 21;
            lbl_dbgPlayerInfo.Text = "player info";
            // 
            // GameTimer
            // 
            GameTimer.Interval = 1000;
            GameTimer.Tick += GameTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 1280);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 22;
            label1.Text = "label1";
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1484, 1555);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(lbl_dbgVersionInfo);
            Controls.Add(pic_nextUp4);
            Controls.Add(lbl_GameScore);
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
            Controls.Add(lbl_dbgPlayerInfo);
            Margin = new Padding(4, 2, 4, 2);
            MaximumSize = new Size(1510, 1626);
            MinimumSize = new Size(1510, 1626);
            Name = "GameWindow";
            Text = "Blocks · Game in Progress";
            VisibleChanged += GameWindow_VisibilityChanged;
            KeyDown += GameWindow_KeyDown;
            KeyUp += GameWindow_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pic_userAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_hold).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp4).EndInit();
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
        private Label lbl_GameScore;
        private PictureBox pic_nextUp4;
        private Label lbl_dbgVersionInfo;
        private Label lbl_dbgPlayerInfo;
        private Timer GameTimer;
        private Label label1;
    }
}