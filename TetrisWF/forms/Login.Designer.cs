using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework
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
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_LoginUser = new Button();
            lbl_Title = new Label();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Location = new Point(22, 92);
            txt_username.Margin = new Padding(6);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "Username";
            txt_username.Size = new Size(182, 39);
            txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(219, 92);
            txt_password.Margin = new Padding(6);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(182, 39);
            txt_password.TabIndex = 2;
            // 
            // btn_LoginUser
            // 
            btn_LoginUser.Location = new Point(416, 90);
            btn_LoginUser.Margin = new Padding(6);
            btn_LoginUser.Name = "btn_LoginUser";
            btn_LoginUser.Size = new Size(139, 49);
            btn_LoginUser.TabIndex = 3;
            btn_LoginUser.Text = "Login";
            btn_LoginUser.UseVisualStyleBackColor = true;
            btn_LoginUser.Click += loginUser_onClick;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title.Location = new Point(22, 15);
            lbl_Title.Margin = new Padding(6, 0, 6, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(555, 65);
            lbl_Title.TabIndex = 4;
            lbl_Title.Text = "Login to Your Account";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 158);
            ControlBox = false;
            Controls.Add(lbl_Title);
            Controls.Add(btn_LoginUser);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Margin = new Padding(6);
            Name = "Login";
            Text = "Blocks · Login";
            FormClosing += Window_OnClose;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_LoginUser;
        private Label lbl_Title;
    }
}