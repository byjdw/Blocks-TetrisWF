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
            lbl_QueueText = new Label();
            lbl_PlayingAsText = new Label();
            lbl_Player = new Label();
            tlp_GameBoard = new TableLayoutPanel();
            pic_Hold = new PictureBox();
            pic_Queue1 = new PictureBox();
            pic_Queue2 = new PictureBox();
            Pic_Queue3 = new PictureBox();
            lbl_GameScore = new Label();
            pic_nextUp4 = new PictureBox();
            GameTimer = new Timer(components);
            ExitTimer = new Timer(components);
            lbl_IndicatorText1 = new Label();
            lbl_IndicatorText2 = new Label();
            lbl_IndicatorText3 = new Label();
            lbl_IndicatorText4 = new Label();
            lbl_DebugModeEnabled = new Label();
            pic_BoardBorder = new PictureBox();
            pic_HoldBorder = new PictureBox();
            lbl_HoldText = new Label();
            pic_QueueBorder = new PictureBox();
            tlp_GameIndicator = new TableLayoutPanel();
            pic_PlayerAvatar = new controls.CircularPictureBox();
            pic_AvatarBorder = new controls.CircularPictureBox();
            lbl_LinesCleared = new Label();
            lbl_GameSpeed = new Label();
            lbl_Countdown = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_Hold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Queue1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Queue2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Queue3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_BoardBorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_HoldBorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_QueueBorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_PlayerAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_AvatarBorder).BeginInit();
            SuspendLayout();
            // 
            // lbl_QueueText
            // 
            lbl_QueueText.AutoSize = true;
            lbl_QueueText.BackColor = Color.White;
            lbl_QueueText.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_QueueText.ForeColor = Color.Black;
            lbl_QueueText.Location = new Point(649, 38);
            lbl_QueueText.Margin = new Padding(2, 0, 2, 0);
            lbl_QueueText.Name = "lbl_QueueText";
            lbl_QueueText.Size = new Size(40, 15);
            lbl_QueueText.TabIndex = 2;
            lbl_QueueText.Text = "NEXT";
            // 
            // lbl_PlayingAsText
            // 
            lbl_PlayingAsText.AutoSize = true;
            lbl_PlayingAsText.BackColor = Color.Transparent;
            lbl_PlayingAsText.ForeColor = Color.Snow;
            lbl_PlayingAsText.Location = new Point(89, 765);
            lbl_PlayingAsText.Name = "lbl_PlayingAsText";
            lbl_PlayingAsText.Size = new Size(60, 15);
            lbl_PlayingAsText.TabIndex = 11;
            lbl_PlayingAsText.Text = "Playing as";
            // 
            // lbl_Player
            // 
            lbl_Player.AutoSize = true;
            lbl_Player.BackColor = Color.Transparent;
            lbl_Player.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Player.ForeColor = Color.Snow;
            lbl_Player.Location = new Point(89, 780);
            lbl_Player.Name = "lbl_Player";
            lbl_Player.Size = new Size(42, 15);
            lbl_Player.TabIndex = 9;
            lbl_Player.Text = "Guest";
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
            // pic_Hold
            // 
            pic_Hold.BackColor = Color.FromArgb(11, 9, 11);
            pic_Hold.Location = new Point(60, 61);
            pic_Hold.Margin = new Padding(2, 1, 2, 1);
            pic_Hold.Name = "pic_Hold";
            pic_Hold.Size = new Size(158, 79);
            pic_Hold.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Hold.TabIndex = 13;
            pic_Hold.TabStop = false;
            // 
            // pic_nextUp1
            // 
            pic_Queue1.BackColor = Color.FromArgb(11, 9, 11);
            pic_Queue1.Location = new Point(652, 67);
            pic_Queue1.Margin = new Padding(2, 1, 2, 1);
            pic_Queue1.Name = "pic_nextUp1";
            pic_Queue1.Size = new Size(168, 79);
            pic_Queue1.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Queue1.TabIndex = 15;
            pic_Queue1.TabStop = false;
            // 
            // pic_nextUp2
            // 
            pic_Queue2.BackColor = Color.FromArgb(11, 9, 11);
            pic_Queue2.Location = new Point(652, 175);
            pic_Queue2.Margin = new Padding(2, 1, 2, 1);
            pic_Queue2.Name = "pic_nextUp2";
            pic_Queue2.Size = new Size(168, 79);
            pic_Queue2.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Queue2.TabIndex = 16;
            pic_Queue2.TabStop = false;
            // 
            // pic_nextUp3
            // 
            Pic_Queue3.BackColor = Color.FromArgb(11, 9, 11);
            Pic_Queue3.Location = new Point(652, 277);
            Pic_Queue3.Margin = new Padding(2, 1, 2, 1);
            Pic_Queue3.Name = "pic_nextUp3";
            Pic_Queue3.Size = new Size(168, 79);
            Pic_Queue3.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_Queue3.TabIndex = 17;
            Pic_Queue3.TabStop = false;
            // 
            // lbl_GameScore
            // 
            lbl_GameScore.AutoSize = true;
            lbl_GameScore.BackColor = Color.Transparent;
            lbl_GameScore.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_GameScore.ForeColor = Color.Snow;
            lbl_GameScore.Location = new Point(233, 771);
            lbl_GameScore.MaximumSize = new Size(410, 32);
            lbl_GameScore.MinimumSize = new Size(410, 32);
            lbl_GameScore.Name = "lbl_GameScore";
            lbl_GameScore.Size = new Size(410, 32);
            lbl_GameScore.TabIndex = 18;
            lbl_GameScore.Text = "0";
            lbl_GameScore.TextAlign = ContentAlignment.TopCenter;
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
            lbl_IndicatorText1.AutoSize = true;
            lbl_IndicatorText1.BackColor = Color.Lime;
            lbl_IndicatorText1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_IndicatorText1.ForeColor = Color.White;
            lbl_IndicatorText1.Location = new Point(240, 539);
            lbl_IndicatorText1.Name = "lbl_exitText1";
            lbl_IndicatorText1.Size = new Size(144, 65);
            lbl_IndicatorText1.TabIndex = 22;
            lbl_IndicatorText1.Text = "KEEP";
            lbl_IndicatorText1.TextAlign = ContentAlignment.MiddleCenter;
            lbl_IndicatorText1.Visible = false;
            // 
            // lbl_exitText2
            // 
            lbl_IndicatorText2.AutoSize = true;
            lbl_IndicatorText2.BackColor = Color.Gold;
            lbl_IndicatorText2.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_IndicatorText2.ForeColor = Color.White;
            lbl_IndicatorText2.Location = new Point(240, 611);
            lbl_IndicatorText2.Name = "lbl_exitText2";
            lbl_IndicatorText2.Size = new Size(257, 65);
            lbl_IndicatorText2.TabIndex = 24;
            lbl_IndicatorText2.Text = "HOLDING";
            lbl_IndicatorText2.TextAlign = ContentAlignment.MiddleCenter;
            lbl_IndicatorText2.Visible = false;
            // 
            // lbl_exitText3
            // 
            lbl_IndicatorText3.AutoSize = true;
            lbl_IndicatorText3.BackColor = Color.DodgerBlue;
            lbl_IndicatorText3.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_IndicatorText3.ForeColor = Color.White;
            lbl_IndicatorText3.Location = new Point(240, 683);
            lbl_IndicatorText3.Name = "lbl_exitText3";
            lbl_IndicatorText3.Size = new Size(96, 65);
            lbl_IndicatorText3.TabIndex = 25;
            lbl_IndicatorText3.Text = "TO";
            lbl_IndicatorText3.TextAlign = ContentAlignment.MiddleCenter;
            lbl_IndicatorText3.Visible = false;
            // 
            // lbl_exitText4
            // 
            lbl_IndicatorText4.AutoSize = true;
            lbl_IndicatorText4.BackColor = Color.Red;
            lbl_IndicatorText4.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_IndicatorText4.ForeColor = Color.White;
            lbl_IndicatorText4.Location = new Point(345, 683);
            lbl_IndicatorText4.Name = "lbl_exitText4";
            lbl_IndicatorText4.Size = new Size(136, 65);
            lbl_IndicatorText4.TabIndex = 26;
            lbl_IndicatorText4.Text = "EXIT";
            lbl_IndicatorText4.TextAlign = ContentAlignment.MiddleCenter;
            lbl_IndicatorText4.Visible = false;
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
            pic_BoardBorder.BackColor = Color.Transparent;
            pic_BoardBorder.Image = Properties.Resources.board;
            pic_BoardBorder.Location = new Point(228, 35);
            pic_BoardBorder.Name = "pic_BoardBorder";
            pic_BoardBorder.Size = new Size(420, 723);
            pic_BoardBorder.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_BoardBorder.TabIndex = 28;
            pic_BoardBorder.TabStop = false;
            // 
            // pic_HoldBorder
            // 
            pic_HoldBorder.BackColor = Color.Transparent;
            pic_HoldBorder.Image = Properties.Resources.hold1;
            pic_HoldBorder.Location = new Point(43, 35);
            pic_HoldBorder.Name = "pic_HoldBorder";
            pic_HoldBorder.Size = new Size(190, 110);
            pic_HoldBorder.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_HoldBorder.TabIndex = 29;
            pic_HoldBorder.TabStop = false;
            // 
            // lbl_HoldText
            // 
            lbl_HoldText.AutoSize = true;
            lbl_HoldText.BackColor = Color.White;
            lbl_HoldText.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_HoldText.ForeColor = Color.Black;
            lbl_HoldText.Location = new Point(184, 39);
            lbl_HoldText.Margin = new Padding(2, 0, 2, 0);
            lbl_HoldText.Name = "lbl_HoldText";
            lbl_HoldText.Size = new Size(41, 15);
            lbl_HoldText.TabIndex = 4;
            lbl_HoldText.Text = "HOLD";
            // 
            // pic_QueueBorder
            // 
            pic_QueueBorder.BackColor = Color.Transparent;
            pic_QueueBorder.Image = Properties.Resources.queue;
            pic_QueueBorder.Location = new Point(643, 35);
            pic_QueueBorder.Name = "pic_QueueBorder";
            pic_QueueBorder.Size = new Size(190, 440);
            pic_QueueBorder.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_QueueBorder.TabIndex = 31;
            pic_QueueBorder.TabStop = false;
            // 
            // tlp_GameIndicator
            // 
            tlp_GameIndicator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp_GameIndicator.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp_GameIndicator.BackColor = Color.Black;
            tlp_GameIndicator.ColumnCount = 10;
            tlp_GameIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameIndicator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_GameIndicator.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tlp_GameIndicator.Location = new Point(233, 35);
            tlp_GameIndicator.Margin = new Padding(0);
            tlp_GameIndicator.Name = "tlp_GameIndicator";
            tlp_GameIndicator.RowCount = 20;
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp_GameIndicator.Size = new Size(410, 720);
            tlp_GameIndicator.TabIndex = 33;
            tlp_GameIndicator.Visible = false;
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
            // pic_AvatarBorder
            // 
            pic_AvatarBorder.BackColor = Color.FromArgb(64, 64, 64);
            pic_AvatarBorder.BorderStyle = BorderStyle.FixedSingle;
            pic_AvatarBorder.Location = new Point(7, 740);
            pic_AvatarBorder.Margin = new Padding(2, 1, 2, 1);
            pic_AvatarBorder.Name = "pic_AvatarBorder";
            pic_AvatarBorder.Size = new Size(75, 75);
            pic_AvatarBorder.SizeMode = PictureBoxSizeMode.Zoom;
            pic_AvatarBorder.TabIndex = 49;
            pic_AvatarBorder.TabStop = false;
            // 
            // lbl_LinesCleared
            // 
            lbl_LinesCleared.AutoSize = true;
            lbl_LinesCleared.BackColor = Color.Transparent;
            lbl_LinesCleared.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_LinesCleared.ForeColor = SystemColors.Control;
            lbl_LinesCleared.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_LinesCleared.Location = new Point(649, 478);
            lbl_LinesCleared.MaximumSize = new Size(205, 35);
            lbl_LinesCleared.MinimumSize = new Size(205, 35);
            lbl_LinesCleared.Name = "lbl_LinesCleared";
            lbl_LinesCleared.Size = new Size(205, 35);
            lbl_LinesCleared.TabIndex = 50;
            lbl_LinesCleared.Text = "[X] Lines Cleared";
            lbl_LinesCleared.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_GameSpeed
            // 
            lbl_GameSpeed.AutoSize = true;
            lbl_GameSpeed.BackColor = Color.Transparent;
            lbl_GameSpeed.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_GameSpeed.ForeColor = SystemColors.Control;
            lbl_GameSpeed.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_GameSpeed.Location = new Point(649, 513);
            lbl_GameSpeed.MaximumSize = new Size(205, 35);
            lbl_GameSpeed.MinimumSize = new Size(205, 35);
            lbl_GameSpeed.Name = "lbl_GameSpeed";
            lbl_GameSpeed.Size = new Size(205, 35);
            lbl_GameSpeed.TabIndex = 51;
            lbl_GameSpeed.Text = "Xx Speed";
            lbl_GameSpeed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Countdown
            // 
            lbl_Countdown.AutoSize = true;
            lbl_Countdown.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Countdown.ForeColor = SystemColors.Control;
            lbl_Countdown.Location = new Point(334, 352);
            lbl_Countdown.MaximumSize = new Size(210, 86);
            lbl_Countdown.MinimumSize = new Size(210, 86);
            lbl_Countdown.Name = "lbl_Countdown";
            lbl_Countdown.Size = new Size(210, 86);
            lbl_Countdown.TabIndex = 53;
            lbl_Countdown.Text = "[GO]!";
            lbl_Countdown.TextAlign = ContentAlignment.MiddleCenter;
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
            Controls.Add(lbl_IndicatorText2);
            Controls.Add(lbl_IndicatorText3);
            Controls.Add(lbl_IndicatorText4);
            Controls.Add(lbl_IndicatorText1);
            Controls.Add(lbl_Countdown);
            Controls.Add(lbl_GameSpeed);
            Controls.Add(lbl_LinesCleared);
            Controls.Add(pic_PlayerAvatar);
            Controls.Add(pic_AvatarBorder);
            Controls.Add(tlp_GameIndicator);
            Controls.Add(lbl_HoldText);
            Controls.Add(pic_Hold);
            Controls.Add(pic_HoldBorder);
            Controls.Add(lbl_DebugModeEnabled);
            Controls.Add(pic_nextUp4);
            Controls.Add(lbl_GameScore);
            Controls.Add(Pic_Queue3);
            Controls.Add(pic_Queue2);
            Controls.Add(pic_Queue1);
            Controls.Add(lbl_PlayingAsText);
            Controls.Add(lbl_Player);
            Controls.Add(lbl_QueueText);
            Controls.Add(tlp_GameBoard);
            Controls.Add(pic_QueueBorder);
            Controls.Add(pic_BoardBorder);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 1, 2, 1);
            Name = "GameWindow";
            Text = "Blocks · Game in Progress";
            FormClosing += Form_OnClosing;
            VisibleChanged += GameWindow_VisibilityChanged;
            KeyDown += GameWindow_KeyDown;
            KeyUp += GameWindow_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pic_Hold).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Queue1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Queue2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Queue3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_nextUp4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_BoardBorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_HoldBorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_QueueBorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_PlayerAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_AvatarBorder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Score;
        private Label lbl_QueueText;
        private PictureBox pic_HeldBlock;
        private PictureBox pic_NextUp;
        private Label lbl_PlayingAsText;
        private controls.CircularPictureBox pic_Avatar;
        private Label lbl_Player;
        private TableLayoutPanel tlp_GameBoard;
        private PictureBox pic_Hold;
        private PictureBox pic_Queue1;
        private PictureBox pic_Queue2;
        private PictureBox Pic_Queue3;
        private Label lbl_GameScore;
        private PictureBox pic_nextUp4;
        private Timer GameTimer;
        private Timer ExitTimer;
        private Label lbl_IndicatorText1;
        private Label lbl_IndicatorText2;
        private Label lbl_IndicatorText3;
        private Label lbl_IndicatorText4;
        private Label lbl_DebugModeEnabled;
        private PictureBox pic_BoardBorder;
        private PictureBox pic_HoldBorder;
        private Label lbl_HoldText;
        private PictureBox pic_QueueBorder;
        private controls.CircularPictureBox pic_AvatarBorder;
        private TableLayoutPanel tlp_GameIndicator;
        private controls.CircularPictureBox pic_PlayerAvatar;
        private Label lbl_LinesCleared;
        private Label lbl_GameSpeed;
        private Label lbl_Countdown;
    }
}