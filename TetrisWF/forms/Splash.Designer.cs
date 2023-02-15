using AS_Coursework.controls;
using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            btn_Register = new Button();
            btn_Login = new Button();
            lbl_currentPlayer = new Label();
            btn_StartGame = new Button();
            btn_ContinueGame = new Button();
            btn_ExitProgram = new Button();
            pictureBox1 = new CircularPictureBox();
            label1 = new Label();
            circularPictureBox1 = new CircularPictureBox();
            pictureBox2 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_Register
            // 
            btn_Register.BackColor = Color.MediumBlue;
            btn_Register.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Register.ForeColor = SystemColors.Window;
            btn_Register.Location = new Point(538, 292);
            btn_Register.Margin = new Padding(6);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(204, 83);
            btn_Register.TabIndex = 0;
            btn_Register.Text = "REGISTER";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += btn_RegisterOnClick;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.DarkOrange;
            btn_Login.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.ForeColor = SystemColors.Window;
            btn_Login.Location = new Point(303, 292);
            btn_Login.Margin = new Padding(6);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(204, 82);
            btn_Login.TabIndex = 1;
            btn_Login.Text = "LOGIN";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_LoginOnClick;
            // 
            // lbl_currentPlayer
            // 
            lbl_currentPlayer.AutoSize = true;
            lbl_currentPlayer.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_currentPlayer.ForeColor = SystemColors.ControlLightLight;
            lbl_currentPlayer.Location = new Point(113, 460);
            lbl_currentPlayer.Margin = new Padding(6, 0, 6, 0);
            lbl_currentPlayer.Name = "lbl_currentPlayer";
            lbl_currentPlayer.Size = new Size(81, 32);
            lbl_currentPlayer.TabIndex = 3;
            lbl_currentPlayer.Text = "Guest";
            // 
            // btn_StartGame
            // 
            btn_StartGame.BackColor = Color.Lime;
            btn_StartGame.BackgroundImageLayout = ImageLayout.Center;
            btn_StartGame.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_StartGame.ForeColor = SystemColors.Window;
            btn_StartGame.Location = new Point(303, 198);
            btn_StartGame.Margin = new Padding(6);
            btn_StartGame.Name = "btn_StartGame";
            btn_StartGame.Size = new Size(204, 82);
            btn_StartGame.TabIndex = 4;
            btn_StartGame.Text = "START";
            btn_StartGame.UseVisualStyleBackColor = false;
            btn_StartGame.Click += btn_StartGame_Click;
            // 
            // btn_ContinueGame
            // 
            btn_ContinueGame.BackColor = Color.BlueViolet;
            btn_ContinueGame.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ContinueGame.ForeColor = SystemColors.Window;
            btn_ContinueGame.Location = new Point(538, 198);
            btn_ContinueGame.Margin = new Padding(6);
            btn_ContinueGame.Name = "btn_ContinueGame";
            btn_ContinueGame.Size = new Size(204, 82);
            btn_ContinueGame.TabIndex = 5;
            btn_ContinueGame.Text = "CONTINUE";
            btn_ContinueGame.UseVisualStyleBackColor = false;
            btn_ContinueGame.Click += btn_ContinueGame_Click;
            // 
            // btn_ExitProgram
            // 
            btn_ExitProgram.BackColor = Color.Red;
            btn_ExitProgram.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ExitProgram.ForeColor = SystemColors.Window;
            btn_ExitProgram.Location = new Point(428, 386);
            btn_ExitProgram.Margin = new Padding(6);
            btn_ExitProgram.Name = "btn_ExitProgram";
            btn_ExitProgram.Size = new Size(204, 83);
            btn_ExitProgram.TabIndex = 6;
            btn_ExitProgram.Text = "EXIT";
            btn_ExitProgram.UseVisualStyleBackColor = false;
            btn_ExitProgram.Click += btn_ExitProgram_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.Guest;
            pictureBox1.Location = new Point(12, 412);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.DoubleClick += CurrentUser_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(113, 428);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 8;
            label1.Text = "Logged in as";
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.Location = new Point(236, 155);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new Size(30, 65);
            circularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            circularPictureBox1.TabIndex = 9;
            circularPictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(211, 35);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(620, 162);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1032, 513);
            Controls.Add(circularPictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_ExitProgram);
            Controls.Add(btn_ContinueGame);
            Controls.Add(btn_StartGame);
            Controls.Add(lbl_currentPlayer);
            Controls.Add(btn_Login);
            Controls.Add(btn_Register);
            Controls.Add(pictureBox2);
            Cursor = Cursors.Hand;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Splash";
            Text = "Blocks · Main Menu";
            VisibleChanged += Splash_VisibilityChange;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Register;
        private Button btn_Login;
        private Label lbl_currentPlayer;
        private Button btn_StartGame;
        private Button btn_ContinueGame;
        private Button btn_ExitProgram;
        private CircularPictureBox pictureBox1;
        private Label label1;
        private CircularPictureBox circularPictureBox1;
        private PictureBox pictureBox2;
        private OpenFileDialog openFileDialog1;
    }
}