namespace AS_Coursework.forms
{
    partial class HelpPane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpPane));
            btn_Exit = new System.Windows.Forms.Button();
            lbl_Title = new System.Windows.Forms.Label();
            pic_TitleCard = new System.Windows.Forms.PictureBox();
            lbl_GameRulesHeader = new System.Windows.Forms.Label();
            lbl_GameRules = new System.Windows.Forms.Label();
            lbl_GameControlsHeader = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pic_TitleCard).BeginInit();
            SuspendLayout();
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = System.Drawing.Color.IndianRed;
            btn_Exit.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Exit.ForeColor = System.Drawing.SystemColors.Window;
            btn_Exit.Location = new System.Drawing.Point(395, 6);
            btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new System.Drawing.Size(27, 23);
            btn_Exit.TabIndex = 31;
            btn_Exit.Text = "X";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Title.ForeColor = System.Drawing.Color.DarkViolet;
            lbl_Title.Location = new System.Drawing.Point(12, 6);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new System.Drawing.Size(186, 32);
            lbl_Title.TabIndex = 32;
            lbl_Title.Text = "HOW TO PLAY";
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
            // lbl_GameRulesHeader
            // 
            lbl_GameRulesHeader.AutoSize = true;
            lbl_GameRulesHeader.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_GameRulesHeader.Location = new System.Drawing.Point(12, 93);
            lbl_GameRulesHeader.Name = "lbl_GameRulesHeader";
            lbl_GameRulesHeader.Size = new System.Drawing.Size(148, 30);
            lbl_GameRulesHeader.TabIndex = 34;
            lbl_GameRulesHeader.Text = "GAME RULES";
            // 
            // lbl_GameRules
            // 
            lbl_GameRules.AutoSize = true;
            lbl_GameRules.Location = new System.Drawing.Point(16, 123);
            lbl_GameRules.Name = "lbl_GameRules";
            lbl_GameRules.Size = new System.Drawing.Size(316, 60);
            lbl_GameRules.TabIndex = 35;
            lbl_GameRules.Text = "• Fill up lines to earn points and gain score;\r\n• The more lines you fill up, the more score you get:\r\n• If the board fills up to the top and there is no more room,\r\n   its game over.\r\n";
            // 
            // lbl_GameControlsHeader
            // 
            lbl_GameControlsHeader.AutoSize = true;
            lbl_GameControlsHeader.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_GameControlsHeader.Location = new System.Drawing.Point(16, 183);
            lbl_GameControlsHeader.Name = "lbl_GameControlsHeader";
            lbl_GameControlsHeader.Size = new System.Drawing.Size(195, 30);
            lbl_GameControlsHeader.TabIndex = 36;
            lbl_GameControlsHeader.Text = "GAME CONTROLS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 213);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(374, 240);
            label1.TabIndex = 37;
            label1.Text = resources.GetString("label1.Text");
            // 
            // HelpPane
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.AliceBlue;
            ClientSize = new System.Drawing.Size(431, 386);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(lbl_GameControlsHeader);
            Controls.Add(lbl_GameRules);
            Controls.Add(lbl_GameRulesHeader);
            Controls.Add(lbl_Title);
            Controls.Add(pic_TitleCard);
            Controls.Add(btn_Exit);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximumSize = new System.Drawing.Size(447, 498);
            MinimumSize = new System.Drawing.Size(447, 425);
            Name = "HelpPane";
            Text = "Blocks • Help";
            FormClosing += HelpPane_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pic_TitleCard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pic_TitleCard;
        private System.Windows.Forms.Label lbl_GameRulesHeader;
        private System.Windows.Forms.Label lbl_GameRules;
        private System.Windows.Forms.Label lbl_GameControlsHeader;
        private System.Windows.Forms.Label label1;
    }
}