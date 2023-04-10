using AS_Coursework.exceptions;
using AS_Coursework.models;
using AS_Coursework.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace AS_Coursework.io
{

    internal static class GameIOManager
    {
        private static List<Player> players = new();

        public static readonly List<Image> Backgrounds = new()
        {
            Resources.background1,
            Resources.background2,
            Resources.background3,
            Resources.background4,
            Resources.background5,
            Resources.background6,
        };

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
            {
                throw new InvalidPlayerException("A player with that username already exists.");
            }

            players.Add(player);
            SavePlayers();
        }

        public static bool DoesPlayerExist(string username)
        {
            return players.Any(player => player.Username == username);
        }

        public static bool IsPasswordCorrect(string password, string storedHash)
        {
            string hashedString = GetHashString(password);
            return (hashedString == storedHash);
        }

        /// <summary>
        ///     It loops through all the players in the list, and if the username of the player in the list matches
        ///     the username of the player passed into the function, it overwrites the player in the list with the
        ///     player passed into the function
        /// </summary>
        /// <param name="Player">The player object you want to overwrite.</param>
        public static void OverwritePlayer(Player player)
        {
            foreach (Player p in players)
            {
                if (p.Username == player.Username)
                {
                    int index = players.IndexOf(p);
                    players[index] = player;
                    break;
                }
            }
        }

        /// <summary>
        ///     It takes the players list and serializes it into a JSON file
        /// </summary>
        public static void SavePlayers()
        {
            try
            {
                using (FileStream stream = new FileStream("PlayerDetails.json", FileMode.Create))
                using (Utf8JsonWriter writer = new Utf8JsonWriter(stream))
                {
                    JsonSerializer.Serialize(writer, players);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        ///     It reads the player details from a JSON file and stores them in a list
        /// </summary>
        public static void ReadPlayers()
        {
            try
            {
                using (FileStream stream = File.OpenRead("PlayerDetails.json"))
                using (StreamReader reader = new StreamReader(stream))
                {
                    players = JsonSerializer.Deserialize<List<Player>>(reader.ReadToEnd());
                }
            }
            catch (FileNotFoundException)
            {
                // File not found. Do nothing.
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
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
            using var algorithm = SHA256.Create();
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