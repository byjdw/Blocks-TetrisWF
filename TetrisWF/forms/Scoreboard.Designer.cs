namespace AS_Coursework.forms
{
    partial class Scoreboard
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
            label1 = new System.Windows.Forms.Label();
            lbl_Title = new System.Windows.Forms.Label();
            pic_TitleCard = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            pic_SideBar = new System.Windows.Forms.PictureBox();
            circularPictureBox1 = new controls.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_TitleCard).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_SideBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 121);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Title.ForeColor = System.Drawing.Color.DarkOrchid;
            lbl_Title.Location = new System.Drawing.Point(12, 6);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new System.Drawing.Size(177, 32);
            lbl_Title.TabIndex = 32;
            lbl_Title.Text = "SCOREBOARD";
            // 
            // pic_TitleCard
            // 
            pic_TitleCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pic_TitleCard.Image = Properties.Resources.Blocks;
            pic_TitleCard.Location = new System.Drawing.Point(12, 23);
            pic_TitleCard.Name = "pic_TitleCard";
            pic_TitleCard.Size = new System.Drawing.Size(226, 95);
            pic_TitleCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pic_TitleCard.TabIndex = 33;
            pic_TitleCard.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 15);
            label2.TabIndex = 35;
            label2.Text = "label2";
            // 
            // panel1
            // 
            panel1.Controls.Add(circularPictureBox1);
            panel1.Controls.Add(pic_SideBar);
            panel1.Location = new System.Drawing.Point(329, -3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(305, 350);
            panel1.TabIndex = 36;
            // 
            // pic_SideBar
            // 
            pic_SideBar.BackColor = System.Drawing.Color.FromArgb(23, 23, 23);
            pic_SideBar.BackgroundImage = Properties.Resources.Board_Reverse_L;
            pic_SideBar.Location = new System.Drawing.Point(2, -2);
            pic_SideBar.Name = "pic_SideBar";
            pic_SideBar.Size = new System.Drawing.Size(300, 362);
            pic_SideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pic_SideBar.TabIndex = 35;
            pic_SideBar.TabStop = false;
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            circularPictureBox1.Image = Properties.Resources.Guest;
            circularPictureBox1.Location = new System.Drawing.Point(105, 71);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new System.Drawing.Size(100, 100);
            circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            circularPictureBox1.TabIndex = 36;
            circularPictureBox1.TabStop = false;
            // 
            // Scoreboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.AliceBlue;
            ClientSize = new System.Drawing.Size(629, 344);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(lbl_Title);
            Controls.Add(pic_TitleCard);
            Controls.Add(label1);
            Name = "Scoreboard";
            Text = "Blocks • Scoreboard";
            ((System.ComponentModel.ISupportInitialize)pic_TitleCard).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_SideBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pic_TitleCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private controls.CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.PictureBox pic_SideBar;
    }
}