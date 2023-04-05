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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HelpPane_FormClosing(object sender, FormClosingEventArgs e)
        {

            AudioController.PlaySoundEffect("cancel");
            SessionManager.MainMenuForm.Show();
        }
    }
}
