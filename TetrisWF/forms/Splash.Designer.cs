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
            txt_username.Location = new Point(22, 296);
            txt_username.Margin = new Padding(6, 6, 6, 6);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "Username";
            txt_username.Size = new Size(333, 39);
            txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(22, 390);
            txt_password.Margin = new Padding(6, 6, 6, 6);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '·';
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(333, 39);
            txt_password.TabIndex = 2;
            // 
            // btn_LoginUser
            // 
            btn_LoginUser.Location = new Point(22, 452);
            btn_LoginUser.Margin = new Padding(6, 6, 6, 6);
            btn_LoginUser.Name = "btn_LoginUser";
            btn_LoginUser.Size = new Size(186, 49);
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
            lbl_Title.Location = new Point(22, 13);
            lbl_Title.Margin = new Padding(6, 0, 6, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(311, 65);
            lbl_Title.TabIndex = 4;
            lbl_Title.Text = "Welcome to";
            // 
            // pic_TitleCard
            // 
            pic_TitleCard.BackgroundImageLayout = ImageLayout.None;
            pic_TitleCard.Image = Properties.Resources.Blocks;
            pic_TitleCard.Location = new Point(22, 49);
            pic_TitleCard.Margin = new Padding(6, 6, 6, 6);
            pic_TitleCard.Name = "pic_TitleCard";
            pic_TitleCard.Size = new Size(420, 203);
            pic_TitleCard.SizeMode = PictureBoxSizeMode.Zoom;
            pic_TitleCard.TabIndex = 5;
            pic_TitleCard.TabStop = false;
            // 
            // btn_ExitProgram
            // 
            btn_ExitProgram.BackColor = Color.IndianRed;
            btn_ExitProgram.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ExitProgram.ForeColor = SystemColors.Window;
            btn_ExitProgram.Location = new Point(1098, 15);
            btn_ExitProgram.Margin = new Padding(0);
            btn_ExitProgram.Name = "btn_ExitProgram";
            btn_ExitProgram.Size = new Size(50, 50);
            btn_ExitProgram.TabIndex = 7;
            btn_ExitProgram.Text = "X";
            btn_ExitProgram.UseVisualStyleBackColor = false;
            btn_ExitProgram.Click += btn_ExitProgram_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(22, 258);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 8;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(22, 352);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // pic_SideBar
            // 
            pic_SideBar.BackColor = Color.FromArgb(23, 23, 23);
            pic_SideBar.Image = Properties.Resources.sidebar;
            pic_SideBar.Location = new Point(608, -1);
            pic_SideBar.Margin = new Padding(6, 6, 6, 6);
            pic_SideBar.Name = "pic_SideBar";
            pic_SideBar.Size = new Size(551, 743);
            pic_SideBar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_SideBar.TabIndex = 10;
            pic_SideBar.TabStop = false;
            // 
            // btn_Register
            // 
            btn_Register.Location = new Point(22, 635);
            btn_Register.Margin = new Padding(6, 6, 6, 6);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(139, 49);
            btn_Register.TabIndex = 13;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // btn_Guest
            // 
            btn_Guest.Location = new Point(173, 635);
            btn_Guest.Margin = new Padding(6, 6, 6, 6);
            btn_Guest.Name = "btn_Guest";
            btn_Guest.Size = new Size(186, 49);
            btn_Guest.TabIndex = 14;
            btn_Guest.Text = "Play as Guest";
            btn_Guest.UseVisualStyleBackColor = true;
            btn_Guest.Click += btn_Guest_Click;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1159, 702);
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
            Margin = new Padding(6, 6, 6, 6);
            MaximumSize = new Size(1185, 773);
            MinimumSize = new Size(1185, 773);
            Name = "Splash";
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