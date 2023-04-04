using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework.forms.game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            lbl_nextUpQueue = new Label();
            slbl_playingAs = new Label();
            lbl_currentPlayer = new Label();
            tlp_GameBoard = new TableLayoutPanel();
            pic_hold = new PictureBox();
            pic_nextUp1 = new PictureBox();
            pic_nextUp2 = new PictureBox();
            pic_nextUp3 = new PictureBox();
            lbl_GameScore = new Label();
            pic_nextUp4 = new PictureBox();
            GameTimer = new Timer(components);
            ExitTimer = new Timer(components);
            lbl_exitText1 = new Label();
            lbl_exitText2 = new Label();
            lbl_exitText3 = new Label();
            lbl_exitText4 = new Label();
            lbl_DebugModeEnabled = new Label();
            pic_BoardBorder = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl_heldBlock = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tlp_pauseIndicator = new TableLayoutPanel();
            pic_PlayerAvatar = new controls.CircularPictureBox();
            circularPictureBox1 = new controls.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_hold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_BoardBorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_PlayerAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_nextUpQueue
            // 
            lbl_nextUpQueue.AutoSize = true;
            lbl_nextUpQueue.BackColor = Color.White;
            lbl_nextUpQueue.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nextUpQueue.ForeColor = Color.Black;
            lbl_nextUpQueue.Location = new Point(649, 38);
            lbl_nextUpQueue.Margin = new Padding(2, 0, 2, 0);
            lbl_nextUpQueue.Name = "lbl_nextUpQueue";
            lbl_nextUpQueue.Size = new Size(40, 15);
            lbl_nextUpQueue.TabIndex = 2;
            lbl_nextUpQueue.Text = "NEXT";
            // 
            // slbl_playingAs
            // 
            slbl_playingAs.AutoSize = true;
            slbl_playingAs.BackColor = Color.Transparent;
            slbl_playingAs.ForeColor = Color.Snow;
            slbl_playingAs.Location = new Point(89, 765);
            slbl_playingAs.Name = "slbl_playingAs";
            slbl_playingAs.Size = new Size(60, 15);
            slbl_playingAs.TabIndex = 11;
            slbl_playingAs.Text = "Playing as";
            // 
            // lbl_currentPlayer
            // 
            lbl_currentPlayer.AutoSize = true;
            lbl_currentPlayer.BackColor = Color.Transparent;
            lbl_currentPlayer.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_currentPlayer.ForeColor = Color.Snow;
            lbl_currentPlayer.Location = new Point(89, 780);
            lbl_currentPlayer.Name = "lbl_currentPlayer";
            lbl_currentPlayer.Size = new Size(42, 15);
            lbl_currentPlayer.TabIndex = 9;
            lbl_currentPlayer.Text = "Guest";
            // 
            // tlp_GameBoard
            // 
            tlp_GameBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp_GameBoard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp_GameBoard.BackColor = Color.Black;
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
            tlp_GameBoard.Location = new Point(233, 35);
            tlp_GameBoard.Margin = new Padding(0);
            tlp_GameBoard.Name = "tlp_GameBoard";
            tlp_GameBoard.RowCount = 20;
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameBoard.Size = new Size(410, 720);
            tlp_GameBoard.TabIndex = 12;
            // 
            // pic_hold
            // 
            pic_hold.BackColor = Color.FromArgb(11, 9, 11);
            pic_hold.Location = new Point(60, 61);
            pic_hold.Margin = new Padding(2, 1, 2, 1);
            pic_hold.Name = "pic_hold";
            pic_hold.Size = new Size(158, 79);
            pic_hold.SizeMode = PictureBoxSizeMode.Zoom;
            pic_hold.TabIndex = 13;
            pic_hold.TabStop = false;
            // 
            // pic_nextUp1
            // 
            pic_nextUp1.BackColor = Color.FromArgb(11, 9, 11);
            pic_nextUp1.Location = new Point(652, 67);
            pic_nextUp1.Margin = new Padding(2, 1, 2, 1);
            pic_nextUp1.Name = "pic_nextUp1";
            pic_nextUp1.Size = new Size(168, 79);
            pic_nextUp1.SizeMode = PictureBoxSizeMode.Zoom;
            pic_nextUp1.TabIndex = 15;
            pic_nextUp1.TabStop = false;
            // 
            // pic_nextUp2
            // 
            pic_nextUp2.BackColor = Color.FromArgb(11, 9, 11);
            pic_nextUp2.Location = new Point(652, 175);
            pic_nextUp2.Margin = new Padding(2, 1, 2, 1);
            pic_nextUp2.Name = "pic_nextUp2";
            pic_nextUp2.Size = new Size(168, 79);
            pic_nextUp2.SizeMode = PictureBoxSizeMode.Zoom;
            pic_nextUp2.TabIndex = 16;
            pic_nextUp2.TabStop = false;
            // 
            // pic_nextUp3
            // 
            pic_nextUp3.BackColor = Color.FromArgb(11, 9, 11);
            pic_nextUp3.Location = new Point(652, 277);
            pic_nextUp3.Margin = new Padding(2, 1, 2, 1);
            pic_nextUp3.Name = "pic_nextUp3";
            pic_nextUp3.Size = new Size(168, 79);
            pic_nextUp3.SizeMode = PictureBoxSizeMode.Zoom;
            pic_nextUp3.TabIndex = 17;
            pic_nextUp3.TabStop = false;
            // 
            // lbl_GameScore
            // 
            lbl_GameScore.AutoSize = true;
            lbl_GameScore.BackColor = Color.Transparent;
            lbl_GameScore.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_GameScore.ForeColor = Color.Snow;
            lbl_GameScore.Location = new Point(233, 763);
            lbl_GameScore.MaximumSize = new Size(410, 47);
            lbl_GameScore.MinimumSize = new Size(410, 47);
            lbl_GameScore.Name = "lbl_GameScore";
            lbl_GameScore.Size = new Size(410, 47);
            lbl_GameScore.TabIndex = 18;
            lbl_GameScore.Text = "0";
            lbl_GameScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pic_nextUp4
            // 
            pic_nextUp4.BackColor = Color.FromArgb(11, 9, 11);
            pic_nextUp4.Location = new Point(652, 380);
            pic_nextUp4.Margin = new Padding(2, 1, 2, 1);
            pic_nextUp4.Name = "pic_nextUp4";
            pic_nextUp4.Size = new Size(168, 79);
            pic_nextUp4.SizeMode = PictureBoxSizeMode.Zoom;
            pic_nextUp4.TabIndex = 19;
            pic_nextUp4.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Interval = 1000;
            GameTimer.Tick += GameTimer_Tick;
            // 
            // ExitTimer
            // 
            ExitTimer.Interval = 250;
            ExitTimer.Tick += ExitTimer_Tick;
            // 
            // lbl_exitText1
            // 
            lbl_exitText1.AutoSize = true;
            lbl_exitText1.BackColor = Color.Lime;
            lbl_exitText1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_exitText1.ForeColor = Color.White;
            lbl_exitText1.Location = new Point(240, 470);
            lbl_exitText1.Name = "lbl_exitText1";
            lbl_exitText1.Size = new Size(144, 65);
            lbl_exitText1.TabIndex = 22;
            lbl_exitText1.Text = "KEEP";
            lbl_exitText1.TextAlign = ContentAlignment.MiddleCenter;
            lbl_exitText1.Visible = false;
            // 
            // lbl_exitText2
            // 
            lbl_exitText2.AutoSize = true;
            lbl_exitText2.BackColor = Color.Gold;
            lbl_exitText2.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_exitText2.ForeColor = Color.White;
            lbl_exitText2.Location = new Point(240, 542);
            lbl_exitText2.Name = "lbl_exitText2";
            lbl_exitText2.Size = new Size(257, 65);
            lbl_exitText2.TabIndex = 24;
            lbl_exitText2.Text = "HOLDING";
            lbl_exitText2.TextAlign = ContentAlignment.MiddleCenter;
            lbl_exitText2.Visible = false;
            // 
            // lbl_exitText3
            // 
            lbl_exitText3.AutoSize = true;
            lbl_exitText3.BackColor = Color.DodgerBlue;
            lbl_exitText3.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_exitText3.ForeColor = Color.White;
            lbl_exitText3.Location = new Point(240, 614);
            lbl_exitText3.Name = "lbl_exitText3";
            lbl_exitText3.Size = new Size(96, 65);
            lbl_exitText3.TabIndex = 25;
            lbl_exitText3.Text = "TO";
            lbl_exitText3.TextAlign = ContentAlignment.MiddleCenter;
            lbl_exitText3.Visible = false;
            // 
            // lbl_exitText4
            // 
            lbl_exitText4.AutoSize = true;
            lbl_exitText4.BackColor = Color.Red;
            lbl_exitText4.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_exitText4.ForeColor = Color.White;
            lbl_exitText4.Location = new Point(240, 685);
            lbl_exitText4.Name = "lbl_exitText4";
            lbl_exitText4.Size = new Size(136, 65);
            lbl_exitText4.TabIndex = 26;
            lbl_exitText4.Text = "EXIT";
            lbl_exitText4.TextAlign = ContentAlignment.MiddleCenter;
            lbl_exitText4.Visible = false;
            // 
            // lbl_DebugModeEnabled
            // 
            lbl_DebugModeEnabled.AutoSize = true;
            lbl_DebugModeEnabled.BackColor = Color.Transparent;
            lbl_DebugModeEnabled.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DebugModeEnabled.ForeColor = Color.IndianRed;
            lbl_DebugModeEnabled.Location = new Point(715, 782);
            lbl_DebugModeEnabled.Name = "lbl_DebugModeEnabled";
            lbl_DebugModeEnabled.Size = new Size(158, 30);
            lbl_DebugModeEnabled.TabIndex = 27;
            lbl_DebugModeEnabled.Text = "DEBUG MODE\r\n";
            lbl_DebugModeEnabled.Visible = false;
            // 
            // pic_BoardBorder
            // 
            pic_BoardBorder.Image = Properties.Resources.board;
            pic_BoardBorder.Location = new Point(228, 35);
            pic_BoardBorder.Name = "pic_BoardBorder";
            pic_BoardBorder.Size = new Size(420, 723);
            pic_BoardBorder.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_BoardBorder.TabIndex = 28;
            pic_BoardBorder.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.hold1;
            pictureBox1.Location = new Point(43, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // lbl_heldBlock
            // 
            lbl_heldBlock.AutoSize = true;
            lbl_heldBlock.BackColor = Color.White;
            lbl_heldBlock.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_heldBlock.ForeColor = Color.Black;
            lbl_heldBlock.Location = new Point(184, 39);
            lbl_heldBlock.Margin = new Padding(2, 0, 2, 0);
            lbl_heldBlock.Name = "lbl_heldBlock";
            lbl_heldBlock.Size = new Size(41, 15);
            lbl_heldBlock.TabIndex = 4;
            lbl_heldBlock.Text = "HOLD";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 20;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.queue;
            pictureBox3.Location = new Point(643, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(190, 440);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.BackColor = Color.Black;
            tableLayoutPanel2.ColumnCount = 10;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 20;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tlp_pauseIndicator
            // 
            tlp_pauseIndicator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp_pauseIndicator.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp_pauseIndicator.BackColor = Color.Black;
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
            tlp_pauseIndicator.Location = new Point(233, 35);
            tlp_pauseIndicator.Margin = new Padding(0);
            tlp_pauseIndicator.Name = "tlp_pauseIndicator";
            tlp_pauseIndicator.RowCount = 20;
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_pauseIndicator.Size = new Size(410, 720);
            tlp_pauseIndicator.TabIndex = 33;
            tlp_pauseIndicator.Visible = false;
            // 
            // pic_PlayerAvatar
            // 
            pic_PlayerAvatar.BorderStyle = BorderStyle.FixedSingle;
            pic_PlayerAvatar.Image = Properties.Resources.Guest;
            pic_PlayerAvatar.Location = new Point(12, 745);
            pic_PlayerAvatar.Name = "pic_PlayerAvatar";
            pic_PlayerAvatar.Size = new Size(65, 65);
            pic_PlayerAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_PlayerAvatar.TabIndex = 48;
            pic_PlayerAvatar.TabStop = false;
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            circularPictureBox1.BorderStyle = BorderStyle.FixedSingle;
            circularPictureBox1.Location = new Point(7, 740);
            circularPictureBox1.Margin = new Padding(2, 1, 2, 1);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new Size(75, 75);
            circularPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            circularPictureBox1.TabIndex = 49;
            circularPictureBox1.TabStop = false;
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.background2;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(885, 822);
            ControlBox = false;
            Controls.Add(pic_PlayerAvatar);
            Controls.Add(circularPictureBox1);
            Controls.Add(lbl_exitText4);
            Controls.Add(lbl_exitText3);
            Controls.Add(lbl_exitText2);
            Controls.Add(lbl_exitText1);
            Controls.Add(tlp_pauseIndicator);
            Controls.Add(lbl_heldBlock);
            Controls.Add(pic_hold);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_DebugModeEnabled);
            Controls.Add(pic_nextUp4);
            Controls.Add(lbl_GameScore);
            Controls.Add(pic_nextUp3);
            Controls.Add(pic_nextUp2);
            Controls.Add(pic_nextUp1);
            Controls.Add(slbl_playingAs);
            Controls.Add(lbl_currentPlayer);
            Controls.Add(lbl_nextUpQueue);
            Controls.Add(tlp_GameBoard);
            Controls.Add(pictureBox3);
            Controls.Add(pic_BoardBorder);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 1, 2, 1);
            Name = "GameWindow";
            Text = "Blocks · Game in Progress";
            FormClosing += GameWindow_FormClosing;
            VisibleChanged += GameWindow_VisibilityChanged;
            KeyDown += GameWindow_KeyDown;
            KeyUp += GameWindow_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pic_hold).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_BoardBorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_PlayerAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_score;
        private Label lbl_nextUpQueue;
        private Label lbl_time;
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
        private Timer GameTimer;
        private Timer ExitTimer;
        private Label lbl_exitText1;
        private Label lbl_exitText2;
        private Label lbl_exitText3;
        private Label lbl_exitText4;
        private Label lbl_DebugModeEnabled;
        private PictureBox pic_BoardBorder;
        private PictureBox pictureBox1;
        private Label lbl_heldBlock;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox3;
        private controls.CircularPictureBox circularPictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tlp_pauseIndicator;
        private controls.CircularPictureBox pic_PlayerAvatar;
    }
}