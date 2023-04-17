using AS_Coursework.@internal;
using AS_Coursework.io;
using AS_Coursework.io.audio;
using System;
using System.Windows.Forms;

namespace AS_Coursework.forms
{
    public partial class HelpPane : Form
    {
        public HelpPane()
        {
            InitializeComponent();
            try
            {
                string rawText = GameIOManager.ReadHelpFile();
                string[] HelpText = rawText.Split(':');
                lbl_GameRules.Text = HelpText[0];
                lbl_GameControls.Text = HelpText[1];
            }
            catch
            {
                lbl_GameRules.Text = "Failed to load HelpText.txt";
                lbl_GameControls.Text = "Failed to load HelpText.txt";
            }
        }



        private void ExitButton_OnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_OnClosing(object sender, FormClosingEventArgs e)
        {

            AudioController.PlaySoundEffect("cancel");
            SessionManager.MainMenuForm.Show();
        }
    }
}
