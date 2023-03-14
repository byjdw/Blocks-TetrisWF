using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework
{
    partial class Splash
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_LoginUser = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pic_TitleCard = new System.Windows.Forms.PictureBox();
            this.btn_ExitProgram = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_SideBar = new System.Windows.Forms.PictureBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Guest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TitleCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SideBar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(12, 139);
            this.txt_username.Name = "txt_username";
            this.txt_username.PlaceholderText = "Username";
            this.txt_username.Size = new System.Drawing.Size(181, 23);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(12, 183);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '·';
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.Size = new System.Drawing.Size(181, 23);
            this.txt_password.TabIndex = 2;
            // 
            // btn_LoginUser
            // 
            this.btn_LoginUser.Location = new System.Drawing.Point(12, 212);
            this.btn_LoginUser.Name = "btn_LoginUser";
            this.btn_LoginUser.Size = new System.Drawing.Size(100, 23);
            this.btn_LoginUser.TabIndex = 3;
            this.btn_LoginUser.Text = "Start Playing";
            this.btn_LoginUser.UseVisualStyleBackColor = true;
            this.btn_LoginUser.Click += new System.EventHandler(this.loginUser_onClick);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Title.Location = new System.Drawing.Point(12, 6);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(175, 32);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "WELCOME TO";
            // 
            // pic_TitleCard
            // 
            this.pic_TitleCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_TitleCard.Image = global::AS_Coursework.Properties.Resources.Blocks;
            this.pic_TitleCard.Location = new System.Drawing.Point(12, 23);
            this.pic_TitleCard.Name = "pic_TitleCard";
            this.pic_TitleCard.Size = new System.Drawing.Size(226, 95);
            this.pic_TitleCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_TitleCard.TabIndex = 5;
            this.pic_TitleCard.TabStop = false;
            // 
            // btn_ExitProgram
            // 
            this.btn_ExitProgram.BackColor = System.Drawing.Color.IndianRed;
            this.btn_ExitProgram.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ExitProgram.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ExitProgram.Location = new System.Drawing.Point(591, 7);
            this.btn_ExitProgram.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ExitProgram.Name = "btn_ExitProgram";
            this.btn_ExitProgram.Size = new System.Drawing.Size(27, 23);
            this.btn_ExitProgram.TabIndex = 7;
            this.btn_ExitProgram.Text = "X";
            this.btn_ExitProgram.UseVisualStyleBackColor = false;
            this.btn_ExitProgram.Click += new System.EventHandler(this.btn_ExitProgram_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // pic_SideBar
            // 
            this.pic_SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pic_SideBar.Image = global::AS_Coursework.Properties.Resources.sidebar;
            this.pic_SideBar.Location = new System.Drawing.Point(327, 0);
            this.pic_SideBar.Name = "pic_SideBar";
            this.pic_SideBar.Size = new System.Drawing.Size(297, 348);
            this.pic_SideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_SideBar.TabIndex = 10;
            this.pic_SideBar.TabStop = false;
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(12, 298);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 23);
            this.btn_Register.TabIndex = 13;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Guest
            // 
            this.btn_Guest.Location = new System.Drawing.Point(93, 298);
            this.btn_Guest.Name = "btn_Guest";
            this.btn_Guest.Size = new System.Drawing.Size(100, 23);
            this.btn_Guest.TabIndex = 14;
            this.btn_Guest.Text = "Play as Guest";
            this.btn_Guest.UseVisualStyleBackColor = true;
            this.btn_Guest.Click += new System.EventHandler(this.btn_Guest_Click);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(629, 344);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Guest);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ExitProgram);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_LoginUser);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.pic_TitleCard);
            this.Controls.Add(this.pic_SideBar);
            this.MaximumSize = new System.Drawing.Size(645, 383);
            this.MinimumSize = new System.Drawing.Size(645, 383);
            this.Name = "Splash";
            this.Text = "Blocks · Login";
            this.VisibleChanged += new System.EventHandler(this.Splash_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pic_TitleCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SideBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_LoginUser;
        private Label lbl_Title;
        private PictureBox pic_TitleCard;
        private Button btn_ExitProgram;
        private Label label1;
        private Label label2;
        private PictureBox pic_SideBar;
        private Button btn_Register;
        private Button btn_Guest;
    }
}