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
            this.txt_forename = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_passwordConfirm = new System.Windows.Forms.TextBox();
            this.btn_registerPlayer = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_forenameError = new System.Windows.Forms.Label();
            this.lbl_surnameError = new System.Windows.Forms.Label();
            this.lbl_usernameError = new System.Windows.Forms.Label();
            this.lbl_passwordError = new System.Windows.Forms.Label();
            this.lbl_passwordConfirmError = new System.Windows.Forms.Label();
            this.pic_playerAvatar = new AS_Coursework.controls.CircularPictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_CycleAvatarBack = new System.Windows.Forms.Button();
            this.btn_CycleAvatarForward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_playerAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_forename
            // 
            this.txt_forename.Location = new System.Drawing.Point(24, 49);
            this.txt_forename.Name = "txt_forename";
            this.txt_forename.PlaceholderText = "Forename";
            this.txt_forename.Size = new System.Drawing.Size(140, 23);
            this.txt_forename.TabIndex = 5;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(24, 78);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.PlaceholderText = "Surname";
            this.txt_surname.Size = new System.Drawing.Size(140, 23);
            this.txt_surname.TabIndex = 6;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(24, 102);
            this.txt_username.MaxLength = 16;
            this.txt_username.Name = "txt_username";
            this.txt_username.PlaceholderText = "Username";
            this.txt_username.Size = new System.Drawing.Size(140, 23);
            this.txt_username.TabIndex = 7;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(24, 131);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.Size = new System.Drawing.Size(140, 23);
            this.txt_password.TabIndex = 8;
            // 
            // txt_passwordConfirm
            // 
            this.txt_passwordConfirm.Location = new System.Drawing.Point(24, 160);
            this.txt_passwordConfirm.Name = "txt_passwordConfirm";
            this.txt_passwordConfirm.PasswordChar = '*';
            this.txt_passwordConfirm.PlaceholderText = "Confirm Password";
            this.txt_passwordConfirm.Size = new System.Drawing.Size(140, 23);
            this.txt_passwordConfirm.TabIndex = 9;
            // 
            // btn_registerPlayer
            // 
            this.btn_registerPlayer.Location = new System.Drawing.Point(24, 230);
            this.btn_registerPlayer.Name = "btn_registerPlayer";
            this.btn_registerPlayer.Size = new System.Drawing.Size(75, 23);
            this.btn_registerPlayer.TabIndex = 10;
            this.btn_registerPlayer.Text = "Register";
            this.btn_registerPlayer.UseVisualStyleBackColor = true;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(293, 32);
            this.lbl_Title.TabIndex = 11;
            this.lbl_Title.Text = "Register a New Account";
            // 
            // lbl_forenameError
            // 
            this.lbl_forenameError.AutoSize = true;
            this.lbl_forenameError.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_forenameError.Location = new System.Drawing.Point(389, 47);
            this.lbl_forenameError.Name = "lbl_forenameError";
            this.lbl_forenameError.Size = new System.Drawing.Size(88, 15);
            this.lbl_forenameError.TabIndex = 12;
            this.lbl_forenameError.Text = "Forename Error";
            // 
            // lbl_surnameError
            // 
            this.lbl_surnameError.AutoSize = true;
            this.lbl_surnameError.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_surnameError.Location = new System.Drawing.Point(389, 73);
            this.lbl_surnameError.Name = "lbl_surnameError";
            this.lbl_surnameError.Size = new System.Drawing.Size(82, 15);
            this.lbl_surnameError.TabIndex = 13;
            this.lbl_surnameError.Text = "Surname Error";
            // 
            // lbl_usernameError
            // 
            this.lbl_usernameError.AutoSize = true;
            this.lbl_usernameError.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_usernameError.Location = new System.Drawing.Point(382, 98);
            this.lbl_usernameError.Name = "lbl_usernameError";
            this.lbl_usernameError.Size = new System.Drawing.Size(88, 15);
            this.lbl_usernameError.TabIndex = 14;
            this.lbl_usernameError.Text = "Username Error";
            // 
            // lbl_passwordError
            // 
            this.lbl_passwordError.AutoSize = true;
            this.lbl_passwordError.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_passwordError.Location = new System.Drawing.Point(388, 117);
            this.lbl_passwordError.Name = "lbl_passwordError";
            this.lbl_passwordError.Size = new System.Drawing.Size(85, 15);
            this.lbl_passwordError.TabIndex = 16;
            this.lbl_passwordError.Text = "Password Error";
            // 
            // lbl_passwordConfirmError
            // 
            this.lbl_passwordConfirmError.AutoSize = true;
            this.lbl_passwordConfirmError.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_passwordConfirmError.Location = new System.Drawing.Point(355, 24);
            this.lbl_passwordConfirmError.Name = "lbl_passwordConfirmError";
            this.lbl_passwordConfirmError.Size = new System.Drawing.Size(132, 15);
            this.lbl_passwordConfirmError.TabIndex = 17;
            this.lbl_passwordConfirmError.Text = "Password Confirm Error";
            // 
            // pic_playerAvatar
            // 
            this.pic_playerAvatar.Image = global::AS_Coursework.Properties.Resources.Guest;
            this.pic_playerAvatar.Location = new System.Drawing.Point(208, 49);
            this.pic_playerAvatar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pic_playerAvatar.Name = "pic_playerAvatar";
            this.pic_playerAvatar.Size = new System.Drawing.Size(125, 125);
            this.pic_playerAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_playerAvatar.TabIndex = 18;
            this.pic_playerAvatar.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Blocks · Pick Avatar Image";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 22);
            this.button1.TabIndex = 20;
            this.button1.Text = "Quick Create";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_CycleAvatarBack
            // 
            this.btn_CycleAvatarBack.Location = new System.Drawing.Point(177, 102);
            this.btn_CycleAvatarBack.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_CycleAvatarBack.Name = "btn_CycleAvatarBack";
            this.btn_CycleAvatarBack.Size = new System.Drawing.Size(27, 23);
            this.btn_CycleAvatarBack.TabIndex = 21;
            this.btn_CycleAvatarBack.Text = "◀";
            this.btn_CycleAvatarBack.UseVisualStyleBackColor = true;
            this.btn_CycleAvatarBack.Click += new System.EventHandler(this.btn_CycleAvatarBack_Click);
            // 
            // btn_CycleAvatarForward
            // 
            this.btn_CycleAvatarForward.Location = new System.Drawing.Point(337, 98);
            this.btn_CycleAvatarForward.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_CycleAvatarForward.Name = "btn_CycleAvatarForward";
            this.btn_CycleAvatarForward.Size = new System.Drawing.Size(27, 23);
            this.btn_CycleAvatarForward.TabIndex = 22;
            this.btn_CycleAvatarForward.Text = "▶";
            this.btn_CycleAvatarForward.UseVisualStyleBackColor = true;
            this.btn_CycleAvatarForward.Click += new System.EventHandler(this.btn_CycleAvatarForward_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btn_CycleAvatarForward);
            this.Controls.Add(this.btn_CycleAvatarBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic_playerAvatar);
            this.Controls.Add(this.lbl_passwordConfirmError);
            this.Controls.Add(this.lbl_passwordError);
            this.Controls.Add(this.lbl_usernameError);
            this.Controls.Add(this.lbl_surnameError);
            this.Controls.Add(this.lbl_forenameError);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_registerPlayer);
            this.Controls.Add(this.txt_passwordConfirm);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_forename);
            this.Name = "Registration";
            this.Text = "Blocks · Registration";
            ((System.ComponentModel.ISupportInitialize)(this.pic_playerAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private controls.CircularPictureBox pic_playerAvatar;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button btn_CycleAvatarBack;
        private Button btn_CycleAvatarForward;
    }
}