﻿namespace AS_Coursework.forms.game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameEnd));
            lbl_score = new System.Windows.Forms.Label();
            pic_SideBar = new System.Windows.Forms.PictureBox();
            lbl_Title = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lbl_PlayerScored = new System.Windows.Forms.Label();
            lbl_HighScore = new System.Windows.Forms.Label();
            lbl_GameStatus = new System.Windows.Forms.Label();
            ReturnTimer = new System.Windows.Forms.Timer(components);
            lbl_ReturnText = new System.Windows.Forms.Label();
            lbl_SecondsRemaining = new System.Windows.Forms.Label();
            btn_Skip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pic_SideBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_score
            // 
            lbl_score.AutoSize = true;
            lbl_score.Font = new System.Drawing.Font("Segoe UI Black", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_score.Location = new System.Drawing.Point(143, 142);
            lbl_score.Name = "lbl_score";
            lbl_score.Size = new System.Drawing.Size(120, 36);
            lbl_score.TabIndex = 0;
            lbl_score.Text = "[SCORE]";
            // 
            // pic_SideBar
            // 
            pic_SideBar.BackColor = System.Drawing.Color.FromArgb(23, 23, 23);
            pic_SideBar.BackgroundImage = Properties.Resources.Ghost;
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
            lbl_Title.ForeColor = System.Drawing.Color.SlateGray;
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
            lbl_PlayerScored.Location = new System.Drawing.Point(12, 146);
            lbl_PlayerScored.Name = "lbl_PlayerScored";
            lbl_PlayerScored.Size = new System.Drawing.Size(134, 30);
            lbl_PlayerScored.TabIndex = 16;
            lbl_PlayerScored.Text = "You scored...";
            // 
            // lbl_HighScore
            // 
            lbl_HighScore.AutoSize = true;
            lbl_HighScore.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_HighScore.Location = new System.Drawing.Point(14, 176);
            lbl_HighScore.Name = "lbl_HighScore";
            lbl_HighScore.Size = new System.Drawing.Size(152, 40);
            lbl_HighScore.TabIndex = 17;
            lbl_HighScore.Text = "High Score: [Score]\r\n\r\n";
            // 
            // lbl_GameStatus
            // 
            lbl_GameStatus.AutoSize = true;
            lbl_GameStatus.Font = new System.Drawing.Font("Segoe UI Black", 25.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_GameStatus.Location = new System.Drawing.Point(9, 100);
            lbl_GameStatus.Name = "lbl_GameStatus";
            lbl_GameStatus.Size = new System.Drawing.Size(201, 46);
            lbl_GameStatus.TabIndex = 18;
            lbl_GameStatus.Text = "WD/BLNT!";
            // 
            // ReturnToMenuTimer
            // 
            ReturnTimer.Interval = 1000;
            ReturnTimer.Tick += ReturnTimer_Tick;
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
            lbl_SecondsRemaining.ForeColor = System.Drawing.Color.SlateGray;
            lbl_SecondsRemaining.Location = new System.Drawing.Point(176, 317);
            lbl_SecondsRemaining.Name = "lbl_SecondsRemaining";
            lbl_SecondsRemaining.Size = new System.Drawing.Size(87, 15);
            lbl_SecondsRemaining.TabIndex = 20;
            lbl_SecondsRemaining.Text = "[s] seconds...";
            // 
            // btn_ExitProgram
            // 
            btn_Skip.BackColor = System.Drawing.Color.IndianRed;
            btn_Skip.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Skip.ForeColor = System.Drawing.SystemColors.Window;
            btn_Skip.Location = new System.Drawing.Point(266, 312);
            btn_Skip.Margin = new System.Windows.Forms.Padding(0);
            btn_Skip.Name = "btn_ExitProgram";
            btn_Skip.Size = new System.Drawing.Size(51, 23);
            btn_Skip.TabIndex = 21;
            btn_Skip.Text = "▶▶";
            btn_Skip.UseVisualStyleBackColor = false;
            btn_Skip.Click += SkipButton_OnClick;
            // 
            // GameEnd
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(629, 341);
            ControlBox = false;
            Controls.Add(btn_Skip);
            Controls.Add(lbl_SecondsRemaining);
            Controls.Add(lbl_ReturnText);
            Controls.Add(lbl_GameStatus);
            Controls.Add(lbl_HighScore);
            Controls.Add(lbl_PlayerScored);
            Controls.Add(lbl_Title);
            Controls.Add(pictureBox1);
            Controls.Add(pic_SideBar);
            Controls.Add(lbl_score);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximumSize = new System.Drawing.Size(645, 380);
            MinimumSize = new System.Drawing.Size(645, 380);
            Name = "GameEnd";
            Text = "Blocks · Game Over";
            FormClosing += Form_OnClosing;
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
        private System.Windows.Forms.Timer ReturnTimer;
        private System.Windows.Forms.Label lbl_ReturnText;
        private System.Windows.Forms.Label lbl_SecondsRemaining;
        private System.Windows.Forms.Button btn_Skip;
    }
}