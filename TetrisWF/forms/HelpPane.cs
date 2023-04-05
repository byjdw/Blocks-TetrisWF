using AS_Coursework.@internal;
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
