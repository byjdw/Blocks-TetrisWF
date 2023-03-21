namespace AS_Coursework.forms
{
    partial class SettingsPane
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
            btn_Exit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = System.Drawing.Color.IndianRed;
            btn_Exit.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Exit.ForeColor = System.Drawing.SystemColors.Window;
            btn_Exit.Location = new System.Drawing.Point(273, 9);
            btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new System.Drawing.Size(27, 23);
            btn_Exit.TabIndex = 31;
            btn_Exit.Text = "X";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // SettingsPane
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.AliceBlue;
            ClientSize = new System.Drawing.Size(309, 195);
            ControlBox = false;
            Controls.Add(btn_Exit);
            Name = "SettingsPane";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "Blocks • Settings";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
    }
}