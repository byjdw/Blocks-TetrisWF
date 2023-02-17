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
            lbl_currentPlayer.Location = new Point(76, 306);
            lbl_currentPlayer.Name = "lbl_currentPlayer";
            lbl_currentPlayer.Size = new Size(42, 15);
            lbl_currentPlayer.TabIndex = 3;
            lbl_currentPlayer.Text = "Guest";
            // 
            // btn_StartGame
            // 
            btn_StartGame.BackColor = Color.Lime;
            btn_StartGame.BackgroundImageLayout = ImageLayout.Center;
            btn_StartGame.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_StartGame.ForeColor = SystemColors.Window;
            btn_StartGame.Location = new Point(11, 78);
            btn_StartGame.Name = "btn_StartGame";
            btn_StartGame.Size = new Size(110, 38);
            btn_StartGame.TabIndex = 4;
            btn_StartGame.Text = "START";
            btn_StartGame.UseVisualStyleBackColor = false;
            btn_StartGame.Click += btn_StartGame_Click;
            // 
            // btn_ContinueGame
            // 
            btn_ContinueGame.BackColor = Color.BlueViolet;
            btn_ContinueGame.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ContinueGame.ForeColor = SystemColors.Window;
            btn_ContinueGame.Location = new Point(11, 122);
            btn_ContinueGame.Name = "btn_ContinueGame";
            btn_ContinueGame.Size = new Size(110, 38);
            btn_ContinueGame.TabIndex = 5;
            btn_ContinueGame.Text = "CONTINUE";
            btn_ContinueGame.UseVisualStyleBackColor = false;
            // 
            // btn_ExitProgram
            // 
            btn_ExitProgram.BackColor = Color.Red;
            btn_ExitProgram.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ExitProgram.ForeColor = SystemColors.Window;
            btn_ExitProgram.Location = new Point(10, 166);
            btn_ExitProgram.Name = "btn_ExitProgram";
            btn_ExitProgram.Size = new Size(110, 39);
            btn_ExitProgram.TabIndex = 6;
            btn_ExitProgram.Text = "EXIT";
            btn_ExitProgram.UseVisualStyleBackColor = false;
            // 
            // pic_PlayerAvatar
            // 
            pic_PlayerAvatar.Image = Properties.Resources.Guest;
            pic_PlayerAvatar.Location = new Point(11, 291);
            pic_PlayerAvatar.Margin = new Padding(2, 1, 2, 1);
            pic_PlayerAvatar.Name = "pic_PlayerAvatar";
            pic_PlayerAvatar.Size = new Size(60, 60);
            pic_PlayerAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_PlayerAvatar.TabIndex = 7;
            pic_PlayerAvatar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(76, 291);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 8;
            label1.Text = "Logged in as";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Blocks;
            pictureBox2.Location = new Point(11, 9);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(238, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pic_SideBar
            // 
            pic_SideBar.BackColor = Color.BlueViolet;
            pic_SideBar.Location = new Point(325, 0);
            pic_SideBar.Name = "pic_SideBar";
            pic_SideBar.Size = new Size(310, 365);
            pic_SideBar.TabIndex = 24;
            pic_SideBar.TabStop = false;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.IndianRed;
            btn_Exit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Exit.ForeColor = SystemColors.Window;
            btn_Exit.Location = new Point(595, 9);
            btn_Exit.Margin = new Padding(0);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(30, 30);
            btn_Exit.TabIndex = 25;
            btn_Exit.Text = "X";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_ChangeUser
            // 
            btn_ChangeUser.Location = new Point(76, 324);
            btn_ChangeUser.Name = "btn_ChangeUser";
            btn_ChangeUser.Size = new Size(86, 23);
            btn_ChangeUser.TabIndex = 26;
            btn_ChangeUser.Text = "Change User";
            btn_ChangeUser.UseVisualStyleBackColor = true;
            btn_ChangeUser.Click += btn_ChangeUser_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(634, 361);
            ControlBox = false;
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
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
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
    }
}