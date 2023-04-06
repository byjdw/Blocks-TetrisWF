using AS_Coursework.forms;
using AS_Coursework.io;
using System;
using System.Windows.Forms;

namespace AS_Coursework
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                GameIOManager.ReadPlayers();
                Application.Run(new Login());
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred: " + e.Message
                    + "\nPlease delete PlayerDetails.json and try relaunching the application.");
                Environment.Exit(1);
            }
        }
    }
}
