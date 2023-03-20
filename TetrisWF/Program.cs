using AS_Coursework.io;
using System;
using System.Windows.Forms;

namespace AS_Coursework;

internal static class App
{
    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        /* Reading the players from the file. */
        DataManager.ReadPlayers();
        Application.Run(new Splash());
    }
}