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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Guest = new System.Windows.Forms.Button();
            this.lbl_usernameError = new System.Windows.Forms.Label();
            this.lbl_passwordError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TitleCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(12, 145);
            this.txt_username.Name = "txt_username";
            this.txt_username.PlaceholderText = "Username";
            this.txt_username.Size = new System.Drawing.Size(181, 23);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(12, 189);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '·';
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.Size = new System.Drawing.Size(181, 23);
            this.txt_password.TabIndex = 2;
            // 
            // btn_LoginUser
            // 
            this.btn_LoginUser.Location = new System.Drawing.Point(12, 218);
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
            this.lbl_Title.Location = new System.Drawing.Point(12, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(154, 32);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "Welcome to";
            // 
            // pic_TitleCard
            // 
            this.pic_TitleCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_TitleCard.Image = global::AS_Coursework.Properties.Resources.Blocks;
            this.pic_TitleCard.Location = new System.Drawing.Point(12, 29);
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
            this.btn_ExitProgram.Location = new System.Drawing.Point(595, 12);
            this.btn_ExitProgram.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ExitProgram.Name = "btn_ExitProgram";
            this.btn_ExitProgram.Size = new System.Drawing.Size(30, 30);
            this.btn_ExitProgram.TabIndex = 7;
            this.btn_ExitProgram.Text = "X";
            this.btn_ExitProgram.UseVisualStyleBackColor = false;
            this.btn_ExitProgram.Click += new System.EventHandler(this.btn_ExitProgram_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.BlueViolet;
            this.pictureBox1.Location = new System.Drawing.Point(325, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 365);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(12, 326);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 23);
            this.btn_Register.TabIndex = 13;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Guest
            // 
            this.btn_Guest.Location = new System.Drawing.Point(93, 326);
            this.btn_Guest.Name = "btn_Guest";
            this.btn_Guest.Size = new System.Drawing.Size(100, 23);
            this.btn_Guest.TabIndex = 14;
            this.btn_Guest.Text = "Play as Guest";
            this.btn_Guest.UseVisualStyleBackColor = true;
            this.btn_Guest.Click += new System.EventHandler(this.btn_Guest_Click);
            // 
            // lbl_usernameError
            // 
            this.lbl_usernameError.AutoSize = true;
            this.lbl_usernameError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_usernameError.Location = new System.Drawing.Point(74, 127);
            this.lbl_usernameError.Name = "lbl_usernameError";
            this.lbl_usernameError.Size = new System.Drawing.Size(87, 15);
            this.lbl_usernameError.TabIndex = 15;
            this.lbl_usernameError.Text = "username error";
            // 
            // lbl_passwordError
            // 
            this.lbl_passwordError.AutoSize = true;
            this.lbl_passwordError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_passwordError.Location = new System.Drawing.Point(74, 171);
            this.lbl_passwordError.Name = "lbl_passwordError";
            this.lbl_passwordError.Size = new System.Drawing.Size(85, 15);
            this.lbl_passwordError.TabIndex = 16;
            this.lbl_passwordError.Text = "password error";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_passwordError);
            this.Controls.Add(this.lbl_usernameError);
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
            this.Controls.Add(this.pictureBox1);
            this.Name = "Splash";
            this.Text = "Blocks · Login";
            ((System.ComponentModel.ISupportInitialize)(this.pic_TitleCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private PictureBox pictureBox1;
        private Button btn_Register;
        private Button btn_Guest;
        private Label lbl_usernameError;
        private Label lbl_passwordError;
    }
}