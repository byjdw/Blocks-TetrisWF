using AS_Coursework.@internal;
using AS_Coursework.io;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            DataManager.PlaySoundEffect("cancel");
            SessionManager.MainMenuForm.Show();
        }
    }
}
