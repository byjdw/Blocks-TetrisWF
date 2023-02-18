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
            this.lbl_nextUpQueue.Location = new System.Drawing.Point(613, 37);
            this.lbl_nextUpQueue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nextUpQueue.Name = "lbl_nextUpQueue";
            this.lbl_nextUpQueue.Size = new System.Drawing.Size(32, 15);
            this.lbl_nextUpQueue.TabIndex = 2;
            this.lbl_nextUpQueue.Text = "Next";
            // 
            // lbl_heldBlock
            // 
            this.lbl_heldBlock.AutoSize = true;
            this.lbl_heldBlock.Location = new System.Drawing.Point(162, 37);
            this.lbl_heldBlock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_heldBlock.Name = "lbl_heldBlock";
            this.lbl_heldBlock.Size = new System.Drawing.Size(33, 15);
            this.lbl_heldBlock.TabIndex = 4;
            this.lbl_heldBlock.Text = "Hold";
            // 
            // slbl_playingAs
            // 
            this.slbl_playingAs.AutoSize = true;
            this.slbl_playingAs.Location = new System.Drawing.Point(65, 701);
            this.slbl_playingAs.Name = "slbl_playingAs";
            this.slbl_playingAs.Size = new System.Drawing.Size(60, 15);
            this.slbl_playingAs.TabIndex = 11;
            this.slbl_playingAs.Text = "Playing as";
            // 
            // pic_userAvatar
            // 
            this.pic_userAvatar.Image = global::AS_Coursework.Properties.Resources.Guest;
            this.pic_userAvatar.Location = new System.Drawing.Point(11, 701);
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
            this.lbl_currentPlayer.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_currentPlayer.Location = new System.Drawing.Point(65, 716);
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
            this.tlp_GameBoard.Size = new System.Drawing.Size(414, 681);
            this.tlp_GameBoard.TabIndex = 12;
            // 
            // pic_hold
            // 
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
            this.pic_nextUp2.Location = new System.Drawing.Point(613, 135);
            this.pic_nextUp2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pic_nextUp2.Name = "pic_nextUp2";
            this.pic_nextUp2.Size = new System.Drawing.Size(184, 79);
            this.pic_nextUp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_nextUp2.TabIndex = 16;
            this.pic_nextUp2.TabStop = false;
            // 
            // pic_nextUp3
            // 
            this.pic_nextUp3.Location = new System.Drawing.Point(613, 217);
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
            this.lbl_GameScore.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_GameScore.Location = new System.Drawing.Point(386, 726);
            this.lbl_GameScore.Name = "lbl_GameScore";
            this.lbl_GameScore.Size = new System.Drawing.Size(46, 15);
            this.lbl_GameScore.TabIndex = 18;
            this.lbl_GameScore.Text = "SCORE";
            // 
            // pic_nextUp4
            // 
            this.pic_nextUp4.Location = new System.Drawing.Point(613, 298);
            this.pic_nextUp4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pic_nextUp4.Name = "pic_nextUp4";
            this.pic_nextUp4.Size = new System.Drawing.Size(184, 79);
            this.pic_nextUp4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_nextUp4.TabIndex = 19;
            this.pic_nextUp4.TabStop = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(809, 761);
            this.ControlBox = false;
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
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "GameWindow";
            this.Text = "Blocks · Game in Progress";
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
    }
}