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
            this.components = new System.ComponentModel.Container();
            this.lbl_nextUpQueue = new System.Windows.Forms.Label();
            this.lbl_heldBlock = new System.Windows.Forms.Label();
            this.slbl_playingAs = new System.Windows.Forms.Label();
            this.pic_userAvatar = new AS_Coursework.controls.CircularPictureBox();
            this.lbl_currentPlayer = new System.Windows.Forms.Label();
            this.tlp_GameBoard = new System.Windows.Forms.TableLayoutPanel();
            this.pic_hold = new System.Windows.Forms.PictureBox();
            this.pic_nextUp1 = new System.Windows.Forms.PictureBox();
            this.pic_nextUp2 = new System.Windows.Forms.PictureBox();
            this.pic_nextUp3 = new System.Windows.Forms.PictureBox();
            this.lbl_GameScore = new System.Windows.Forms.Label();
            this.pic_nextUp4 = new System.Windows.Forms.PictureBox();
            this.lbl_dbgVersionInfo = new System.Windows.Forms.Label();
            this.lbl_dbgPlayerInfo = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_userAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nextUp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nextUp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nextUp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nextUp4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nextUpQueue
            // 
            this.lbl_nextUpQueue.AutoSize = true;
            this.lbl_nextUpQueue.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nextUpQueue.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nextUpQueue.ForeColor = System.Drawing.Color.Snow;
            this.lbl_nextUpQueue.Location = new System.Drawing.Point(613, 37);
            this.lbl_nextUpQueue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nextUpQueue.Name = "lbl_nextUpQueue";
            this.lbl_nextUpQueue.Size = new System.Drawing.Size(40, 15);
            this.lbl_nextUpQueue.TabIndex = 2;
            this.lbl_nextUpQueue.Text = "NEXT";
            // 
            // lbl_heldBlock
            // 
            this.lbl_heldBlock.AutoSize = true;
            this.lbl_heldBlock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_heldBlock.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_heldBlock.ForeColor = System.Drawing.Color.Snow;
            this.lbl_heldBlock.Location = new System.Drawing.Point(155, 37);
            this.lbl_heldBlock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_heldBlock.Name = "lbl_heldBlock";
            this.lbl_heldBlock.Size = new System.Drawing.Size(41, 15);
            this.lbl_heldBlock.TabIndex = 4;
            this.lbl_heldBlock.Text = "HOLD";
            // 
            // slbl_playingAs
            // 
            this.slbl_playingAs.AutoSize = true;
            this.slbl_playingAs.BackColor = System.Drawing.Color.Transparent;
            this.slbl_playingAs.ForeColor = System.Drawing.Color.Snow;
            this.slbl_playingAs.Location = new System.Drawing.Point(65, 684);
            this.slbl_playingAs.Name = "slbl_playingAs";
            this.slbl_playingAs.Size = new System.Drawing.Size(60, 15);
            this.slbl_playingAs.TabIndex = 11;
            this.slbl_playingAs.Text = "Playing as";
            // 
            // pic_userAvatar
            // 
            this.pic_userAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pic_userAvatar.Location = new System.Drawing.Point(11, 684);
            this.pic_userAvatar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pic_userAvatar.Name = "pic_userAvatar";
            this.pic_userAvatar.Size = new System.Drawing.Size(50, 50);
            this.pic_userAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_userAvatar.TabIndex = 10;
            this.pic_userAvatar.TabStop = false;
            // 
            // lbl_currentPlayer
            // 
            this.lbl_currentPlayer.AutoSize = true;
            this.lbl_currentPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_currentPlayer.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_currentPlayer.ForeColor = System.Drawing.Color.Snow;
            this.lbl_currentPlayer.Location = new System.Drawing.Point(65, 699);
            this.lbl_currentPlayer.Name = "lbl_currentPlayer";
            this.lbl_currentPlayer.Size = new System.Drawing.Size(42, 15);
            this.lbl_currentPlayer.TabIndex = 9;
            this.lbl_currentPlayer.Text = "Guest";
            // 
            // tlp_GameBoard
            // 
            this.tlp_GameBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_GameBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_GameBoard.BackColor = System.Drawing.Color.Transparent;
            this.tlp_GameBoard.ColumnCount = 10;
            this.tlp_GameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_GameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_GameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_GameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_GameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_GameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_GameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_GameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_GameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_GameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_GameBoard.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlp_GameBoard.Location = new System.Drawing.Point(197, 36);
            this.tlp_GameBoard.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_GameBoard.Name = "tlp_GameBoard";
            this.tlp_GameBoard.RowCount = 17;
            this.tlp_GameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlp_GameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlp_GameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlp_GameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlp_GameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlp_GameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlp_GameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlp_GameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlp_GameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlp_GameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlp_GameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlp_GameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlp_GameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlp_GameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlp_GameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlp_GameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlp_GameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlp_GameBoard.Size = new System.Drawing.Size(414, 665);
            this.tlp_GameBoard.TabIndex = 12;
            // 
            // pic_hold
            // 
            this.pic_hold.BackColor = System.Drawing.Color.Transparent;
            this.pic_hold.Location = new System.Drawing.Point(11, 53);
            this.pic_hold.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pic_hold.Name = "pic_hold";
            this.pic_hold.Size = new System.Drawing.Size(184, 79);
            this.pic_hold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_hold.TabIndex = 13;
            this.pic_hold.TabStop = false;
            // 
            // pic_nextUp1
            // 
            this.pic_nextUp1.BackColor = System.Drawing.Color.Transparent;
            this.pic_nextUp1.Location = new System.Drawing.Point(613, 53);
            this.pic_nextUp1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pic_nextUp1.Name = "pic_nextUp1";
            this.pic_nextUp1.Size = new System.Drawing.Size(184, 79);
            this.pic_nextUp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_nextUp1.TabIndex = 15;
            this.pic_nextUp1.TabStop = false;
            // 
            // pic_nextUp2
            // 
            this.pic_nextUp2.BackColor = System.Drawing.Color.Transparent;
            this.pic_nextUp2.Location = new System.Drawing.Point(613, 132);
            this.pic_nextUp2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pic_nextUp2.Name = "pic_nextUp2";
            this.pic_nextUp2.Size = new System.Drawing.Size(184, 79);
            this.pic_nextUp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_nextUp2.TabIndex = 16;
            this.pic_nextUp2.TabStop = false;
            // 
            // pic_nextUp3
            // 
            this.pic_nextUp3.BackColor = System.Drawing.Color.Transparent;
            this.pic_nextUp3.Location = new System.Drawing.Point(613, 211);
            this.pic_nextUp3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pic_nextUp3.Name = "pic_nextUp3";
            this.pic_nextUp3.Size = new System.Drawing.Size(184, 79);
            this.pic_nextUp3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_nextUp3.TabIndex = 17;
            this.pic_nextUp3.TabStop = false;
            // 
            // lbl_GameScore
            // 
            this.lbl_GameScore.AutoSize = true;
            this.lbl_GameScore.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GameScore.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_GameScore.ForeColor = System.Drawing.Color.Snow;
            this.lbl_GameScore.Location = new System.Drawing.Point(391, 707);
            this.lbl_GameScore.Name = "lbl_GameScore";
            this.lbl_GameScore.Size = new System.Drawing.Size(24, 28);
            this.lbl_GameScore.TabIndex = 18;
            this.lbl_GameScore.Text = "0";
            this.lbl_GameScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_nextUp4
            // 
            this.pic_nextUp4.BackColor = System.Drawing.Color.Transparent;
            this.pic_nextUp4.Location = new System.Drawing.Point(613, 291);
            this.pic_nextUp4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pic_nextUp4.Name = "pic_nextUp4";
            this.pic_nextUp4.Size = new System.Drawing.Size(184, 79);
            this.pic_nextUp4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_nextUp4.TabIndex = 19;
            this.pic_nextUp4.TabStop = false;
            // 
            // lbl_dbgVersionInfo
            // 
            this.lbl_dbgVersionInfo.AutoSize = true;
            this.lbl_dbgVersionInfo.Location = new System.Drawing.Point(11, 276);
            this.lbl_dbgVersionInfo.Name = "lbl_dbgVersionInfo";
            this.lbl_dbgVersionInfo.Size = new System.Drawing.Size(113, 15);
            this.lbl_dbgVersionInfo.TabIndex = 20;
            this.lbl_dbgVersionInfo.Text = "tetriswf - version 1.0";
            // 
            // lbl_dbgPlayerInfo
            // 
            this.lbl_dbgPlayerInfo.AutoSize = true;
            this.lbl_dbgPlayerInfo.Location = new System.Drawing.Point(11, 291);
            this.lbl_dbgPlayerInfo.Name = "lbl_dbgPlayerInfo";
            this.lbl_dbgPlayerInfo.Size = new System.Drawing.Size(63, 15);
            this.lbl_dbgPlayerInfo.TabIndex = 21;
            this.lbl_dbgPlayerInfo.Text = "player info";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::AS_Coursework.Properties.Resources.game_background;
            this.ClientSize = new System.Drawing.Size(804, 744);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_dbgVersionInfo);
            this.Controls.Add(this.pic_nextUp4);
            this.Controls.Add(this.lbl_GameScore);
            this.Controls.Add(this.pic_nextUp3);
            this.Controls.Add(this.pic_nextUp2);
            this.Controls.Add(this.pic_nextUp1);
            this.Controls.Add(this.pic_hold);
            this.Controls.Add(this.tlp_GameBoard);
            this.Controls.Add(this.slbl_playingAs);
            this.Controls.Add(this.pic_userAvatar);
            this.Controls.Add(this.lbl_currentPlayer);
            this.Controls.Add(this.lbl_heldBlock);
            this.Controls.Add(this.lbl_nextUpQueue);
            this.Controls.Add(this.lbl_dbgPlayerInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximumSize = new System.Drawing.Size(820, 783);
            this.MinimumSize = new System.Drawing.Size(820, 504);
            this.Name = "GameWindow";
            this.Text = "Blocks · Game in Progress";
            this.VisibleChanged += new System.EventHandler(this.GameWindow_VisibilityChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pic_userAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nextUp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nextUp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nextUp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nextUp4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}