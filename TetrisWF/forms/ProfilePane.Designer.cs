using System.Windows.Forms;

namespace AS_Coursework.forms
{
    partial class ProfilePane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePane));
            btn_Exit = new Button();
            pic_PlayerAvatar = new controls.CircularPictureBox();
            lbl_name = new Label();
            lbl_username = new Label();
            lbl_HighScoreText = new Label();
            lbl_TotalScoreText = new Label();
            lbl_PRsText = new Label();
            lbl_BlocksPlacedText = new Label();
            lbl_GamesPlayedText = new Label();
            lbl_MovesText = new Label();
            lbl_Moves = new Label();
            lbl_GamesPlayed = new Label();
            lbl_BlocksPlaced = new Label();
            lbl_PRs = new Label();
            lbl_TotalScore = new Label();
            lbl_HighScore = new Label();
            checkedListBox1 = new CheckedListBox();
            circularPictureBox1 = new controls.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_PlayerAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = System.Drawing.Color.IndianRed;
            btn_Exit.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Exit.ForeColor = System.Drawing.SystemColors.Window;
            btn_Exit.Location = new System.Drawing.Point(273, 9);
            btn_Exit.Margin = new Padding(0);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new System.Drawing.Size(27, 23);
            btn_Exit.TabIndex = 30;
            btn_Exit.Text = "X";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // pic_PlayerAvatar
            // 
            pic_PlayerAvatar.BorderStyle = BorderStyle.FixedSingle;
            pic_PlayerAvatar.Image = Properties.Resources.Guest;
            pic_PlayerAvatar.Location = new System.Drawing.Point(12, 9);
            pic_PlayerAvatar.Name = "pic_PlayerAvatar";
            pic_PlayerAvatar.Size = new System.Drawing.Size(65, 65);
            pic_PlayerAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_PlayerAvatar.TabIndex = 31;
            pic_PlayerAvatar.TabStop = false;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_name.Location = new System.Drawing.Point(83, 21);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new System.Drawing.Size(161, 21);
            lbl_name.TabIndex = 32;
            lbl_name.Text = "Forename Surname";
            lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new System.Drawing.Point(84, 41);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new System.Drawing.Size(60, 15);
            lbl_username.TabIndex = 33;
            lbl_username.Text = "Username";
            // 
            // lbl_HighScoreText
            // 
            lbl_HighScoreText.AutoSize = true;
            lbl_HighScoreText.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_HighScoreText.Location = new System.Drawing.Point(17, 85);
            lbl_HighScoreText.Name = "lbl_HighScoreText";
            lbl_HighScoreText.Size = new System.Drawing.Size(72, 15);
            lbl_HighScoreText.TabIndex = 34;
            lbl_HighScoreText.Text = "High Score";
            lbl_HighScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_TotalScoreText
            // 
            lbl_TotalScoreText.AutoSize = true;
            lbl_TotalScoreText.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_TotalScoreText.Location = new System.Drawing.Point(17, 100);
            lbl_TotalScoreText.Name = "lbl_TotalScoreText";
            lbl_TotalScoreText.Size = new System.Drawing.Size(75, 15);
            lbl_TotalScoreText.TabIndex = 35;
            lbl_TotalScoreText.Text = "Total Score";
            lbl_TotalScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PRsText
            // 
            lbl_PRsText.AutoSize = true;
            lbl_PRsText.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_PRsText.Location = new System.Drawing.Point(17, 115);
            lbl_PRsText.Name = "lbl_PRsText";
            lbl_PRsText.Size = new System.Drawing.Size(29, 15);
            lbl_PRsText.TabIndex = 36;
            lbl_PRsText.Text = "PRs";
            lbl_PRsText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_BlocksPlacedText
            // 
            lbl_BlocksPlacedText.AutoSize = true;
            lbl_BlocksPlacedText.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_BlocksPlacedText.Location = new System.Drawing.Point(17, 130);
            lbl_BlocksPlacedText.Name = "lbl_BlocksPlacedText";
            lbl_BlocksPlacedText.Size = new System.Drawing.Size(89, 15);
            lbl_BlocksPlacedText.TabIndex = 37;
            lbl_BlocksPlacedText.Text = "Blocks Placed";
            lbl_BlocksPlacedText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_GamesPlayedText
            // 
            lbl_GamesPlayedText.AutoSize = true;
            lbl_GamesPlayedText.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_GamesPlayedText.Location = new System.Drawing.Point(17, 145);
            lbl_GamesPlayedText.Name = "lbl_GamesPlayedText";
            lbl_GamesPlayedText.Size = new System.Drawing.Size(91, 15);
            lbl_GamesPlayedText.TabIndex = 38;
            lbl_GamesPlayedText.Text = "Games Played";
            lbl_GamesPlayedText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_MovesText
            // 
            lbl_MovesText.AutoSize = true;
            lbl_MovesText.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_MovesText.Location = new System.Drawing.Point(17, 160);
            lbl_MovesText.Name = "lbl_MovesText";
            lbl_MovesText.Size = new System.Drawing.Size(87, 15);
            lbl_MovesText.TabIndex = 39;
            lbl_MovesText.Text = "Lines Cleared";
            lbl_MovesText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Moves
            // 
            lbl_Moves.AutoSize = true;
            lbl_Moves.Location = new System.Drawing.Point(124, 160);
            lbl_Moves.Name = "lbl_Moves";
            lbl_Moves.Size = new System.Drawing.Size(99, 15);
            lbl_Moves.TabIndex = 45;
            lbl_Moves.Text = "{LINES_CLEARED]";
            lbl_Moves.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_GamesPlayed
            // 
            lbl_GamesPlayed.AutoSize = true;
            lbl_GamesPlayed.Location = new System.Drawing.Point(124, 145);
            lbl_GamesPlayed.Name = "lbl_GamesPlayed";
            lbl_GamesPlayed.Size = new System.Drawing.Size(100, 15);
            lbl_GamesPlayed.TabIndex = 44;
            lbl_GamesPlayed.Text = "[GAMES_PLAYED]";
            lbl_GamesPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_BlocksPlaced
            // 
            lbl_BlocksPlaced.AutoSize = true;
            lbl_BlocksPlaced.Location = new System.Drawing.Point(124, 130);
            lbl_BlocksPlaced.Name = "lbl_BlocksPlaced";
            lbl_BlocksPlaced.Size = new System.Drawing.Size(106, 15);
            lbl_BlocksPlaced.TabIndex = 43;
            lbl_BlocksPlaced.Text = "[BLOCKS_PLACED]";
            lbl_BlocksPlaced.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_PRs
            // 
            lbl_PRs.AutoSize = true;
            lbl_PRs.Location = new System.Drawing.Point(124, 115);
            lbl_PRs.Name = "lbl_PRs";
            lbl_PRs.Size = new System.Drawing.Size(35, 15);
            lbl_PRs.TabIndex = 42;
            lbl_PRs.Text = "[PRS]";
            lbl_PRs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_TotalScore
            // 
            lbl_TotalScore.AutoSize = true;
            lbl_TotalScore.Location = new System.Drawing.Point(124, 100);
            lbl_TotalScore.Name = "lbl_TotalScore";
            lbl_TotalScore.Size = new System.Drawing.Size(88, 15);
            lbl_TotalScore.TabIndex = 41;
            lbl_TotalScore.Text = "[TOTAL_SCORE]";
            lbl_TotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_HighScore
            // 
            lbl_HighScore.AutoSize = true;
            lbl_HighScore.Location = new System.Drawing.Point(124, 85);
            lbl_HighScore.Name = "lbl_HighScore";
            lbl_HighScore.Size = new System.Drawing.Size(85, 15);
            lbl_HighScore.TabIndex = 40;
            lbl_HighScore.Text = "[HIGH_SCORE]";
            lbl_HighScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new System.Drawing.Point(34, 343);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new System.Drawing.Size(8, 4);
            checkedListBox1.TabIndex = 46;
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            circularPictureBox1.BorderStyle = BorderStyle.FixedSingle;
            circularPictureBox1.Location = new System.Drawing.Point(7, 4);
            circularPictureBox1.Margin = new Padding(2, 1, 2, 1);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new System.Drawing.Size(75, 75);
            circularPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            circularPictureBox1.TabIndex = 47;
            circularPictureBox1.TabStop = false;
            // 
            // ProfilePane
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(309, 195);
            ControlBox = false;
            Controls.Add(checkedListBox1);
            Controls.Add(lbl_Moves);
            Controls.Add(lbl_GamesPlayed);
            Controls.Add(lbl_BlocksPlaced);
            Controls.Add(lbl_PRs);
            Controls.Add(lbl_TotalScore);
            Controls.Add(lbl_HighScore);
            Controls.Add(lbl_MovesText);
            Controls.Add(lbl_GamesPlayedText);
            Controls.Add(lbl_BlocksPlacedText);
            Controls.Add(lbl_PRsText);
            Controls.Add(lbl_TotalScoreText);
            Controls.Add(lbl_HighScoreText);
            Controls.Add(lbl_username);
            Controls.Add(lbl_name);
            Controls.Add(pic_PlayerAvatar);
            Controls.Add(btn_Exit);
            Controls.Add(circularPictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximumSize = new System.Drawing.Size(325, 234);
            MinimumSize = new System.Drawing.Size(325, 234);
            Name = "ProfilePane";
            Text = "Blocks • Your Profile";
            FormClosing += ProfilePane_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pic_PlayerAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private controls.CircularPictureBox pic_PlayerAvatar;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_HighScoreText;
        private System.Windows.Forms.Label lbl_TotalScoreText;
        private System.Windows.Forms.Label lbl_PRsText;
        private System.Windows.Forms.Label lbl_BlocksPlacedText;
        private System.Windows.Forms.Label lbl_GamesPlayedText;
        private System.Windows.Forms.Label lbl_MovesText;
        private System.Windows.Forms.Label lbl_Moves;
        private System.Windows.Forms.Label lbl_GamesPlayed;
        private System.Windows.Forms.Label lbl_BlocksPlaced;
        private System.Windows.Forms.Label lbl_PRs;
        private System.Windows.Forms.Label lbl_TotalScore;
        private System.Windows.Forms.Label lbl_HighScore;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private controls.CircularPictureBox circularPictureBox1;
    }
}