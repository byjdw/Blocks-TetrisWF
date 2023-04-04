using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework.forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_LoginUser = new Button();
            lbl_Title = new Label();
            pic_TitleCard = new PictureBox();
            btn_ExitProgram = new Button();
            label1 = new Label();
            label2 = new Label();
            pic_SideBar = new PictureBox();
            btn_Register = new Button();
            btn_Guest = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_TitleCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_SideBar).BeginInit();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Location = new Point(12, 118);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "Username";
            txt_username.Size = new Size(181, 23);
            txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(12, 160);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '·';
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(181, 23);
            txt_password.TabIndex = 2;
            // 
            // btn_LoginUser
            // 
            btn_LoginUser.Location = new Point(12, 189);
            btn_LoginUser.Name = "btn_LoginUser";
            btn_LoginUser.Size = new Size(100, 23);
            btn_LoginUser.TabIndex = 3;
            btn_LoginUser.Text = "Start Playing";
            btn_LoginUser.UseVisualStyleBackColor = true;
            btn_LoginUser.Click += loginUser_onClick;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title.ForeColor = Color.DodgerBlue;
            lbl_Title.Location = new Point(12, 6);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(129, 32);
            lbl_Title.TabIndex = 4;
            lbl_Title.Text = "LOGIN TO";
            // 
            // pic_TitleCard
            // 
            pic_TitleCard.BackgroundImageLayout = ImageLayout.None;
            pic_TitleCard.Image = Properties.Resources.Blocks;
            pic_TitleCard.Location = new Point(12, 23);
            pic_TitleCard.Name = "pic_TitleCard";
            pic_TitleCard.Size = new Size(226, 95);
            pic_TitleCard.SizeMode = PictureBoxSizeMode.Zoom;
            pic_TitleCard.TabIndex = 5;
            pic_TitleCard.TabStop = false;
            // 
            // btn_ExitProgram
            // 
            btn_ExitProgram.BackColor = Color.IndianRed;
            btn_ExitProgram.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ExitProgram.ForeColor = SystemColors.Window;
            btn_ExitProgram.Location = new Point(591, 7);
            btn_ExitProgram.Margin = new Padding(0);
            btn_ExitProgram.Name = "btn_ExitProgram";
            btn_ExitProgram.Size = new Size(27, 23);
            btn_ExitProgram.TabIndex = 7;
            btn_ExitProgram.Text = "X";
            btn_ExitProgram.UseVisualStyleBackColor = false;
            btn_ExitProgram.Click += btn_ExitProgram_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 8;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(12, 142);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // pic_SideBar
            // 
            pic_SideBar.BackColor = Color.FromArgb(23, 23, 23);
            pic_SideBar.Image = Properties.Resources.sidebar_splash;
            pic_SideBar.Location = new Point(327, 0);
            pic_SideBar.Name = "pic_SideBar";
            pic_SideBar.Size = new Size(297, 348);
            pic_SideBar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_SideBar.TabIndex = 10;
            pic_SideBar.TabStop = false;
            // 
            // btn_Register
            // 
            btn_Register.Location = new Point(12, 309);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(75, 23);
            btn_Register.TabIndex = 13;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // btn_Guest
            // 
            btn_Guest.Location = new Point(93, 309);
            btn_Guest.Name = "btn_Guest";
            btn_Guest.Size = new Size(100, 23);
            btn_Guest.TabIndex = 14;
            btn_Guest.Text = "Play as Guest";
            btn_Guest.UseVisualStyleBackColor = true;
            btn_Guest.Click += btn_Guest_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(629, 344);
            ControlBox = false;
            Controls.Add(btn_Guest);
            Controls.Add(btn_Register);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_ExitProgram);
            Controls.Add(lbl_Title);
            Controls.Add(btn_LoginUser);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(pic_TitleCard);
            Controls.Add(pic_SideBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(645, 383);
            MinimumSize = new Size(645, 383);
            Name = "Login";
            Text = "Blocks · Login";
            VisibleChanged += Splash_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)pic_TitleCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_SideBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
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