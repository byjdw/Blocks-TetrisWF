using System;
using AS_Coursework.exceptions;
using AS_Coursework.io;
using AS_Coursework.models;

namespace AS_Coursework.models
{

    [Serializable]
    public class Player
    {
        private int allScore;
        private int avatar;
        private int blocksPlaced;
        private string forename;
        private int games;
        private int highScore;
        private bool isGuest;
        private string password;
        private int personalRecords;
        private GameState previousGameState;
        private string surname;
        private int ticks;
        private string username;
        private int clearedLines;

        /* A default constructor. It is used to create an instance of the class. */
        public Player()
        {
        }

        /* This is a paramaterised constructor. It is used to create an instance of the class. */
        public Player(string username, string password, string forename, string surname, int avatar)
        {
            Username = username;
            Password = password;
            Forename = forename;
            Surname = surname;
            Avatar = avatar;
            IsGuest = false;
            HighScore = 0;
            AllScore = 0;
            BlocksPlaced = 0;
            Games = 0;
            PersonalRecords = 0;
            ClearedLines = 0;
        }

        public string Username
        {
            get => username;
            set
            {
                if (value.Length == 0) throw new InvalidPlayerException("Username cannot be empty.");
                if (DataManager.DoesPlayerExist(value)) throw new InvalidPlayerException("Username is already in use.");
                username = value;
            }
        }

        public string Password
        {
            get 
            { 
                return password; 
            } 
            set
            {
                password = value;
            }
        }

        public string Forename
        {
            get => forename;
            set
            {
                if (value.Length == 0) throw new InvalidPlayerException("Forename cannot be empty.");
                forename = value;
            }
        }

        public string Surname
        {
            get => surname;
            set
            {
                if (value.Length == 0) throw new InvalidPlayerException("Surname cannot be empty.");
                surname = value;
            }
        }

        public bool IsGuest
        {
            get
            {
                return isGuest;
            }
            set
            {
                isGuest = value;
            }
        }

        public int Avatar
        {
            get => avatar;
            set
            {
                if (
                    value < 0
                    || value > DataManager.Avatars.Count
                ) throw new InvalidPlayerException("Avatar index is out of range.");
                avatar = value;
            }
        }

        public int HighScore
        {
            get => highScore;
            set => highScore = value;
        }

        public int AllScore
        {
            get => allScore;
            set => allScore = value;
        }

        public int BlocksPlaced
        {
            get => blocksPlaced;
            set => blocksPlaced = value;
        }

        public int Games
        {
            get => games;
            set => games = value;
        }

        public int PersonalRecords
        {
            get => personalRecords;
            set => personalRecords = value;
        }

        public int ClearedLines
        {
            get => clearedLines;
            set => clearedLines = value;
        }

        public GameState PreviousGameState
        {
            get => previousGameState;
            set => previousGameState = value;
        }

        /// <summary>
        ///     The ToString() function is a method that is used to return a string representation of the object
        /// </summary>
        /// <returns>
        ///     The ToString() method is being overridden to return the values of the properties.
        /// </returns>
        public override string ToString()
        {
            return $"Forename: {Forename}\n" +
                   $"Surname: {Surname}\n" +
                   $"Username: {Username}\n" +
                   $"Password: {Password}";
        }
    }
}