using AS_Coursework.forms;
using AS_Coursework.io;
using System;
using System.IO;
using System.Windows.Forms;

namespace AS_Coursework
{
    internal static class Program
    {
    /// <summary>
    /// The Main function initializes the application configuration, reads player data, and launches the
    /// login screen, with error handling in case of exceptions.
    /// </summary>
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
                DialogResult choice = MessageBox.Show("An error occurred: " + e.Message
                    + "\nWould you like to delete PlayerDetails.json and try relaunching the application?",
                    "Blocks · Error", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    File.Delete("./PlayerDetails.json");
                    Main();
                } else
                {
                    Environment.Exit(1);
                }
            }
        }
    }
}
