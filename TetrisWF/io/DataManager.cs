using AS_Coursework.exceptions;
using AS_Coursework.models;
using AS_Coursework.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace AS_Coursework.io
{

    internal static class DataManager
    {
        private static List<Player> players = new();

        public static readonly List<Image> Tiles = new()
        {
            Resources.Board_Square,
            Resources.Board_Line,
            Resources.Board_T,
            Resources.Board_Z,
            Resources.Board_S,
            Resources.Board_L,
            Resources.Board_Reverse_L
        };

        public static readonly List<Image> Previews = new()
        {
            Resources.Preview_Square,
            Resources.Preview_Line,
            Resources.Preview_T,
            Resources.Preview_Z,
            Resources.Preview_S,
            Resources.Preview_L,
            Resources.Preview_Reverse_L
        };

        public static readonly List<Image> Avatars = new()
        {
            Resources.Avatar_L,
            Resources.Avatar_Line,
            Resources.Avatar_Reverse_L,
            Resources.Avatar_S,
            Resources.Avatar_Square,
            Resources.Avatar_T,
            Resources.Avatar_Z,
            Resources.Guest
        };

        /// <summary>
        ///     It adds a player to the list of players, then saves the list of players
        /// </summary>
        /// <param name="Player">The player object that you want to add to the list.</param>
        public static void AddPlayer(Player player)
        {
            if (DoesPlayerExist(player.Username))
                throw new InvalidPlayerException("A player with that username already exists.");
            players.Add(player);
            SavePlayers();
        }

        public static bool DoesPlayerExist(string username)
        {
            foreach (var player in players)
                if (player.Username == username)
                    return true;
            return false;
        }

        public static bool IsPasswordCorrect(string password, string storedHash)
        {
            var valid = false;
            var hashedString = GetHashString(password);
            if (hashedString == storedHash) valid = true;
            return valid;
        }

        /// <summary>
        ///     It loops through all the players in the list, and if the username of the player in the list matches
        ///     the username of the player passed into the function, it overwrites the player in the list with the
        ///     player passed into the function
        /// </summary>
        /// <param name="Player">The player object you want to overwrite.</param>
        public static void OverwritePlayer(Player player)
        {
            for (var i = 0; i < GetPlayers().Count; i++)
                if (GetPlayers()[i].Username == player.Username)
                    players[i] = player;
        }

        /// <summary>
        ///     It takes the players list and serializes it into a JSON file
        /// </summary>
        public static void SavePlayers()
        {
            Stream fileStream;
            try
            {
                File.WriteAllText("PlayerDetails.json", JsonSerializer.Serialize(players));
            }
            catch (IOException e)
            {
                MessageBox.Show("" + e.Message);
            }
        }

        /// <summary>
        ///     It reads the player details from a JSON file and stores them in a list
        /// </summary>
        public static void ReadPlayers()
        {
            try
            {
                try
                {
                    players = JsonSerializer.Deserialize<List<Player>>(File.ReadAllText("PlayerDetails.json"));
                }
                catch (IOException e)
                {
                    MessageBox.Show("" + e.Message);
                }
            }
            catch (IOException e)
            {
                if (!e.Message.ToLower().Contains("find"))
                    MessageBox.Show("" + e.Message);
            }
        }

        /// <summary>
        ///     It returns a list of players
        /// </summary>
        /// <returns>
        ///     The list of players.
        /// </returns>
        public static List<Player> GetPlayers()
        {
            return players;
        }

        /// <summary>
        ///     It takes a string, converts it to a byte array, and then hashes it using the SHA256 algorithm
        /// </summary>
        /// <param name="inputString">The string to be hashed.</param>
        /// <returns>
        ///     A byte array.
        /// </returns>
        public static byte[] CreateHash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        /// <summary>
        ///     It takes a string, creates a hash of it, and returns the hash as a string
        /// </summary>
        /// <param name="inputString">The string to be hashed.</param>
        /// <returns>
        ///     A string of hexadecimal characters.
        /// </returns>
        public static string GetHashString(string inputString)
        {
            var sb = new StringBuilder();
            foreach (var b in CreateHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}