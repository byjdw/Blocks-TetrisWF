using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework
{
    partial class Registration
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
            txt_forename = new TextBox();
            txt_surname = new TextBox();
            txt_username = new TextBox();
            txt_password = new TextBox();
            txt_passwordConfirm = new TextBox();
            btn_registerPlayer = new Button();
            lbl_Title = new Label();
            lbl_forenameError = new Label();
            lbl_surnameError = new Label();
            lbl_usernameError = new Label();
            lbl_passwordError = new Label();
            lbl_passwordConfirmError = new Label();
            circularPictureBox1 = new controls.CircularPictureBox();
            openFileDialog1 = new OpenFileDialog();
            btn_pickImage = new Button();
            button1 = new Button();
            btn_CycleAvatarBack = new Button();
            btn_CycleAvatarForward = new Button();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_forename
            // 
            txt_forename.Location = new Point(45, 105);
            txt_forename.Margin = new Padding(6);
            txt_forename.Name = "txt_forename";
            txt_forename.PlaceholderText = "Forename";
            txt_forename.Size = new Size(257, 39);
            txt_forename.TabIndex = 5;
            txt_forename.TextChanged += Forename_ValueChanged;
            // 
            // txt_surname
            // 
            txt_surname.Location = new Point(45, 167);
            txt_surname.Margin = new Padding(6);
            txt_surname.Name = "txt_surname";
            txt_surname.PlaceholderText = "Surname";
            txt_surname.Size = new Size(257, 39);
            txt_surname.TabIndex = 6;
            txt_surname.TextChanged += Surname_ValueChanged;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(45, 218);
            txt_username.Margin = new Padding(6);
            txt_username.MaxLength = 16;
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "Username";
            txt_username.Size = new Size(257, 39);
            txt_username.TabIndex = 7;
            txt_username.TextChanged += Username_ValueChanged;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(45, 279);
            txt_password.Margin = new Padding(6);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(257, 39);
            txt_password.TabIndex = 8;
            txt_password.TextChanged += Password_ValueChanged;
            // 
            // txt_passwordConfirm
            // 
            txt_passwordConfirm.Location = new Point(45, 341);
            txt_passwordConfirm.Margin = new Padding(6);
            txt_passwordConfirm.Name = "txt_passwordConfirm";
            txt_passwordConfirm.PasswordChar = '*';
            txt_passwordConfirm.PlaceholderText = "Confirm Password";
            txt_passwordConfirm.Size = new Size(257, 39);
            txt_passwordConfirm.TabIndex = 9;
            txt_passwordConfirm.TextChanged += PasswordConfirm_ValueChanged;
            // 
            // btn_registerPlayer
            // 
            btn_registerPlayer.Location = new Point(438, 729);
            btn_registerPlayer.Margin = new Padding(6);
            btn_registerPlayer.Name = "btn_registerPlayer";
            btn_registerPlayer.Size = new Size(139, 49);
            btn_registerPlayer.TabIndex = 10;
            btn_registerPlayer.Text = "Register";
            btn_registerPlayer.UseVisualStyleBackColor = true;
            btn_registerPlayer.Click += registerPlayer_onClick;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title.Location = new Point(22, 19);
            lbl_Title.Margin = new Padding(6, 0, 6, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(592, 65);
            lbl_Title.TabIndex = 11;
            lbl_Title.Text = "Register a New Account";
            // 
            // lbl_forenameError
            // 
            lbl_forenameError.AutoSize = true;
            lbl_forenameError.ForeColor = Color.Crimson;
            lbl_forenameError.Location = new Point(722, 101);
            lbl_forenameError.Margin = new Padding(6, 0, 6, 0);
            lbl_forenameError.Name = "lbl_forenameError";
            lbl_forenameError.Size = new Size(178, 32);
            lbl_forenameError.TabIndex = 12;
            lbl_forenameError.Text = "Forename Error";
            // 
            // lbl_surnameError
            // 
            lbl_surnameError.AutoSize = true;
            lbl_surnameError.ForeColor = Color.Crimson;
            lbl_surnameError.Location = new Point(722, 156);
            lbl_surnameError.Margin = new Padding(6, 0, 6, 0);
            lbl_surnameError.Name = "lbl_surnameError";
            lbl_surnameError.Size = new Size(166, 32);
            lbl_surnameError.TabIndex = 13;
            lbl_surnameError.Text = "Surname Error";
            // 
            // lbl_usernameError
            // 
            lbl_usernameError.AutoSize = true;
            lbl_usernameError.ForeColor = Color.Crimson;
            lbl_usernameError.Location = new Point(710, 208);
            lbl_usernameError.Margin = new Padding(6, 0, 6, 0);
            lbl_usernameError.Name = "lbl_usernameError";
            lbl_usernameError.Size = new Size(178, 32);
            lbl_usernameError.TabIndex = 14;
            lbl_usernameError.Text = "Username Error";
            // 
            // lbl_passwordError
            // 
            lbl_passwordError.AutoSize = true;
            lbl_passwordError.ForeColor = Color.Crimson;
            lbl_passwordError.Location = new Point(720, 250);
            lbl_passwordError.Margin = new Padding(6, 0, 6, 0);
            lbl_passwordError.Name = "lbl_passwordError";
            lbl_passwordError.Size = new Size(168, 32);
            lbl_passwordError.TabIndex = 16;
            lbl_passwordError.Text = "Password Error";
            // 
            // lbl_passwordConfirmError
            // 
            lbl_passwordConfirmError.AutoSize = true;
            lbl_passwordConfirmError.ForeColor = Color.Crimson;
            lbl_passwordConfirmError.Location = new Point(659, 52);
            lbl_passwordConfirmError.Margin = new Padding(6, 0, 6, 0);
            lbl_passwordConfirmError.Name = "lbl_passwordConfirmError";
            lbl_passwordConfirmError.Size = new Size(261, 32);
            lbl_passwordConfirmError.TabIndex = 17;
            lbl_passwordConfirmError.Text = "Password Confirm Error";
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.Image = Properties.Resources.Guest;
            circularPictureBox1.Location = new Point(401, 428);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new Size(229, 224);
            circularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            circularPictureBox1.TabIndex = 18;
            circularPictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Title = "Blocks · Pick Avatar Image";
            // 
            // btn_pickImage
            // 
            btn_pickImage.Location = new Point(722, 314);
            btn_pickImage.Name = "btn_pickImage";
            btn_pickImage.Size = new Size(150, 46);
            btn_pickImage.TabIndex = 19;
            btn_pickImage.Text = "Pick Image";
            btn_pickImage.UseVisualStyleBackColor = true;
            btn_pickImage.Click += btn_pickImage_Click;
            // 
            // button1
            // 
            button1.Location = new Point(386, 674);
            button1.Name = "button1";
            button1.Size = new Size(260, 46);
            button1.TabIndex = 20;
            button1.Text = "quick create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_CycleAvatarBack
            // 
            btn_CycleAvatarBack.Location = new Point(316, 516);
            btn_CycleAvatarBack.Name = "btn_CycleAvatarBack";
            btn_CycleAvatarBack.Size = new Size(50, 50);
            btn_CycleAvatarBack.TabIndex = 21;
            btn_CycleAvatarBack.Text = "◀";
            btn_CycleAvatarBack.UseVisualStyleBackColor = true;
            // 
            // btn_CycleAvatarForward
            // 
            btn_CycleAvatarForward.Location = new Point(660, 516);
            btn_CycleAvatarForward.Name = "btn_CycleAvatarForward";
            btn_CycleAvatarForward.Size = new Size(50, 50);
            btn_CycleAvatarForward.TabIndex = 22;
            btn_CycleAvatarForward.Text = "▶";
            btn_CycleAvatarForward.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 819);
            ControlBox = false;
            Controls.Add(btn_CycleAvatarForward);
            Controls.Add(btn_CycleAvatarBack);
            Controls.Add(button1);
            Controls.Add(btn_pickImage);
            Controls.Add(circularPictureBox1);
            Controls.Add(lbl_passwordConfirmError);
            Controls.Add(lbl_passwordError);
            Controls.Add(lbl_usernameError);
            Controls.Add(lbl_surnameError);
            Controls.Add(lbl_forenameError);
            Controls.Add(lbl_Title);
            Controls.Add(btn_registerPlayer);
            Controls.Add(txt_passwordConfirm);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(txt_surname);
            Controls.Add(txt_forename);
            Margin = new Padding(6);
            Name = "Registration";
            Text = "Blocks · Registration";
            FormClosing += Window_OnClose;
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_forename;
        private TextBox txt_surname;
        private TextBox txt_username;
        private TextBox txt_password;
        private TextBox txt_passwordConfirm;
        private Button btn_registerPlayer;
        private Label lbl_Title;
        private Label lbl_forenameError;
        private Label lbl_surnameError;
        private Label lbl_usernameError;
        private Label lbl_passwordError;
        private Label lbl_passwordConfirmError;
        private controls.CircularPictureBox circularPictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button btn_pickImage;
        private Button button1;
        private Button btn_CycleAvatarBack;
        private Button btn_CycleAvatarForward;
    }
}