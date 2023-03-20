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
            ExitTimer = new Timer(components);
            lbl_exitText1 = new Label();
            tlp_pauseIndicator = new TableLayoutPanel();
            lbl_exitText2 = new Label();
            lbl_exitText3 = new Label();
            lbl_exitText4 = new Label();
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
            lbl_nextUpQueue.BackColor = Color.Transparent;
            lbl_nextUpQueue.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nextUpQueue.ForeColor = Color.Snow;
            lbl_nextUpQueue.Location = new Point(613, 37);
            lbl_nextUpQueue.Margin = new Padding(2, 0, 2, 0);
            lbl_nextUpQueue.Name = "lbl_nextUpQueue";
            lbl_nextUpQueue.Size = new Size(40, 15);
            lbl_nextUpQueue.TabIndex = 2;
            lbl_nextUpQueue.Text = "NEXT";
            // 
            // lbl_heldBlock
            // 
            lbl_heldBlock.AutoSize = true;
            lbl_heldBlock.BackColor = Color.Transparent;
            lbl_heldBlock.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_heldBlock.ForeColor = Color.Snow;
            lbl_heldBlock.Location = new Point(155, 37);
            lbl_heldBlock.Margin = new Padding(2, 0, 2, 0);
            lbl_heldBlock.Name = "lbl_heldBlock";
            lbl_heldBlock.Size = new Size(41, 15);
            lbl_heldBlock.TabIndex = 4;
            lbl_heldBlock.Text = "HOLD";
            // 
            // slbl_playingAs
            // 
            slbl_playingAs.AutoSize = true;
            slbl_playingAs.BackColor = Color.Transparent;
            slbl_playingAs.ForeColor = Color.Snow;
            slbl_playingAs.Location = new Point(79, 671);
            slbl_playingAs.Name = "slbl_playingAs";
            slbl_playingAs.Size = new Size(60, 15);
            slbl_playingAs.TabIndex = 11;
            slbl_playingAs.Text = "Playing as";
            // 
            // pic_userAvatar
            // 
            pic_userAvatar.BackColor = Color.Transparent;
            pic_userAvatar.BorderStyle = BorderStyle.FixedSingle;
            pic_userAvatar.Location = new Point(9, 670);
            pic_userAvatar.Margin = new Padding(2, 1, 2, 1);
            pic_userAvatar.Name = "pic_userAvatar";
            pic_userAvatar.Size = new Size(65, 65);
            pic_userAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_userAvatar.TabIndex = 10;
            pic_userAvatar.TabStop = false;
            // 
            // lbl_currentPlayer
            // 
            lbl_currentPlayer.AutoSize = true;
            lbl_currentPlayer.BackColor = Color.Transparent;
            lbl_currentPlayer.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_currentPlayer.ForeColor = Color.Snow;
            lbl_currentPlayer.Location = new Point(79, 686);
            lbl_currentPlayer.Name = "lbl_currentPlayer";
            lbl_currentPlayer.Size = new Size(42, 15);
            lbl_currentPlayer.TabIndex = 9;
            lbl_currentPlayer.Text = "Guest";
            // 
            // tlp_GameBoard
            // 
            tlp_GameBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp_GameBoard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            tlp_GameBoard.Location = new Point(197, 36);
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
            tlp_GameBoard.Size = new Size(414, 665);
            tlp_GameBoard.TabIndex = 12;
            // 
            // pic_hold
            // 
            pic_hold.BackColor = Color.Transparent;
            pic_hold.Location = new Point(11, 53);
            pic_hold.Margin = new Padding(2, 1, 2, 1);
            pic_hold.Name = "pic_hold";
            pic_hold.Size = new Size(184, 79);
            pic_hold.SizeMode = PictureBoxSizeMode.Zoom;
            pic_hold.TabIndex = 13;
            pic_hold.TabStop = false;
            // 
            // pic_nextUp1
            // 
            pic_nextUp1.BackColor = Color.Transparent;
            pic_nextUp1.Location = new Point(613, 53);
            pic_nextUp1.Margin = new Padding(2, 1, 2, 1);
            pic_nextUp1.Name = "pic_nextUp1";
            pic_nextUp1.Size = new Size(184, 79);
            pic_nextUp1.SizeMode = PictureBoxSizeMode.Zoom;
            pic_nextUp1.TabIndex = 15;
            pic_nextUp1.TabStop = false;
            // 
            // pic_nextUp2
            // 
            pic_nextUp2.BackColor = Color.Transparent;
            pic_nextUp2.Location = new Point(613, 132);
            pic_nextUp2.Margin = new Padding(2, 1, 2, 1);
            pic_nextUp2.Name = "pic_nextUp2";
            pic_nextUp2.Size = new Size(184, 79);
            pic_nextUp2.SizeMode = PictureBoxSizeMode.Zoom;
            pic_nextUp2.TabIndex = 16;
            pic_nextUp2.TabStop = false;
            // 
            // pic_nextUp3
            // 
            pic_nextUp3.BackColor = Color.Transparent;
            pic_nextUp3.Location = new Point(613, 211);
            pic_nextUp3.Margin = new Padding(2, 1, 2, 1);
            pic_nextUp3.Name = "pic_nextUp3";
            pic_nextUp3.Size = new Size(184, 79);
            pic_nextUp3.SizeMode = PictureBoxSizeMode.Zoom;
            pic_nextUp3.TabIndex = 17;
            pic_nextUp3.TabStop = false;
            // 
            // lbl_GameScore
            // 
            lbl_GameScore.AutoSize = true;
            lbl_GameScore.BackColor = Color.Transparent;
            lbl_GameScore.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_GameScore.ForeColor = Color.Snow;
            lbl_GameScore.Location = new Point(391, 707);
            lbl_GameScore.Name = "lbl_GameScore";
            lbl_GameScore.Size = new Size(24, 28);
            lbl_GameScore.TabIndex = 18;
            lbl_GameScore.Text = "0";
            lbl_GameScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pic_nextUp4
            // 
            pic_nextUp4.BackColor = Color.Transparent;
            pic_nextUp4.Location = new Point(613, 291);
            pic_nextUp4.Margin = new Padding(2, 1, 2, 1);
            pic_nextUp4.Name = "pic_nextUp4";
            pic_nextUp4.Size = new Size(184, 79);
            pic_nextUp4.SizeMode = PictureBoxSizeMode.Zoom;
            pic_nextUp4.TabIndex = 19;
            pic_nextUp4.TabStop = false;
            // 
            // lbl_dbgVersionInfo
            // 
            lbl_dbgVersionInfo.AutoSize = true;
            lbl_dbgVersionInfo.Location = new Point(11, 276);
            lbl_dbgVersionInfo.Name = "lbl_dbgVersionInfo";
            lbl_dbgVersionInfo.Size = new Size(113, 15);
            lbl_dbgVersionInfo.TabIndex = 20;
            lbl_dbgVersionInfo.Text = "tetriswf - version 1.0";
            // 
            // lbl_dbgPlayerInfo
            // 
            lbl_dbgPlayerInfo.AutoSize = true;
            lbl_dbgPlayerInfo.Location = new Point(11, 291);
            lbl_dbgPlayerInfo.Name = "lbl_dbgPlayerInfo";
            lbl_dbgPlayerInfo.Size = new Size(63, 15);
            lbl_dbgPlayerInfo.TabIndex = 21;
            lbl_dbgPlayerInfo.Text = "player info";
            // 
            // GameTimer
            // 
            GameTimer.Interval = 1000;
            GameTimer.Tick += GameTimer_Tick;
            // 
            // ExitTimer
            // 
            ExitTimer.Interval = 150;
            ExitTimer.Tick += ExitTimer_Tick;
            // 
            // lbl_exitText1
            // 
            lbl_exitText1.AutoSize = true;
            lbl_exitText1.BackColor = Color.Transparent;
            lbl_exitText1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_exitText1.ForeColor = Color.DarkMagenta;
            lbl_exitText1.Location = new Point(13, 133);
            lbl_exitText1.Name = "lbl_exitText1";
            lbl_exitText1.Size = new Size(61, 260);
            lbl_exitText1.TabIndex = 22;
            lbl_exitText1.Text = "K\r\nE\r\nE\r\nP";
            lbl_exitText1.TextAlign = ContentAlignment.MiddleCenter;
            lbl_exitText1.Visible = false;
            // 
            // tlp_pauseIndicator
            // 
            tlp_pauseIndicator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp_pauseIndicator.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp_pauseIndicator.BackColor = Color.Transparent;
            tlp_pauseIndicator.ColumnCount = 10;
            tlp_pauseIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_pauseIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_pauseIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_pauseIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_pauseIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_pauseIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_pauseIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_pauseIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_pauseIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_pauseIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_pauseIndicator.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tlp_pauseIndicator.Location = new Point(197, 36);
            tlp_pauseIndicator.Margin = new Padding(0);
            tlp_pauseIndicator.Name = "tlp_pauseIndicator";
            tlp_pauseIndicator.RowCount = 17;
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tlp_pauseIndicator.Size = new Size(414, 665);
            tlp_pauseIndicator.TabIndex = 23;
            tlp_pauseIndicator.Visible = false;
            // 
            // lbl_exitText2
            // 
            lbl_exitText2.AutoSize = true;
            lbl_exitText2.BackColor = Color.Transparent;
            lbl_exitText2.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_exitText2.ForeColor = Color.DarkMagenta;
            lbl_exitText2.Location = new Point(80, 133);
            lbl_exitText2.Name = "lbl_exitText2";
            lbl_exitText2.Size = new Size(67, 455);
            lbl_exitText2.TabIndex = 24;
            lbl_exitText2.Text = "H\r\nO\r\nL\r\nD\r\nI\r\nN\r\nG";
            lbl_exitText2.TextAlign = ContentAlignment.MiddleCenter;
            lbl_exitText2.Visible = false;
            // 
            // lbl_exitText3
            // 
            lbl_exitText3.AutoSize = true;
            lbl_exitText3.BackColor = Color.Transparent;
            lbl_exitText3.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_exitText3.ForeColor = Color.DarkMagenta;
            lbl_exitText3.Location = new Point(664, 371);
            lbl_exitText3.Name = "lbl_exitText3";
            lbl_exitText3.Size = new Size(65, 130);
            lbl_exitText3.TabIndex = 25;
            lbl_exitText3.Text = "T\r\nO";
            lbl_exitText3.TextAlign = ContentAlignment.MiddleCenter;
            lbl_exitText3.Visible = false;
            // 
            // lbl_exitText4
            // 
            lbl_exitText4.AutoSize = true;
            lbl_exitText4.BackColor = Color.Transparent;
            lbl_exitText4.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_exitText4.ForeColor = Color.DarkMagenta;
            lbl_exitText4.Location = new Point(735, 371);
            lbl_exitText4.Name = "lbl_exitText4";
            lbl_exitText4.Size = new Size(62, 260);
            lbl_exitText4.TabIndex = 26;
            lbl_exitText4.Text = "E\r\nX\r\nI\r\nT";
            lbl_exitText4.TextAlign = ContentAlignment.MiddleCenter;
            lbl_exitText4.Visible = false;
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.game_background;
            ClientSize = new Size(804, 744);
            ControlBox = false;
            Controls.Add(lbl_exitText4);
            Controls.Add(lbl_exitText3);
            Controls.Add(lbl_exitText2);
            Controls.Add(lbl_exitText1);
            Controls.Add(tlp_pauseIndicator);
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
            Margin = new Padding(2, 1, 2, 1);
            MaximumSize = new Size(820, 783);
            MinimumSize = new Size(820, 504);
            Name = "GameWindow";
            Text = "Blocks · Game in Progress";
            FormClosing += GameWindow_FormClosing;
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
        private Timer ExitTimer;
        private Label lbl_exitText1;
        private TableLayoutPanel tlp_pauseIndicator;
        private Label lbl_exitText2;
        private Label lbl_exitText3;
        private Label lbl_exitText4;
    }
}