using AS_Coursework.@internal;
using System.Windows.Forms;

namespace AS_Coursework.forms;

public partial class SettingsPane : Form
{
    public SettingsPane()
    {
        InitializeComponent();
    }

    private void btn_Exit_Click(object sender, System.EventArgs e)
    {
        Close();
        SessionManager.MainMenuForm.Show();
    }
}