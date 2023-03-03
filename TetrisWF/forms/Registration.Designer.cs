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
            pic_playerAvatar = new controls.CircularPictureBox();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            btn_CycleAvatarBack = new Button();
            btn_CycleAvatarForward = new Button();
            pic_SideBar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_playerAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_SideBar).BeginInit();
            SuspendLayout();
            // 
            // txt_forename
            // 
            txt_forename.Location = new Point(26, 137);
            txt_forename.Margin = new Padding(6);
            txt_forename.Name = "txt_forename";
            txt_forename.PlaceholderText = "Forename";
            txt_forename.Size = new Size(257, 39);
            txt_forename.TabIndex = 5;
            txt_forename.TextChanged += Forename_ValueChanged;
            // 
            // txt_surname
            // 
            txt_surname.Location = new Point(26, 230);
            txt_surname.Margin = new Padding(6);
            txt_surname.Name = "txt_surname";
            txt_surname.PlaceholderText = "Surname";
            txt_surname.Size = new Size(257, 39);
            txt_surname.TabIndex = 6;
            txt_surname.TextChanged += Surname_ValueChanged;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(26, 329);
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
            txt_password.Location = new Point(26, 422);
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
            txt_passwordConfirm.Location = new Point(26, 516);
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
            btn_registerPlayer.Location = new Point(22, 638);
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
            lbl_Title.ForeColor = Color.DodgerBlue;
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
            lbl_forenameError.Location = new Point(139, 105);
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
            lbl_surnameError.Location = new Point(128, 192);
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
            lbl_usernameError.Location = new Point(139, 290);
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
            lbl_passwordError.Location = new Point(128, 384);
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
            lbl_passwordConfirmError.Location = new Point(230, 478);
            lbl_passwordConfirmError.Margin = new Padding(6, 0, 6, 0);
            lbl_passwordConfirmError.Name = "lbl_passwordConfirmError";
            lbl_passwordConfirmError.Size = new Size(261, 32);
            lbl_passwordConfirmError.TabIndex = 17;
            lbl_passwordConfirmError.Text = "Password Confirm Error";
            // 
            // pic_playerAvatar
            // 
            pic_playerAvatar.Image = Properties.Resources.Guest;
            pic_playerAvatar.Location = new Point(377, 105);
            pic_playerAvatar.Margin = new Padding(4, 2, 4, 2);
            pic_playerAvatar.Name = "pic_playerAvatar";
            pic_playerAvatar.Size = new Size(167, 192);
            pic_playerAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_playerAvatar.TabIndex = 18;
            pic_playerAvatar.TabStop = false;
            pic_playerAvatar.DoubleClick += pic_playerAvatar_DoubleClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Title = "Blocks · Pick Avatar Image";
            // 
            // button1
            // 
            button1.Location = new Point(171, 638);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(260, 47);
            button1.TabIndex = 20;
            button1.Text = "Quick Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_CycleAvatarBack
            // 
            btn_CycleAvatarBack.Location = new Point(412, 326);
            btn_CycleAvatarBack.Margin = new Padding(4, 2, 4, 2);
            btn_CycleAvatarBack.Name = "btn_CycleAvatarBack";
            btn_CycleAvatarBack.Size = new Size(50, 49);
            btn_CycleAvatarBack.TabIndex = 21;
            btn_CycleAvatarBack.Text = "◀";
            btn_CycleAvatarBack.UseVisualStyleBackColor = true;
            btn_CycleAvatarBack.Click += btn_CycleAvatarBack_Click;
            // 
            // btn_CycleAvatarForward
            // 
            btn_CycleAvatarForward.Location = new Point(470, 326);
            btn_CycleAvatarForward.Margin = new Padding(4, 2, 4, 2);
            btn_CycleAvatarForward.Name = "btn_CycleAvatarForward";
            btn_CycleAvatarForward.Size = new Size(50, 49);
            btn_CycleAvatarForward.TabIndex = 22;
            btn_CycleAvatarForward.Text = "▶";
            btn_CycleAvatarForward.UseVisualStyleBackColor = true;
            btn_CycleAvatarForward.Click += btn_CycleAvatarForward_Click;
            // 
            // pic_SideBar
            // 
            pic_SideBar.BackColor = Color.FromArgb(23, 23, 23);
            pic_SideBar.Image = Properties.Resources.sidebar_reg;
            pic_SideBar.Location = new Point(604, 0);
            pic_SideBar.Margin = new Padding(6);
            pic_SideBar.Name = "pic_SideBar";
            pic_SideBar.Size = new Size(563, 767);
            pic_SideBar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_SideBar.TabIndex = 23;
            pic_SideBar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(26, 105);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 24;
            label1.Text = "Forename";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(26, 192);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 25;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(26, 290);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 32);
            label3.TabIndex = 26;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(26, 384);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 27;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(26, 478);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(204, 32);
            label5.TabIndex = 28;
            label5.Text = "Confirm Password";
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.IndianRed;
            btn_Exit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Exit.ForeColor = SystemColors.Window;
            btn_Exit.Location = new Point(1098, 15);
            btn_Exit.Margin = new Padding(0);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(50, 50);
            btn_Exit.TabIndex = 29;
            btn_Exit.Text = "X";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1159, 702);
            ControlBox = false;
            Controls.Add(btn_Exit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pic_SideBar);
            Controls.Add(btn_CycleAvatarForward);
            Controls.Add(btn_CycleAvatarBack);
            Controls.Add(button1);
            Controls.Add(pic_playerAvatar);
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
            MaximumSize = new Size(1185, 773);
            MinimumSize = new Size(1185, 773);
            Name = "Registration";
            Text = "Blocks · Registration";
            ((System.ComponentModel.ISupportInitialize)pic_playerAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_SideBar).EndInit();
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