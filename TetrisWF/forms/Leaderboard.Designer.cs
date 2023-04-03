using System.Windows.Forms;

namespace AS_Coursework.forms
{
    partial class Leaderboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected void Dispose(bool disposing)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaderboard));
            lbl_HighScore1 = new Label();
            lbl_Title = new Label();
            pic_TitleCard = new PictureBox();
            panel1 = new Panel();
            btn_ExitProgram = new Button();
            pic_SideBar = new PictureBox();
            lbl_HighScore2 = new Label();
            lbl_HighScore3 = new Label();
            lbl_HighScoreGeneric = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_TitleCard).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_SideBar).BeginInit();
            SuspendLayout();
            // 
            // lbl_HighScore1
            // 
            lbl_HighScore1.AutoSize = true;
            lbl_HighScore1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_HighScore1.ForeColor = System.Drawing.Color.Gold;
            lbl_HighScore1.Location = new System.Drawing.Point(12, 121);
            lbl_HighScore1.Name = "lbl_HighScore1";
            lbl_HighScore1.Size = new System.Drawing.Size(261, 30);
            lbl_HighScore1.TabIndex = 0;
            lbl_HighScore1.Text = "1. [PLAYER1] - [SCORE1]";
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Title.ForeColor = System.Drawing.Color.DarkOrchid;
            lbl_Title.Location = new System.Drawing.Point(12, 6);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new System.Drawing.Size(177, 32);
            lbl_Title.TabIndex = 32;
            lbl_Title.Text = "SCOREBOARD";
            // 
            // pic_TitleCard
            // 
            pic_TitleCard.BackgroundImageLayout = ImageLayout.None;
            pic_TitleCard.Image = Properties.Resources.Blocks;
            pic_TitleCard.Location = new System.Drawing.Point(12, 23);
            pic_TitleCard.Name = "pic_TitleCard";
            pic_TitleCard.Size = new System.Drawing.Size(226, 95);
            pic_TitleCard.SizeMode = PictureBoxSizeMode.Zoom;
            pic_TitleCard.TabIndex = 33;
            pic_TitleCard.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_ExitProgram);
            panel1.Controls.Add(pic_SideBar);
            panel1.Location = new System.Drawing.Point(329, -3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(305, 350);
            panel1.TabIndex = 36;
            // 
            // btn_ExitProgram
            // 
            btn_ExitProgram.BackColor = System.Drawing.Color.IndianRed;
            btn_ExitProgram.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_ExitProgram.ForeColor = System.Drawing.SystemColors.Window;
            btn_ExitProgram.Location = new System.Drawing.Point(264, 12);
            btn_ExitProgram.Margin = new Padding(0);
            btn_ExitProgram.Name = "btn_ExitProgram";
            btn_ExitProgram.Size = new System.Drawing.Size(27, 23);
            btn_ExitProgram.TabIndex = 37;
            btn_ExitProgram.Text = "X";
            btn_ExitProgram.UseVisualStyleBackColor = false;
            btn_ExitProgram.Click += btn_ExitProgram_Click;
            // 
            // pic_SideBar
            // 
            pic_SideBar.BackColor = System.Drawing.Color.FromArgb(23, 23, 23);
            pic_SideBar.BackgroundImage = Properties.Resources.Board_Reverse_L;
            pic_SideBar.Location = new System.Drawing.Point(2, -2);
            pic_SideBar.Name = "pic_SideBar";
            pic_SideBar.Size = new System.Drawing.Size(300, 362);
            pic_SideBar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_SideBar.TabIndex = 35;
            pic_SideBar.TabStop = false;
            // 
            // lbl_HighScore2
            // 
            lbl_HighScore2.AutoSize = true;
            lbl_HighScore2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_HighScore2.ForeColor = System.Drawing.Color.Silver;
            lbl_HighScore2.Location = new System.Drawing.Point(13, 148);
            lbl_HighScore2.Name = "lbl_HighScore2";
            lbl_HighScore2.Size = new System.Drawing.Size(223, 25);
            lbl_HighScore2.TabIndex = 37;
            lbl_HighScore2.Text = "2. [PLAYER2] -[SCORE2]";
            // 
            // lbl_HighScore3
            // 
            lbl_HighScore3.AutoSize = true;
            lbl_HighScore3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_HighScore3.ForeColor = System.Drawing.Color.Peru;
            lbl_HighScore3.Location = new System.Drawing.Point(16, 173);
            lbl_HighScore3.Name = "lbl_HighScore3";
            lbl_HighScore3.Size = new System.Drawing.Size(186, 21);
            lbl_HighScore3.TabIndex = 38;
            lbl_HighScore3.Text = "3.  [PLAYER3] - [SCORE3]";
            // 
            // lbl_HighScoreGeneric
            // 
            lbl_HighScoreGeneric.AutoSize = true;
            lbl_HighScoreGeneric.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_HighScoreGeneric.Location = new System.Drawing.Point(18, 196);
            lbl_HighScoreGeneric.Name = "lbl_HighScoreGeneric";
            lbl_HighScoreGeneric.Size = new System.Drawing.Size(155, 85);
            lbl_HighScoreGeneric.TabIndex = 39;
            lbl_HighScoreGeneric.Text = "4.   [PLAYER4] - [SCORE4]\r\n5.   [PLAYER5] - [SCORE5]\r\n6.   [PLAYER6] - [SCORE6]\r\n7.   [PLAYER7] - [SCORE7]\r\n8.   [PLAYER8] - [SCORE8]";
            // 
            // Leaderboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.AliceBlue;
            ClientSize = new System.Drawing.Size(629, 344);
            ControlBox = false;
            Controls.Add(lbl_HighScoreGeneric);
            Controls.Add(lbl_HighScore3);
            Controls.Add(lbl_HighScore2);
            Controls.Add(panel1);
            Controls.Add(lbl_Title);
            Controls.Add(pic_TitleCard);
            Controls.Add(lbl_HighScore1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Leaderboard";
            Text = "Blocks • Scoreboard";
            ((System.ComponentModel.ISupportInitialize)pic_TitleCard).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_SideBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_HighScore1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pic_TitleCard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_SideBar;
        private System.Windows.Forms.Button btn_ExitProgram;
        private System.Windows.Forms.Label lbl_HighScore2;
        private System.Windows.Forms.Label lbl_HighScore3;
        private System.Windows.Forms.Label lbl_HighScoreGeneric;
    }
}