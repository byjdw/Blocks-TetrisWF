using AS_Coursework.models;

namespace AS_Coursework.@internal
{
    internal static class SessionManager
    {
        private static Player? currentPlayer;

        public static Player? CurrentPlayer
        {
            set
            {
                currentPlayer = value;
            }
            get
            {
                return currentPlayer;
            }
        }
    }
}
