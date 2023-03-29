using System.Windows.Forms;
using AS_Coursework.models;

namespace AS_Coursework.@internal
{
    internal static class SessionManager
    {
        public static Player? CurrentPlayer { set; get; }
        public static Form? SplashForm { set; get; }
        public static Form? MainMenuForm { set; get; }
    }
}