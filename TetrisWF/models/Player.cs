using AS_Coursework.exceptions;
using AS_Coursework.io;
using System;

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
        private GameState? previousGameState;
        private string surname;
        private int ticks;
        private string username;
        private int clearedLines;

        public Player() { }

        public string Username
        {
            get => username;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidPlayerException("Username cannot be empty.");
                if (GameIOManager.DoesPlayerExist(value))
                    throw new InvalidPlayerException("Username is already in use.");
                username = value;
            }
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public string Forename
        {
            get => forename;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidPlayerException("Forename cannot be empty.");
                forename = value;
            }
        }

        public string Surname
        {
            get => surname;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidPlayerException("Surname cannot be empty.");
                surname = value;
            }
        }

        public bool IsGuest
        {
            get => isGuest;
            set => isGuest = value;
        }

        public int Avatar
        {
            get => avatar;
            set
            {
                if (value < 0 || value >= GameIOManager.Avatars.Count)
                    throw new InvalidPlayerException("Avatar index is out of range.");
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

        public GameState? PreviousGameState
        {
            get => previousGameState;
            set => previousGameState = value;
        }

        public void ClearGameState()
        {
            previousGameState = null;
        }
    }
}