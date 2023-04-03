using AS_Coursework.models;
using System.Windows.Forms;

namespace AS_Coursework.@internal
{
    internal static class SessionManager
    {
        private static bool debugMode;
        public static bool DebugMode
        {
            get { return debugMode; }
            set
            {
                if (value != null) debugMode = (bool)value;
            }
        }
        public static Player? CurrentPlayer { set; get; }
        public static Form? SplashForm { set; get; }
        public static Form? MainMenuForm { set; get; }
    }
}