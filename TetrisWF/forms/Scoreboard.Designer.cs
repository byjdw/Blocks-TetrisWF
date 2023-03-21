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
            ((System.ComponentModel.ISupportInitialize)pic_TitleCard).BeginInit();
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
            lbl_Title.Size = new System.Drawing.Size(231, 32);
            lbl_Title.TabIndex = 32;
            lbl_Title.Text = "THE SCOREBOARD";
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
            // Scoreboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.AliceBlue;
            ClientSize = new System.Drawing.Size(629, 344);
            Controls.Add(lbl_Title);
            Controls.Add(pic_TitleCard);
            Controls.Add(label1);
            Name = "Scoreboard";
            Text = "Blocks • Scoreboard";
            ((System.ComponentModel.ISupportInitialize)pic_TitleCard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pic_TitleCard;
    }
}