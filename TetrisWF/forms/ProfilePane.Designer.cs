using System.Windows.Forms;

namespace AS_Coursework.forms
{
    partial class ProfilePane
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected void Dispose(bool disposing)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePane));
            btn_Exit = new Button();
            pic_PlayerAvatar = new controls.CircularPictureBox();
            lbl_name = new Label();
            lbl_username = new Label();
            lbl_Categories = new Label();
            lbl_Statistics = new Label();
            checkedListBox1 = new CheckedListBox();
            circularPictureBox1 = new controls.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_PlayerAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = System.Drawing.Color.IndianRed;
            btn_Exit.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Exit.ForeColor = System.Drawing.SystemColors.Window;
            btn_Exit.Location = new System.Drawing.Point(273, 9);
            btn_Exit.Margin = new Padding(0);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new System.Drawing.Size(27, 23);
            btn_Exit.TabIndex = 30;
            btn_Exit.Text = "X";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += ExitButton_OnClick;
            // 
            // pic_PlayerAvatar
            // 
            pic_PlayerAvatar.BorderStyle = BorderStyle.FixedSingle;
            pic_PlayerAvatar.Image = Properties.Resources.Guest;
            pic_PlayerAvatar.Location = new System.Drawing.Point(12, 9);
            pic_PlayerAvatar.Name = "pic_PlayerAvatar";
            pic_PlayerAvatar.Size = new System.Drawing.Size(65, 65);
            pic_PlayerAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_PlayerAvatar.TabIndex = 31;
            pic_PlayerAvatar.TabStop = false;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_name.Location = new System.Drawing.Point(83, 21);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new System.Drawing.Size(161, 21);
            lbl_name.TabIndex = 32;
            lbl_name.Text = "Forename Surname";
            lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new System.Drawing.Point(84, 41);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new System.Drawing.Size(60, 15);
            lbl_username.TabIndex = 33;
            lbl_username.Text = "Username";
            // 
            // lbl_Categories
            // 
            lbl_Categories.AutoSize = true;
            lbl_Categories.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Categories.Location = new System.Drawing.Point(17, 85);
            lbl_Categories.Name = "lbl_Categories";
            lbl_Categories.Size = new System.Drawing.Size(91, 90);
            lbl_Categories.TabIndex = 34;
            lbl_Categories.Text = "High Score\r\nTotal Score\r\nPRs\r\nBlocks Placed\r\nGames Played\r\nLines Cleared";
            lbl_Categories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Statistics
            // 
            lbl_Statistics.AutoSize = true;
            lbl_Statistics.Location = new System.Drawing.Point(147, 85);
            lbl_Statistics.MaximumSize = new System.Drawing.Size(150, 90);
            lbl_Statistics.MinimumSize = new System.Drawing.Size(150, 90);
            lbl_Statistics.Name = "lbl_Statistics";
            lbl_Statistics.Size = new System.Drawing.Size(150, 90);
            lbl_Statistics.TabIndex = 40;
            lbl_Statistics.Text = "[HIGH_SCORE]\r\n[TOTAL_SCORE]\r\n[PRS]\r\n[BLOCKS_PLACED]\r\n[GAMES_PLAYED]\r\n[LINES_CLEARED]";
            lbl_Statistics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new System.Drawing.Point(34, 343);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new System.Drawing.Size(8, 4);
            checkedListBox1.TabIndex = 46;
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            circularPictureBox1.BorderStyle = BorderStyle.FixedSingle;
            circularPictureBox1.Location = new System.Drawing.Point(7, 4);
            circularPictureBox1.Margin = new Padding(2, 1, 2, 1);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new System.Drawing.Size(75, 75);
            circularPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            circularPictureBox1.TabIndex = 47;
            circularPictureBox1.TabStop = false;
            // 
            // ProfilePane
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(309, 195);
            ControlBox = false;
            Controls.Add(checkedListBox1);
            Controls.Add(lbl_Statistics);
            Controls.Add(lbl_Categories);
            Controls.Add(lbl_username);
            Controls.Add(lbl_name);
            Controls.Add(pic_PlayerAvatar);
            Controls.Add(btn_Exit);
            Controls.Add(circularPictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximumSize = new System.Drawing.Size(325, 234);
            MinimumSize = new System.Drawing.Size(325, 234);
            Name = "ProfilePane";
            Text = "Blocks • Your Profile";
            FormClosing += Form_OnClosing;
            ((System.ComponentModel.ISupportInitialize)pic_PlayerAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private controls.CircularPictureBox pic_PlayerAvatar;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_Categories;
        private System.Windows.Forms.Label lbl_Statistics;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private controls.CircularPictureBox circularPictureBox1;
    }
}