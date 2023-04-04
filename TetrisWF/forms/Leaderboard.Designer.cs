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
            tlp_Scoreboard = new TableLayoutPanel();
            lbl_Rank10 = new Label();
            lbl_Player10 = new Label();
            lbl_Score10 = new Label();
            lbl_Score9 = new Label();
            lbl_Player9 = new Label();
            lbl_Rank9 = new Label();
            lbl_Score8 = new Label();
            lbl_Player8 = new Label();
            lbl_Rank8 = new Label();
            lbl_Score7 = new Label();
            lbl_Player7 = new Label();
            lbl_Rank7 = new Label();
            lbl_Score6 = new Label();
            lbl_Player6 = new Label();
            lbl_Rank6 = new Label();
            lbl_Score5 = new Label();
            lbl_Player5 = new Label();
            lbl_Rank5 = new Label();
            lbl_Score4 = new Label();
            lbl_Player4 = new Label();
            lbl_Rank4 = new Label();
            lbl_Score3 = new Label();
            lbl_Player3 = new Label();
            lbl_Rank3 = new Label();
            lbl_Score = new Label();
            lbl_Player2 = new Label();
            lbl_Rank2 = new Label();
            lbl_Player1 = new Label();
            lbl_Rank1 = new Label();
            lbl_RankHeader = new Label();
            lbl_PlayerHeader = new Label();
            lbl_ScoreHeader = new Label();
            lbl_Score1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_TitleCard).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_SideBar).BeginInit();
            tlp_Scoreboard.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_HighScore1
            // 
            lbl_HighScore1.AutoSize = true;
            lbl_HighScore1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_HighScore1.ForeColor = System.Drawing.Color.Gold;
            lbl_HighScore1.Location = new System.Drawing.Point(16, 118);
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
            pic_SideBar.BackgroundImage = Properties.Resources.sidebar_scoreboard;
            pic_SideBar.Location = new System.Drawing.Point(2, -2);
            pic_SideBar.Name = "pic_SideBar";
            pic_SideBar.Size = new System.Drawing.Size(300, 362);
            pic_SideBar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_SideBar.TabIndex = 35;
            pic_SideBar.TabStop = false;
            // 
            // tlp_Scoreboard
            // 
            tlp_Scoreboard.ColumnCount = 3;
            tlp_Scoreboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.68421F));
            tlp_Scoreboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.7293243F));
            tlp_Scoreboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.5864677F));
            tlp_Scoreboard.Controls.Add(lbl_Rank10, 0, 10);
            tlp_Scoreboard.Controls.Add(lbl_Player10, 0, 10);
            tlp_Scoreboard.Controls.Add(lbl_Score10, 0, 10);
            tlp_Scoreboard.Controls.Add(lbl_Score9, 2, 9);
            tlp_Scoreboard.Controls.Add(lbl_Player9, 1, 9);
            tlp_Scoreboard.Controls.Add(lbl_Rank9, 0, 9);
            tlp_Scoreboard.Controls.Add(lbl_Score8, 2, 8);
            tlp_Scoreboard.Controls.Add(lbl_Player8, 1, 8);
            tlp_Scoreboard.Controls.Add(lbl_Rank8, 0, 8);
            tlp_Scoreboard.Controls.Add(lbl_Score7, 2, 7);
            tlp_Scoreboard.Controls.Add(lbl_Player7, 1, 7);
            tlp_Scoreboard.Controls.Add(lbl_Rank7, 0, 7);
            tlp_Scoreboard.Controls.Add(lbl_Score6, 2, 6);
            tlp_Scoreboard.Controls.Add(lbl_Player6, 1, 6);
            tlp_Scoreboard.Controls.Add(lbl_Rank6, 0, 6);
            tlp_Scoreboard.Controls.Add(lbl_Score5, 2, 5);
            tlp_Scoreboard.Controls.Add(lbl_Player5, 1, 5);
            tlp_Scoreboard.Controls.Add(lbl_Rank5, 0, 5);
            tlp_Scoreboard.Controls.Add(lbl_Score4, 2, 4);
            tlp_Scoreboard.Controls.Add(lbl_Player4, 1, 4);
            tlp_Scoreboard.Controls.Add(lbl_Rank4, 0, 4);
            tlp_Scoreboard.Controls.Add(lbl_Score3, 2, 3);
            tlp_Scoreboard.Controls.Add(lbl_Player3, 1, 3);
            tlp_Scoreboard.Controls.Add(lbl_Rank3, 0, 3);
            tlp_Scoreboard.Controls.Add(lbl_Score, 2, 2);
            tlp_Scoreboard.Controls.Add(lbl_Player2, 1, 2);
            tlp_Scoreboard.Controls.Add(lbl_Rank2, 0, 2);
            tlp_Scoreboard.Controls.Add(lbl_Player1, 1, 1);
            tlp_Scoreboard.Controls.Add(lbl_Rank1, 0, 1);
            tlp_Scoreboard.Controls.Add(lbl_RankHeader, 0, 0);
            tlp_Scoreboard.Controls.Add(lbl_PlayerHeader, 1, 0);
            tlp_Scoreboard.Controls.Add(lbl_ScoreHeader, 2, 0);
            tlp_Scoreboard.Controls.Add(lbl_Score1, 2, 1);
            tlp_Scoreboard.Location = new System.Drawing.Point(12, 96);
            tlp_Scoreboard.Name = "tlp_Scoreboard";
            tlp_Scoreboard.RowCount = 11;
            tlp_Scoreboard.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlp_Scoreboard.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlp_Scoreboard.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlp_Scoreboard.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlp_Scoreboard.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlp_Scoreboard.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlp_Scoreboard.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlp_Scoreboard.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlp_Scoreboard.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlp_Scoreboard.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlp_Scoreboard.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlp_Scoreboard.Size = new System.Drawing.Size(311, 222);
            tlp_Scoreboard.TabIndex = 40;
            // 
            // lbl_Rank10
            // 
            lbl_Rank10.AutoSize = true;
            lbl_Rank10.Dock = DockStyle.Fill;
            lbl_Rank10.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbl_Rank10.Location = new System.Drawing.Point(3, 200);
            lbl_Rank10.Name = "lbl_Rank10";
            lbl_Rank10.Size = new System.Drawing.Size(67, 22);
            lbl_Rank10.TabIndex = 32;
            lbl_Rank10.Text = "10.";
            lbl_Rank10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Player10
            // 
            lbl_Player10.AutoSize = true;
            lbl_Player10.Dock = DockStyle.Fill;
            lbl_Player10.Location = new System.Drawing.Point(76, 200);
            lbl_Player10.Name = "lbl_Player10";
            lbl_Player10.Size = new System.Drawing.Size(123, 22);
            lbl_Player10.TabIndex = 31;
            lbl_Player10.Text = "[Player]";
            lbl_Player10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Score10
            // 
            lbl_Score10.AutoSize = true;
            lbl_Score10.Dock = DockStyle.Fill;
            lbl_Score10.Location = new System.Drawing.Point(205, 200);
            lbl_Score10.Name = "lbl_Score10";
            lbl_Score10.Size = new System.Drawing.Size(103, 22);
            lbl_Score10.TabIndex = 30;
            lbl_Score10.Text = "[SCORE]";
            lbl_Score10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Score9
            // 
            lbl_Score9.AutoSize = true;
            lbl_Score9.Dock = DockStyle.Fill;
            lbl_Score9.Location = new System.Drawing.Point(205, 180);
            lbl_Score9.Name = "lbl_Score9";
            lbl_Score9.Size = new System.Drawing.Size(103, 20);
            lbl_Score9.TabIndex = 29;
            lbl_Score9.Text = "[SCORE]";
            lbl_Score9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Player9
            // 
            lbl_Player9.AutoSize = true;
            lbl_Player9.Dock = DockStyle.Fill;
            lbl_Player9.Location = new System.Drawing.Point(76, 180);
            lbl_Player9.Name = "lbl_Player9";
            lbl_Player9.Size = new System.Drawing.Size(123, 20);
            lbl_Player9.TabIndex = 28;
            lbl_Player9.Text = "[Player]";
            lbl_Player9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Rank9
            // 
            lbl_Rank9.AutoSize = true;
            lbl_Rank9.Dock = DockStyle.Fill;
            lbl_Rank9.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbl_Rank9.Location = new System.Drawing.Point(3, 180);
            lbl_Rank9.Name = "lbl_Rank9";
            lbl_Rank9.Size = new System.Drawing.Size(67, 20);
            lbl_Rank9.TabIndex = 27;
            lbl_Rank9.Text = "9.";
            lbl_Rank9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Score8
            // 
            lbl_Score8.AutoSize = true;
            lbl_Score8.Dock = DockStyle.Fill;
            lbl_Score8.Location = new System.Drawing.Point(205, 160);
            lbl_Score8.Name = "lbl_Score8";
            lbl_Score8.Size = new System.Drawing.Size(103, 20);
            lbl_Score8.TabIndex = 26;
            lbl_Score8.Text = "[SCORE]";
            lbl_Score8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Player8
            // 
            lbl_Player8.AutoSize = true;
            lbl_Player8.Dock = DockStyle.Fill;
            lbl_Player8.Location = new System.Drawing.Point(76, 160);
            lbl_Player8.Name = "lbl_Player8";
            lbl_Player8.Size = new System.Drawing.Size(123, 20);
            lbl_Player8.TabIndex = 25;
            lbl_Player8.Text = "[Player]";
            lbl_Player8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Rank8
            // 
            lbl_Rank8.AutoSize = true;
            lbl_Rank8.Dock = DockStyle.Fill;
            lbl_Rank8.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbl_Rank8.Location = new System.Drawing.Point(3, 160);
            lbl_Rank8.Name = "lbl_Rank8";
            lbl_Rank8.Size = new System.Drawing.Size(67, 20);
            lbl_Rank8.TabIndex = 24;
            lbl_Rank8.Text = "8.";
            lbl_Rank8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Score7
            // 
            lbl_Score7.AutoSize = true;
            lbl_Score7.Dock = DockStyle.Fill;
            lbl_Score7.Location = new System.Drawing.Point(205, 140);
            lbl_Score7.Name = "lbl_Score7";
            lbl_Score7.Size = new System.Drawing.Size(103, 20);
            lbl_Score7.TabIndex = 23;
            lbl_Score7.Text = "[SCORE]";
            lbl_Score7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Player7
            // 
            lbl_Player7.AutoSize = true;
            lbl_Player7.Dock = DockStyle.Fill;
            lbl_Player7.Location = new System.Drawing.Point(76, 140);
            lbl_Player7.Name = "lbl_Player7";
            lbl_Player7.Size = new System.Drawing.Size(123, 20);
            lbl_Player7.TabIndex = 22;
            lbl_Player7.Text = "[Player]";
            lbl_Player7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Rank7
            // 
            lbl_Rank7.AutoSize = true;
            lbl_Rank7.Dock = DockStyle.Fill;
            lbl_Rank7.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbl_Rank7.Location = new System.Drawing.Point(3, 140);
            lbl_Rank7.Name = "lbl_Rank7";
            lbl_Rank7.Size = new System.Drawing.Size(67, 20);
            lbl_Rank7.TabIndex = 21;
            lbl_Rank7.Text = "7.";
            lbl_Rank7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Score6
            // 
            lbl_Score6.AutoSize = true;
            lbl_Score6.Dock = DockStyle.Fill;
            lbl_Score6.Location = new System.Drawing.Point(205, 120);
            lbl_Score6.Name = "lbl_Score6";
            lbl_Score6.Size = new System.Drawing.Size(103, 20);
            lbl_Score6.TabIndex = 20;
            lbl_Score6.Text = "[SCORE]";
            lbl_Score6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Player6
            // 
            lbl_Player6.AutoSize = true;
            lbl_Player6.Dock = DockStyle.Fill;
            lbl_Player6.Location = new System.Drawing.Point(76, 120);
            lbl_Player6.Name = "lbl_Player6";
            lbl_Player6.Size = new System.Drawing.Size(123, 20);
            lbl_Player6.TabIndex = 19;
            lbl_Player6.Text = "[Player]";
            lbl_Player6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Rank6
            // 
            lbl_Rank6.AutoSize = true;
            lbl_Rank6.Dock = DockStyle.Fill;
            lbl_Rank6.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbl_Rank6.Location = new System.Drawing.Point(3, 120);
            lbl_Rank6.Name = "lbl_Rank6";
            lbl_Rank6.Size = new System.Drawing.Size(67, 20);
            lbl_Rank6.TabIndex = 18;
            lbl_Rank6.Text = "6.";
            lbl_Rank6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Score5
            // 
            lbl_Score5.AutoSize = true;
            lbl_Score5.Dock = DockStyle.Fill;
            lbl_Score5.Location = new System.Drawing.Point(205, 100);
            lbl_Score5.Name = "lbl_Score5";
            lbl_Score5.Size = new System.Drawing.Size(103, 20);
            lbl_Score5.TabIndex = 17;
            lbl_Score5.Text = "[SCORE]";
            lbl_Score5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Player5
            // 
            lbl_Player5.AutoSize = true;
            lbl_Player5.Dock = DockStyle.Fill;
            lbl_Player5.Location = new System.Drawing.Point(76, 100);
            lbl_Player5.Name = "lbl_Player5";
            lbl_Player5.Size = new System.Drawing.Size(123, 20);
            lbl_Player5.TabIndex = 16;
            lbl_Player5.Text = "[Player]";
            lbl_Player5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Rank5
            // 
            lbl_Rank5.AutoSize = true;
            lbl_Rank5.Dock = DockStyle.Fill;
            lbl_Rank5.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbl_Rank5.Location = new System.Drawing.Point(3, 100);
            lbl_Rank5.Name = "lbl_Rank5";
            lbl_Rank5.Size = new System.Drawing.Size(67, 20);
            lbl_Rank5.TabIndex = 15;
            lbl_Rank5.Text = "5.";
            lbl_Rank5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Score4
            // 
            lbl_Score4.AutoSize = true;
            lbl_Score4.Dock = DockStyle.Fill;
            lbl_Score4.Location = new System.Drawing.Point(205, 80);
            lbl_Score4.Name = "lbl_Score4";
            lbl_Score4.Size = new System.Drawing.Size(103, 20);
            lbl_Score4.TabIndex = 14;
            lbl_Score4.Text = "[SCORE]";
            lbl_Score4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Player4
            // 
            lbl_Player4.AutoSize = true;
            lbl_Player4.Dock = DockStyle.Fill;
            lbl_Player4.Location = new System.Drawing.Point(76, 80);
            lbl_Player4.Name = "lbl_Player4";
            lbl_Player4.Size = new System.Drawing.Size(123, 20);
            lbl_Player4.TabIndex = 13;
            lbl_Player4.Text = "[Player]";
            lbl_Player4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Rank4
            // 
            lbl_Rank4.AutoSize = true;
            lbl_Rank4.Dock = DockStyle.Fill;
            lbl_Rank4.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbl_Rank4.Location = new System.Drawing.Point(3, 80);
            lbl_Rank4.Name = "lbl_Rank4";
            lbl_Rank4.Size = new System.Drawing.Size(67, 20);
            lbl_Rank4.TabIndex = 12;
            lbl_Rank4.Text = "4.";
            lbl_Rank4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Score3
            // 
            lbl_Score3.AutoSize = true;
            lbl_Score3.BackColor = System.Drawing.Color.Chocolate;
            lbl_Score3.Dock = DockStyle.Fill;
            lbl_Score3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Score3.ForeColor = System.Drawing.SystemColors.Control;
            lbl_Score3.Location = new System.Drawing.Point(205, 60);
            lbl_Score3.Name = "lbl_Score3";
            lbl_Score3.Size = new System.Drawing.Size(103, 20);
            lbl_Score3.TabIndex = 11;
            lbl_Score3.Text = "[SCORE]";
            lbl_Score3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Player3
            // 
            lbl_Player3.AutoSize = true;
            lbl_Player3.BackColor = System.Drawing.Color.Chocolate;
            lbl_Player3.Dock = DockStyle.Fill;
            lbl_Player3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Player3.ForeColor = System.Drawing.SystemColors.Control;
            lbl_Player3.Location = new System.Drawing.Point(76, 60);
            lbl_Player3.Name = "lbl_Player3";
            lbl_Player3.Size = new System.Drawing.Size(123, 20);
            lbl_Player3.TabIndex = 10;
            lbl_Player3.Text = "[Player]";
            lbl_Player3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Rank3
            // 
            lbl_Rank3.AutoSize = true;
            lbl_Rank3.BackColor = System.Drawing.Color.Chocolate;
            lbl_Rank3.Dock = DockStyle.Fill;
            lbl_Rank3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbl_Rank3.ForeColor = System.Drawing.SystemColors.Control;
            lbl_Rank3.Location = new System.Drawing.Point(3, 60);
            lbl_Rank3.Name = "lbl_Rank3";
            lbl_Rank3.Size = new System.Drawing.Size(67, 20);
            lbl_Rank3.TabIndex = 9;
            lbl_Rank3.Text = "3.";
            lbl_Rank3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Score
            // 
            lbl_Score.AutoSize = true;
            lbl_Score.BackColor = System.Drawing.Color.Silver;
            lbl_Score.Dock = DockStyle.Fill;
            lbl_Score.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Score.ForeColor = System.Drawing.SystemColors.Control;
            lbl_Score.Location = new System.Drawing.Point(205, 40);
            lbl_Score.Name = "lbl_Score";
            lbl_Score.Size = new System.Drawing.Size(103, 20);
            lbl_Score.TabIndex = 8;
            lbl_Score.Text = "[SCORE]";
            lbl_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Player2
            // 
            lbl_Player2.AutoSize = true;
            lbl_Player2.BackColor = System.Drawing.Color.Silver;
            lbl_Player2.Dock = DockStyle.Fill;
            lbl_Player2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Player2.ForeColor = System.Drawing.SystemColors.Control;
            lbl_Player2.Location = new System.Drawing.Point(76, 40);
            lbl_Player2.Name = "lbl_Player2";
            lbl_Player2.Size = new System.Drawing.Size(123, 20);
            lbl_Player2.TabIndex = 7;
            lbl_Player2.Text = "[Player]";
            lbl_Player2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Rank2
            // 
            lbl_Rank2.AutoSize = true;
            lbl_Rank2.BackColor = System.Drawing.Color.Silver;
            lbl_Rank2.Dock = DockStyle.Fill;
            lbl_Rank2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbl_Rank2.ForeColor = System.Drawing.SystemColors.Control;
            lbl_Rank2.Location = new System.Drawing.Point(3, 40);
            lbl_Rank2.Name = "lbl_Rank2";
            lbl_Rank2.Size = new System.Drawing.Size(67, 20);
            lbl_Rank2.TabIndex = 6;
            lbl_Rank2.Text = "2.";
            lbl_Rank2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Player1
            // 
            lbl_Player1.AutoSize = true;
            lbl_Player1.BackColor = System.Drawing.Color.Goldenrod;
            lbl_Player1.Dock = DockStyle.Fill;
            lbl_Player1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Player1.ForeColor = System.Drawing.Color.White;
            lbl_Player1.Location = new System.Drawing.Point(76, 20);
            lbl_Player1.Name = "lbl_Player1";
            lbl_Player1.Size = new System.Drawing.Size(123, 20);
            lbl_Player1.TabIndex = 5;
            lbl_Player1.Text = "[Player]";
            lbl_Player1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Rank1
            // 
            lbl_Rank1.AutoSize = true;
            lbl_Rank1.BackColor = System.Drawing.Color.Goldenrod;
            lbl_Rank1.Dock = DockStyle.Fill;
            lbl_Rank1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbl_Rank1.ForeColor = System.Drawing.SystemColors.Control;
            lbl_Rank1.Location = new System.Drawing.Point(3, 20);
            lbl_Rank1.Name = "lbl_Rank1";
            lbl_Rank1.Size = new System.Drawing.Size(67, 20);
            lbl_Rank1.TabIndex = 4;
            lbl_Rank1.Text = "1.";
            lbl_Rank1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_RankHeader
            // 
            lbl_RankHeader.AutoSize = true;
            lbl_RankHeader.Dock = DockStyle.Fill;
            lbl_RankHeader.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_RankHeader.Location = new System.Drawing.Point(3, 0);
            lbl_RankHeader.Name = "lbl_RankHeader";
            lbl_RankHeader.Size = new System.Drawing.Size(67, 20);
            lbl_RankHeader.TabIndex = 0;
            lbl_RankHeader.Text = "RANK";
            lbl_RankHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PlayerHeader
            // 
            lbl_PlayerHeader.AutoSize = true;
            lbl_PlayerHeader.Dock = DockStyle.Fill;
            lbl_PlayerHeader.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_PlayerHeader.Location = new System.Drawing.Point(76, 0);
            lbl_PlayerHeader.Name = "lbl_PlayerHeader";
            lbl_PlayerHeader.Size = new System.Drawing.Size(123, 20);
            lbl_PlayerHeader.TabIndex = 1;
            lbl_PlayerHeader.Text = "PLAYER";
            lbl_PlayerHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ScoreHeader
            // 
            lbl_ScoreHeader.AutoSize = true;
            lbl_ScoreHeader.Dock = DockStyle.Fill;
            lbl_ScoreHeader.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_ScoreHeader.Location = new System.Drawing.Point(205, 0);
            lbl_ScoreHeader.Name = "lbl_ScoreHeader";
            lbl_ScoreHeader.Size = new System.Drawing.Size(103, 20);
            lbl_ScoreHeader.TabIndex = 2;
            lbl_ScoreHeader.Text = "SCORE";
            lbl_ScoreHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Score1
            // 
            lbl_Score1.AutoSize = true;
            lbl_Score1.BackColor = System.Drawing.Color.Goldenrod;
            lbl_Score1.Dock = DockStyle.Fill;
            lbl_Score1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Score1.ForeColor = System.Drawing.SystemColors.Control;
            lbl_Score1.Location = new System.Drawing.Point(205, 20);
            lbl_Score1.Name = "lbl_Score1";
            lbl_Score1.Size = new System.Drawing.Size(103, 20);
            lbl_Score1.TabIndex = 3;
            lbl_Score1.Text = "[SCORE]";
            lbl_Score1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Leaderboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.AliceBlue;
            ClientSize = new System.Drawing.Size(629, 344);
            ControlBox = false;
            Controls.Add(tlp_Scoreboard);
            Controls.Add(panel1);
            Controls.Add(lbl_Title);
            Controls.Add(pic_TitleCard);
            Controls.Add(lbl_HighScore1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximumSize = new System.Drawing.Size(645, 383);
            MinimumSize = new System.Drawing.Size(645, 383);
            Name = "Leaderboard";
            Text = "Blocks • Scoreboard";
            FormClosing += Leaderboard_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pic_TitleCard).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_SideBar).EndInit();
            tlp_Scoreboard.ResumeLayout(false);
            tlp_Scoreboard.PerformLayout();
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
        private TableLayoutPanel tlp_Scoreboard;
        private Label lbl_RankHeader;
        private Label lbl_Rank10;
        private Label lbl_Player10;
        private Label lbl_Score10;
        private Label lbl_Score9;
        private Label lbl_Player9;
        private Label lbl_Rank9;
        private Label lbl_Score8;
        private Label lbl_Player8;
        private Label lbl_Rank8;
        private Label lbl_Score7;
        private Label lbl_Player7;
        private Label lbl_Rank7;
        private Label lbl_Score6;
        private Label lbl_Player6;
        private Label lbl_Rank6;
        private Label lbl_Score5;
        private Label lbl_Player5;
        private Label lbl_Rank5;
        private Label lbl_Score4;
        private Label lbl_Player4;
        private Label lbl_Rank4;
        private Label lbl_Score3;
        private Label lbl_Player3;
        private Label lbl_Rank3;
        private Label lbl_Score;
        private Label lbl_Player2;
        private Label lbl_Rank2;
        private Label lbl_Player1;
        private Label lbl_Rank1;
        private Label lbl_PlayerHeader;
        private Label lbl_ScoreHeader;
        private Label lbl_Score1;
    }
}