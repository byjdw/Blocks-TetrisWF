namespace AS_Coursework.forms.game
{
    partial class GameEnd
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
            lbl_score = new System.Windows.Forms.Label();
            pic_SideBar = new System.Windows.Forms.PictureBox();
            lbl_Title = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lbl_PlayerScored = new System.Windows.Forms.Label();
            lbl_HighScore = new System.Windows.Forms.Label();
            lbl_GameStatus = new System.Windows.Forms.Label();
            ReturnToMenuTimer = new System.Windows.Forms.Timer(components);
            lbl_ReturnText = new System.Windows.Forms.Label();
            lbl_SecondsRemaining = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pic_SideBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_score
            // 
            lbl_score.AutoSize = true;
            lbl_score.Font = new System.Drawing.Font("Segoe UI Black", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_score.Location = new System.Drawing.Point(10, 164);
            lbl_score.Name = "lbl_score";
            lbl_score.Size = new System.Drawing.Size(120, 36);
            lbl_score.TabIndex = 0;
            lbl_score.Text = "[SCORE]";
            // 
            // pic_SideBar
            // 
            pic_SideBar.BackColor = System.Drawing.Color.FromArgb(23, 23, 23);
            pic_SideBar.BackgroundImage = Properties.Resources.Board_Z;
            pic_SideBar.Image = Properties.Resources.sidebar_gameover;
            pic_SideBar.Location = new System.Drawing.Point(320, -38);
            pic_SideBar.Name = "pic_SideBar";
            pic_SideBar.Size = new System.Drawing.Size(318, 387);
            pic_SideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pic_SideBar.TabIndex = 13;
            pic_SideBar.TabStop = false;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Title.ForeColor = System.Drawing.Color.Crimson;
            lbl_Title.Location = new System.Drawing.Point(12, 6);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new System.Drawing.Size(157, 32);
            lbl_Title.TabIndex = 14;
            lbl_Title.Text = "GAME OVER";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Blocks;
            pictureBox1.Location = new System.Drawing.Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(226, 95);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lbl_PlayerScored
            // 
            lbl_PlayerScored.AutoSize = true;
            lbl_PlayerScored.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_PlayerScored.Location = new System.Drawing.Point(12, 143);
            lbl_PlayerScored.Name = "lbl_PlayerScored";
            lbl_PlayerScored.Size = new System.Drawing.Size(134, 30);
            lbl_PlayerScored.TabIndex = 16;
            lbl_PlayerScored.Text = "You scored...";
            // 
            // lbl_HighScore
            // 
            lbl_HighScore.AutoSize = true;
            lbl_HighScore.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_HighScore.Location = new System.Drawing.Point(12, 198);
            lbl_HighScore.Name = "lbl_HighScore";
            lbl_HighScore.Size = new System.Drawing.Size(195, 90);
            lbl_HighScore.TabIndex = 17;
            lbl_HighScore.Text = "which is {0} than \r\nyour high score of \r\n{1}.\r\n";
            // 
            // lbl_GameStatus
            // 
            lbl_GameStatus.AutoSize = true;
            lbl_GameStatus.Font = new System.Drawing.Font("Segoe UI Black", 25.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_GameStatus.Location = new System.Drawing.Point(4, 100);
            lbl_GameStatus.Name = "lbl_GameStatus";
            lbl_GameStatus.Size = new System.Drawing.Size(201, 46);
            lbl_GameStatus.TabIndex = 18;
            lbl_GameStatus.Text = "WD/BLNT!";
            // 
            // ReturnToMenuTimer
            // 
            ReturnToMenuTimer.Interval = 1000;
            ReturnToMenuTimer.Tick += ReturnToMenuTimer_Tick;
            // 
            // lbl_ReturnText
            // 
            lbl_ReturnText.AutoSize = true;
            lbl_ReturnText.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_ReturnText.ForeColor = System.Drawing.SystemColors.ControlDark;
            lbl_ReturnText.Location = new System.Drawing.Point(10, 317);
            lbl_ReturnText.Name = "lbl_ReturnText";
            lbl_ReturnText.Size = new System.Drawing.Size(169, 15);
            lbl_ReturnText.TabIndex = 19;
            lbl_ReturnText.Text = "Returning to main menu in";
            // 
            // lbl_SecondsRemaining
            // 
            lbl_SecondsRemaining.AutoSize = true;
            lbl_SecondsRemaining.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_SecondsRemaining.ForeColor = System.Drawing.Color.Crimson;
            lbl_SecondsRemaining.Location = new System.Drawing.Point(176, 317);
            lbl_SecondsRemaining.Name = "lbl_SecondsRemaining";
            lbl_SecondsRemaining.Size = new System.Drawing.Size(87, 15);
            lbl_SecondsRemaining.TabIndex = 20;
            lbl_SecondsRemaining.Text = "[s] seconds...";
            // 
            // GameEnd
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(629, 341);
            ControlBox = false;
            Controls.Add(lbl_SecondsRemaining);
            Controls.Add(lbl_ReturnText);
            Controls.Add(lbl_GameStatus);
            Controls.Add(lbl_HighScore);
            Controls.Add(lbl_PlayerScored);
            Controls.Add(lbl_Title);
            Controls.Add(pictureBox1);
            Controls.Add(pic_SideBar);
            Controls.Add(lbl_score);
            Name = "GameEnd";
            Text = "GameEnd";
            ((System.ComponentModel.ISupportInitialize)pic_SideBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.PictureBox pic_SideBar;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_PlayerScored;
        private System.Windows.Forms.Label lbl_HighScore;
        private System.Windows.Forms.Label lbl_GameStatus;
        private System.Windows.Forms.Timer ReturnToMenuTimer;
        private System.Windows.Forms.Label lbl_ReturnText;
        private System.Windows.Forms.Label lbl_SecondsRemaining;
    }
}