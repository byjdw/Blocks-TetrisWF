namespace AS_Coursework.game
{
    partial class GameEnd
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
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_ExitProgram = new System.Windows.Forms.Button();
            this.pic_SideBar = new System.Windows.Forms.PictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_score.Location = new System.Drawing.Point(12, 131);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(140, 41);
            this.lbl_score.TabIndex = 0;
            this.lbl_score.Text = "[SCORE]";
            // 
            // btn_ExitProgram
            // 
            this.btn_ExitProgram.BackColor = System.Drawing.Color.IndianRed;
            this.btn_ExitProgram.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ExitProgram.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ExitProgram.Location = new System.Drawing.Point(593, 9);
            this.btn_ExitProgram.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ExitProgram.Name = "btn_ExitProgram";
            this.btn_ExitProgram.Size = new System.Drawing.Size(27, 23);
            this.btn_ExitProgram.TabIndex = 12;
            this.btn_ExitProgram.Text = "X";
            this.btn_ExitProgram.UseVisualStyleBackColor = false;
            // 
            // pic_SideBar
            // 
            this.pic_SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pic_SideBar.BackgroundImage = global::AS_Coursework.Properties.Resources.Board_Z;
            this.pic_SideBar.Image = global::AS_Coursework.Properties.Resources.sidebar_gameover;
            this.pic_SideBar.Location = new System.Drawing.Point(320, -38);
            this.pic_SideBar.Name = "pic_SideBar";
            this.pic_SideBar.Size = new System.Drawing.Size(318, 387);
            this.pic_SideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_SideBar.TabIndex = 13;
            this.pic_SideBar.TabStop = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Title.Location = new System.Drawing.Point(12, 6);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(157, 32);
            this.lbl_Title.TabIndex = 14;
            this.lbl_Title.Text = "GAME OVER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::AS_Coursework.Properties.Resources.Blocks;
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "You scored...";
            // 
            // GameEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 341);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ExitProgram);
            this.Controls.Add(this.pic_SideBar);
            this.Controls.Add(this.lbl_score);
            this.Name = "GameEnd";
            this.Text = "GameEnd";
            ((System.ComponentModel.ISupportInitialize)(this.pic_SideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_ExitProgram;
        private System.Windows.Forms.PictureBox pic_SideBar;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}