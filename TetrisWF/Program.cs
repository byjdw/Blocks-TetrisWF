using AS_Coursework.forms;
using AS_Coursework.io;
using System;
using System.Windows.Forms;

namespace AS_Coursework
{

    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            /* Reading the players from the file. */
            IOManager.ReadPlayers();
            SprixDocGen.SprixDocGen.gen();
            Application.Run(new Login());
        }
    }
}