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
            this.pic_SideBar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_playerAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SideBar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_forename
            // 
            this.txt_forename.Location = new System.Drawing.Point(14, 64);
            this.txt_forename.Name = "txt_forename";
            this.txt_forename.PlaceholderText = "Forename";
            this.txt_forename.Size = new System.Drawing.Size(140, 23);
            this.txt_forename.TabIndex = 5;
            this.txt_forename.TextChanged += new System.EventHandler(this.Forename_ValueChanged);
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(14, 108);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.PlaceholderText = "Surname";
            this.txt_surname.Size = new System.Drawing.Size(140, 23);
            this.txt_surname.TabIndex = 6;
            this.txt_surname.TextChanged += new System.EventHandler(this.Surname_ValueChanged);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(14, 154);
            this.txt_username.MaxLength = 16;
            this.txt_username.Name = "txt_username";
            this.txt_username.PlaceholderText = "Username";
            this.txt_username.Size = new System.Drawing.Size(140, 23);
            this.txt_username.TabIndex = 7;
            this.txt_username.TextChanged += new System.EventHandler(this.Username_ValueChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(14, 198);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.Size = new System.Drawing.Size(140, 23);
            this.txt_password.TabIndex = 8;
            this.txt_password.TextChanged += new System.EventHandler(this.Password_ValueChanged);
            // 
            // txt_passwordConfirm
            // 
            this.txt_passwordConfirm.Location = new System.Drawing.Point(14, 242);
            this.txt_passwordConfirm.Name = "txt_passwordConfirm";
            this.txt_passwordConfirm.PasswordChar = '*';
            this.txt_passwordConfirm.PlaceholderText = "Confirm Password";
            this.txt_passwordConfirm.Size = new System.Drawing.Size(140, 23);
            this.txt_passwordConfirm.TabIndex = 9;
            this.txt_passwordConfirm.TextChanged += new System.EventHandler(this.PasswordConfirm_ValueChanged);
            // 
            // btn_registerPlayer
            // 
            this.btn_registerPlayer.Location = new System.Drawing.Point(12, 326);
            this.btn_registerPlayer.Name = "btn_registerPlayer";
            this.btn_registerPlayer.Size = new System.Drawing.Size(75, 23);
            this.btn_registerPlayer.TabIndex = 10;
            this.btn_registerPlayer.Text = "Register";
            this.btn_registerPlayer.UseVisualStyleBackColor = true;
            this.btn_registerPlayer.Click += new System.EventHandler(this.registerPlayer_onClick);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.ForeColor = System.Drawing.Color.DodgerBlue;
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
            this.lbl_forenameError.Location = new System.Drawing.Point(75, 49);
            this.lbl_forenameError.Name = "lbl_forenameError";
            this.lbl_forenameError.Size = new System.Drawing.Size(88, 15);
            this.lbl_forenameError.TabIndex = 12;
            this.lbl_forenameError.Text = "Forename Error";
            // 
            // lbl_surnameError
            // 
            this.lbl_surnameError.AutoSize = true;
            this.lbl_surnameError.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_surnameError.Location = new System.Drawing.Point(69, 90);
            this.lbl_surnameError.Name = "lbl_surnameError";
            this.lbl_surnameError.Size = new System.Drawing.Size(82, 15);
            this.lbl_surnameError.TabIndex = 13;
            this.lbl_surnameError.Text = "Surname Error";
            // 
            // lbl_usernameError
            // 
            this.lbl_usernameError.AutoSize = true;
            this.lbl_usernameError.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_usernameError.Location = new System.Drawing.Point(75, 136);
            this.lbl_usernameError.Name = "lbl_usernameError";
            this.lbl_usernameError.Size = new System.Drawing.Size(88, 15);
            this.lbl_usernameError.TabIndex = 14;
            this.lbl_usernameError.Text = "Username Error";
            // 
            // lbl_passwordError
            // 
            this.lbl_passwordError.AutoSize = true;
            this.lbl_passwordError.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_passwordError.Location = new System.Drawing.Point(69, 180);
            this.lbl_passwordError.Name = "lbl_passwordError";
            this.lbl_passwordError.Size = new System.Drawing.Size(85, 15);
            this.lbl_passwordError.TabIndex = 16;
            this.lbl_passwordError.Text = "Password Error";
            // 
            // lbl_passwordConfirmError
            // 
            this.lbl_passwordConfirmError.AutoSize = true;
            this.lbl_passwordConfirmError.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_passwordConfirmError.Location = new System.Drawing.Point(124, 224);
            this.lbl_passwordConfirmError.Name = "lbl_passwordConfirmError";
            this.lbl_passwordConfirmError.Size = new System.Drawing.Size(132, 15);
            this.lbl_passwordConfirmError.TabIndex = 17;
            this.lbl_passwordConfirmError.Text = "Password Confirm Error";
            // 
            // pic_playerAvatar
            // 
            this.pic_playerAvatar.Image = global::AS_Coursework.Properties.Resources.Guest;
            this.pic_playerAvatar.Location = new System.Drawing.Point(203, 49);
            this.pic_playerAvatar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pic_playerAvatar.Name = "pic_playerAvatar";
            this.pic_playerAvatar.Size = new System.Drawing.Size(90, 90);
            this.pic_playerAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_playerAvatar.TabIndex = 18;
            this.pic_playerAvatar.TabStop = false;
            this.pic_playerAvatar.DoubleClick += new System.EventHandler(this.pic_playerAvatar_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Blocks · Pick Avatar Image";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 326);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 22);
            this.button1.TabIndex = 20;
            this.button1.Text = "Quick Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_CycleAvatarBack
            // 
            this.btn_CycleAvatarBack.Location = new System.Drawing.Point(222, 153);
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
            this.btn_CycleAvatarForward.Location = new System.Drawing.Point(253, 153);
            this.btn_CycleAvatarForward.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_CycleAvatarForward.Name = "btn_CycleAvatarForward";
            this.btn_CycleAvatarForward.Size = new System.Drawing.Size(27, 23);
            this.btn_CycleAvatarForward.TabIndex = 22;
            this.btn_CycleAvatarForward.Text = "▶";
            this.btn_CycleAvatarForward.UseVisualStyleBackColor = true;
            this.btn_CycleAvatarForward.Click += new System.EventHandler(this.btn_CycleAvatarForward_Click);
            // 
            // pic_SideBar
            // 
            this.pic_SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pic_SideBar.Image = global::AS_Coursework.Properties.Resources.sidebar_reg;
            this.pic_SideBar.Location = new System.Drawing.Point(325, 0);
            this.pic_SideBar.Name = "pic_SideBar";
            this.pic_SideBar.Size = new System.Drawing.Size(310, 365);
            this.pic_SideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_SideBar.TabIndex = 23;
            this.pic_SideBar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Forename";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(14, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(14, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(14, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Confirm Password";
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
            this.btn_Exit.TabIndex = 29;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_SideBar);
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_SideBar)).EndInit();
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
        private PictureBox pic_SideBar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_Exit;
    }
}