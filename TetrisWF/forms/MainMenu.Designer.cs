using AS_Coursework.controls;
using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_currentPlayer = new Label();
            btn_StartGame = new Button();
            btn_ContinueGame = new Button();
            btn_ExitProgram = new Button();
            pic_PlayerAvatar = new CircularPictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            pic_SideBar = new PictureBox();
            btn_Exit = new Button();
            btn_ChangeUser = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_PlayerAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_SideBar).BeginInit();
            SuspendLayout();
            // 
            // lbl_currentPlayer
            // 
            lbl_currentPlayer.AutoSize = true;
            lbl_currentPlayer.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_currentPlayer.ForeColor = SystemColors.ControlText;
            lbl_currentPlayer.Location = new Point(148, 602);
            lbl_currentPlayer.Margin = new Padding(6, 0, 6, 0);
            lbl_currentPlayer.Name = "lbl_currentPlayer";
            lbl_currentPlayer.Size = new Size(81, 32);
            lbl_currentPlayer.TabIndex = 3;
            lbl_currentPlayer.Text = "Guest";
            // 
            // btn_StartGame
            // 
            btn_StartGame.BackColor = Color.Lime;
            btn_StartGame.BackgroundImageLayout = ImageLayout.Center;
            btn_StartGame.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_StartGame.ForeColor = Color.Snow;
            btn_StartGame.Location = new Point(9, 162);
            btn_StartGame.Margin = new Padding(6, 6, 6, 6);
            btn_StartGame.Name = "btn_StartGame";
            btn_StartGame.Size = new Size(130, 288);
            btn_StartGame.TabIndex = 4;
            btn_StartGame.Text = "START";
            btn_StartGame.UseVisualStyleBackColor = false;
            btn_StartGame.Click += btn_StartGame_Click;
            // 
            // btn_ContinueGame
            // 
            btn_ContinueGame.BackColor = Color.Gold;
            btn_ContinueGame.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ContinueGame.ForeColor = Color.Snow;
            btn_ContinueGame.Location = new Point(151, 162);
            btn_ContinueGame.Margin = new Padding(6, 6, 6, 6);
            btn_ContinueGame.Name = "btn_ContinueGame";
            btn_ContinueGame.Size = new Size(409, 192);
            btn_ContinueGame.TabIndex = 5;
            btn_ContinueGame.Text = "CONTINUE";
            btn_ContinueGame.UseVisualStyleBackColor = false;
            btn_ContinueGame.Click += btn_ContinueGame_Click;
            // 
            // btn_ExitProgram
            // 
            btn_ExitProgram.BackColor = Color.Red;
            btn_ExitProgram.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ExitProgram.ForeColor = Color.Snow;
            btn_ExitProgram.Location = new Point(11, 463);
            btn_ExitProgram.Margin = new Padding(6, 6, 6, 6);
            btn_ExitProgram.Name = "btn_ExitProgram";
            btn_ExitProgram.Size = new Size(548, 83);
            btn_ExitProgram.TabIndex = 6;
            btn_ExitProgram.Text = "EXIT";
            btn_ExitProgram.UseVisualStyleBackColor = false;
            btn_ExitProgram.Click += btn_Exit_Click;
            // 
            // pic_PlayerAvatar
            // 
            pic_PlayerAvatar.Image = Properties.Resources.Guest;
            pic_PlayerAvatar.Location = new Point(13, 566);
            pic_PlayerAvatar.Margin = new Padding(4, 2, 4, 2);
            pic_PlayerAvatar.Name = "pic_PlayerAvatar";
            pic_PlayerAvatar.Size = new Size(125, 125);
            pic_PlayerAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_PlayerAvatar.TabIndex = 7;
            pic_PlayerAvatar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(148, 570);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 8;
            label1.Text = "Logged in as";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Blocks;
            pictureBox2.Location = new Point(9, 15);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(442, 162);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.DoubleClick += pictureBox2_DoubleClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pic_SideBar
            // 
            pic_SideBar.BackColor = Color.FromArgb(23, 23, 23);
            pic_SideBar.Image = Properties.Resources.sidebar_main;
            pic_SideBar.Location = new Point(604, 0);
            pic_SideBar.Margin = new Padding(6, 6, 6, 6);
            pic_SideBar.Name = "pic_SideBar";
            pic_SideBar.Size = new Size(557, 772);
            pic_SideBar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_SideBar.TabIndex = 24;
            pic_SideBar.TabStop = false;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.IndianRed;
            btn_Exit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Exit.ForeColor = SystemColors.Window;
            btn_Exit.Location = new Point(1098, 15);
            btn_Exit.Margin = new Padding(0);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(50, 50);
            btn_Exit.TabIndex = 25;
            btn_Exit.Text = "X";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_ChangeUser
            // 
            btn_ChangeUser.BackColor = SystemColors.Control;
            btn_ChangeUser.Location = new Point(195, 642);
            btn_ChangeUser.Margin = new Padding(6, 6, 6, 6);
            btn_ChangeUser.Name = "btn_ChangeUser";
            btn_ChangeUser.Size = new Size(167, 49);
            btn_ChangeUser.TabIndex = 26;
            btn_ChangeUser.Text = "Change User";
            btn_ChangeUser.TextAlign = ContentAlignment.TopCenter;
            btn_ChangeUser.UseVisualStyleBackColor = false;
            btn_ChangeUser.Click += btn_ChangeUser_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(151, 367);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(409, 83);
            button1.TabIndex = 27;
            button1.Text = "LEADERBOARD";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Location = new Point(148, 640);
            button2.Margin = new Padding(6, 6, 6, 6);
            button2.Name = "button2";
            button2.Size = new Size(46, 51);
            button2.TabIndex = 28;
            button2.Text = "📊";
            button2.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1159, 702);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_ChangeUser);
            Controls.Add(btn_Exit);
            Controls.Add(pic_SideBar);
            Controls.Add(label1);
            Controls.Add(pic_PlayerAvatar);
            Controls.Add(btn_ExitProgram);
            Controls.Add(btn_ContinueGame);
            Controls.Add(btn_StartGame);
            Controls.Add(lbl_currentPlayer);
            Controls.Add(pictureBox2);
            Cursor = Cursors.Hand;
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            MaximumSize = new Size(1185, 773);
            MinimizeBox = false;
            MinimumSize = new Size(1185, 773);
            Name = "MainMenu";
            Text = "Blocks · Main Menu";
            VisibleChanged += Splash_VisibilityChange;
            ((System.ComponentModel.ISupportInitialize)pic_PlayerAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_SideBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_currentPlayer;
        private Button btn_StartGame;
        private Button btn_ContinueGame;
        private Button btn_ExitProgram;
        private CircularPictureBox pic_PlayerAvatar;
        private Label label1;
        private PictureBox pictureBox2;
        private OpenFileDialog openFileDialog1;
        private PictureBox pic_SideBar;
        private Button btn_Exit;
        private Button btn_ChangeUser;
        private Button button1;
        private Button button2;
    }
}