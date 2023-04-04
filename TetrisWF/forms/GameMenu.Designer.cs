using System.Drawing;
using System.Windows.Forms;
using AS_Coursework.controls;

namespace AS_Coursework.forms
{
    partial class GameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            lbl_currentPlayer = new Label();
            btn_StartGame = new Button();
            btn_ContinueGame = new Button();
            btn_ExitProgram = new Button();
            pic_PlayerAvatar = new CircularPictureBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            pic_SideBar = new PictureBox();
            btn_ChangeUser = new Button();
            btn_OpenLeaderboardForm = new Button();
            btn_OpenStatisticsForm = new Button();
            lbl_Title = new Label();
            pic_TitleCard = new PictureBox();
            circularPictureBox1 = new CircularPictureBox();
            btn_Help = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_PlayerAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_SideBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_TitleCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_currentPlayer
            // 
            lbl_currentPlayer.AutoSize = true;
            lbl_currentPlayer.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_currentPlayer.ForeColor = SystemColors.ControlText;
            lbl_currentPlayer.Location = new Point(84, 287);
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
            btn_StartGame.ForeColor = Color.Snow;
            btn_StartGame.Location = new Point(7, 97);
            btn_StartGame.Name = "btn_StartGame";
            btn_StartGame.Size = new Size(70, 114);
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
            btn_ContinueGame.Location = new Point(81, 97);
            btn_ContinueGame.Name = "btn_ContinueGame";
            btn_ContinueGame.Size = new Size(220, 66);
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
            btn_ExitProgram.Location = new Point(6, 217);
            btn_ExitProgram.Name = "btn_ExitProgram";
            btn_ExitProgram.Size = new Size(295, 39);
            btn_ExitProgram.TabIndex = 6;
            btn_ExitProgram.Text = "EXIT";
            btn_ExitProgram.UseVisualStyleBackColor = false;
            btn_ExitProgram.Click += btn_ExitProgram_Click;
            // 
            // pic_PlayerAvatar
            // 
            pic_PlayerAvatar.BorderStyle = BorderStyle.FixedSingle;
            pic_PlayerAvatar.Image = Properties.Resources.Guest;
            pic_PlayerAvatar.Location = new Point(12, 267);
            pic_PlayerAvatar.Margin = new Padding(2, 1, 2, 1);
            pic_PlayerAvatar.Name = "pic_PlayerAvatar";
            pic_PlayerAvatar.Size = new Size(65, 65);
            pic_PlayerAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_PlayerAvatar.TabIndex = 7;
            pic_PlayerAvatar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(84, 272);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 8;
            label1.Text = "Logged in as";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pic_SideBar
            // 
            pic_SideBar.BackColor = Color.FromArgb(23, 23, 23);
            pic_SideBar.Image = Properties.Resources.sidebar_menu;
            pic_SideBar.Location = new Point(325, 0);
            pic_SideBar.Name = "pic_SideBar";
            pic_SideBar.Size = new Size(300, 362);
            pic_SideBar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_SideBar.TabIndex = 24;
            pic_SideBar.TabStop = false;
            // 
            // btn_ChangeUser
            // 
            btn_ChangeUser.BackColor = SystemColors.Control;
            btn_ChangeUser.Location = new Point(148, 305);
            btn_ChangeUser.Name = "btn_ChangeUser";
            btn_ChangeUser.Size = new Size(90, 24);
            btn_ChangeUser.TabIndex = 26;
            btn_ChangeUser.Text = "Change User";
            btn_ChangeUser.TextAlign = ContentAlignment.TopCenter;
            btn_ChangeUser.UseVisualStyleBackColor = false;
            btn_ChangeUser.Click += btn_ChangeUser_Click;
            // 
            // btn_OpenLeaderboardForm
            // 
            btn_OpenLeaderboardForm.BackColor = Color.DodgerBlue;
            btn_OpenLeaderboardForm.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_OpenLeaderboardForm.ForeColor = Color.Snow;
            btn_OpenLeaderboardForm.Location = new Point(83, 172);
            btn_OpenLeaderboardForm.Name = "btn_OpenLeaderboardForm";
            btn_OpenLeaderboardForm.Size = new Size(220, 39);
            btn_OpenLeaderboardForm.TabIndex = 27;
            btn_OpenLeaderboardForm.Text = "LEADERBOARD";
            btn_OpenLeaderboardForm.UseVisualStyleBackColor = false;
            btn_OpenLeaderboardForm.Click += btn_OpenLeaderboardForm_Click;
            // 
            // btn_OpenStatisticsForm
            // 
            btn_OpenStatisticsForm.BackColor = SystemColors.Control;
            btn_OpenStatisticsForm.Location = new Point(84, 305);
            btn_OpenStatisticsForm.Name = "btn_OpenStatisticsForm";
            btn_OpenStatisticsForm.Size = new Size(25, 24);
            btn_OpenStatisticsForm.TabIndex = 28;
            btn_OpenStatisticsForm.Text = "📊";
            btn_OpenStatisticsForm.UseVisualStyleBackColor = false;
            btn_OpenStatisticsForm.Click += btn_OpenStatisticsForm_Click;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title.ForeColor = Color.Gold;
            lbl_Title.Location = new Point(12, 6);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(175, 32);
            lbl_Title.TabIndex = 30;
            lbl_Title.Text = "WELCOME TO";
            // 
            // pic_TitleCard
            // 
            pic_TitleCard.BackgroundImageLayout = ImageLayout.None;
            pic_TitleCard.Image = Properties.Resources.Blocks;
            pic_TitleCard.Location = new Point(12, 23);
            pic_TitleCard.Name = "pic_TitleCard";
            pic_TitleCard.Size = new Size(226, 95);
            pic_TitleCard.SizeMode = PictureBoxSizeMode.Zoom;
            pic_TitleCard.TabIndex = 31;
            pic_TitleCard.TabStop = false;
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            circularPictureBox1.BorderStyle = BorderStyle.FixedSingle;
            circularPictureBox1.Location = new Point(7, 262);
            circularPictureBox1.Margin = new Padding(2, 1, 2, 1);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new Size(75, 75);
            circularPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            circularPictureBox1.TabIndex = 33;
            circularPictureBox1.TabStop = false;
            // 
            // btn_Help
            // 
            btn_Help.BackColor = SystemColors.Control;
            btn_Help.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Help.ForeColor = SystemColors.ControlText;
            btn_Help.Location = new Point(115, 306);
            btn_Help.Name = "btn_Help";
            btn_Help.Size = new Size(27, 23);
            btn_Help.TabIndex = 34;
            btn_Help.Text = "?";
            btn_Help.UseVisualStyleBackColor = false;
            btn_Help.Click += btn_Help_Click;
            // 
            // GameMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(629, 344);
            ControlBox = false;
            Controls.Add(btn_Help);
            Controls.Add(lbl_Title);
            Controls.Add(btn_OpenStatisticsForm);
            Controls.Add(btn_OpenLeaderboardForm);
            Controls.Add(btn_ChangeUser);
            Controls.Add(pic_SideBar);
            Controls.Add(label1);
            Controls.Add(pic_PlayerAvatar);
            Controls.Add(btn_ExitProgram);
            Controls.Add(btn_ContinueGame);
            Controls.Add(btn_StartGame);
            Controls.Add(lbl_currentPlayer);
            Controls.Add(pic_TitleCard);
            Controls.Add(circularPictureBox1);
            Cursor = Cursors.Hand;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MaximumSize = new Size(645, 383);
            MinimizeBox = false;
            MinimumSize = new Size(645, 383);
            Name = "GameMenu";
            Text = "Blocks · Main Menu";
            FormClosing += GameMenu_FormClosing;
            VisibleChanged += Splash_VisibilityChange;
            ((System.ComponentModel.ISupportInitialize)pic_PlayerAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_SideBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_TitleCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
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
        private OpenFileDialog openFileDialog1;
        private PictureBox pic_SideBar;
        private Button btn_ChangeUser;
        private Button btn_OpenLeaderboardForm;
        private Button btn_OpenStatisticsForm;
        private Label lbl_Title;
        private PictureBox pic_TitleCard;
        private CircularPictureBox circularPictureBox1;
        private Button btn_Help;
    }
}