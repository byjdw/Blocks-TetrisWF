using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Coursework.models
{
    [Serializable]
    internal class Player
    {
        private string username, password, forename, surname;
        bool isGuest;
        private Image? avatar;
        private GameSession? currentSession;

        public string Username
        {
            set
            {
                username = value;
            }
            get
            {
                return username;
            }
        }

        public string Password
        {
            set
            {
                password = value;
            }
            get
            {
                return password;
            }
        }

        public string Forename
        {
            set
            {
                forename = value;
            }
            get
            {
                return forename;
            }
        }

        public string Surname
        {
            set
            {
                surname = value;
            }
            get
            {
                return surname;
            }
        }

        public bool IsGuest
        {
            set {
                isGuest = value;
            }
            get
            {
                return isGuest;
            }
        }

        public Image Avatar
        {
            set
            {
                avatar = value;
            }
            get
            {
                return avatar;
            }
        }

        public GameSession CurrentSession
        {
            set
            {
                currentSession = value;
            }
            get
            {
                return currentSession;
            }
        }

        public Player()
        {

        }

        public Player(string username, string password, string forename, string surname, Image avatar)
        {
            Username = username;
            Password = password;
            Forename = forename;
            Surname = surname;
            Avatar = avatar;
            isGuest = false;
        }

        public override string ToString()
        {
            return $"Forename: {forename}\n" +
                $"Surname: {surname}\n" +
                $"Username: {username}\n" +
                $"Password: {Password}";
        }
    }
}
