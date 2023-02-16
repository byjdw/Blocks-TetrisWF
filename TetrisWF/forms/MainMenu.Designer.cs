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
            this.lbl_currentPlayer = new System.Windows.Forms.Label();
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.btn_ContinueGame = new System.Windows.Forms.Button();
            this.btn_ExitProgram = new System.Windows.Forms.Button();
            this.pictureBox1 = new AS_Coursework.controls.CircularPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pic_SideBar = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_ChangeUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SideBar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_currentPlayer
            // 
            this.lbl_currentPlayer.AutoSize = true;
            this.lbl_currentPlayer.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_currentPlayer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_currentPlayer.Location = new System.Drawing.Point(76, 306);
            this.lbl_currentPlayer.Name = "lbl_currentPlayer";
            this.lbl_currentPlayer.Size = new System.Drawing.Size(42, 15);
            this.lbl_currentPlayer.TabIndex = 3;
            this.lbl_currentPlayer.Text = "Guest";
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.BackColor = System.Drawing.Color.Lime;
            this.btn_StartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_StartGame.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_StartGame.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_StartGame.Location = new System.Drawing.Point(11, 78);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(110, 38);
            this.btn_StartGame.TabIndex = 4;
            this.btn_StartGame.Text = "START";
            this.btn_StartGame.UseVisualStyleBackColor = false;
            // 
            // btn_ContinueGame
            // 
            this.btn_ContinueGame.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_ContinueGame.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ContinueGame.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ContinueGame.Location = new System.Drawing.Point(11, 122);
            this.btn_ContinueGame.Name = "btn_ContinueGame";
            this.btn_ContinueGame.Size = new System.Drawing.Size(110, 38);
            this.btn_ContinueGame.TabIndex = 5;
            this.btn_ContinueGame.Text = "CONTINUE";
            this.btn_ContinueGame.UseVisualStyleBackColor = false;
            // 
            // btn_ExitProgram
            // 
            this.btn_ExitProgram.BackColor = System.Drawing.Color.Red;
            this.btn_ExitProgram.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ExitProgram.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ExitProgram.Location = new System.Drawing.Point(10, 166);
            this.btn_ExitProgram.Name = "btn_ExitProgram";
            this.btn_ExitProgram.Size = new System.Drawing.Size(110, 39);
            this.btn_ExitProgram.TabIndex = 6;
            this.btn_ExitProgram.Text = "EXIT";
            this.btn_ExitProgram.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::AS_Coursework.Properties.Resources.Guest;
            this.pictureBox1.Location = new System.Drawing.Point(11, 291);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(76, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Logged in as";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::AS_Coursework.Properties.Resources.Blocks;
            this.pictureBox2.Location = new System.Drawing.Point(11, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pic_SideBar
            // 
            this.pic_SideBar.BackColor = System.Drawing.Color.BlueViolet;
            this.pic_SideBar.Location = new System.Drawing.Point(325, 0);
            this.pic_SideBar.Name = "pic_SideBar";
            this.pic_SideBar.Size = new System.Drawing.Size(310, 365);
            this.pic_SideBar.TabIndex = 24;
            this.pic_SideBar.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Exit.Location = new System.Drawing.Point(595, 9);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(30, 30);
            this.btn_Exit.TabIndex = 25;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_ChangeUser
            // 
            this.btn_ChangeUser.Location = new System.Drawing.Point(76, 324);
            this.btn_ChangeUser.Name = "btn_ChangeUser";
            this.btn_ChangeUser.Size = new System.Drawing.Size(86, 23);
            this.btn_ChangeUser.TabIndex = 26;
            this.btn_ChangeUser.Text = "Change User";
            this.btn_ChangeUser.UseVisualStyleBackColor = true;
            this.btn_ChangeUser.Click += new System.EventHandler(this.btn_ChangeUser_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ChangeUser);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.pic_SideBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ExitProgram);
            this.Controls.Add(this.btn_ContinueGame);
            this.Controls.Add(this.btn_StartGame);
            this.Controls.Add(this.lbl_currentPlayer);
            this.Controls.Add(this.pictureBox2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Blocks · Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SideBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_currentPlayer;
        private Button btn_StartGame;
        private Button btn_ContinueGame;
        private Button btn_ExitProgram;
        private CircularPictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private OpenFileDialog openFileDialog1;
        private PictureBox pic_SideBar;
        private Button btn_Exit;
        private Button btn_ChangeUser;
    }
}