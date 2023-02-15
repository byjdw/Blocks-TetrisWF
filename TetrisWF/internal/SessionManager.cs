using AS_Coursework.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
