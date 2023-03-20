using AS_Coursework.models;
using AS_Coursework.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace AS_Coursework.io;

internal static class DataManager
{
    private static List<Player> players = new();

    public readonly static List<Image> Tiles = new List<Image>()
    {
        Resources.Board_Square,
        Resources.Board_Line,
        Resources.Board_T,
        Resources.Board_Z,
        Resources.Board_S,
        Resources.Board_L,
        Resources.Board_Reverse_L
    };

    public readonly static List<Image> Previews = new List<Image>()
    {
        Resources.Preview_Square,
        Resources.Preview_Line,
        Resources.Preview_T,
        Resources.Preview_Z,
        Resources.Preview_S,
        Resources.Preview_L,
        Resources.Preview_Reverse_L
    };

    public readonly static List<Image> Avatars = new List<Image>()
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

    public static void AddPlayer(Player player)
    {
        players.Add(player);
        SavePlayers();
    }

    public static void OverwritePlayer(Player player)
    {
        for (var i = 0; i < getPlayers().Count; i++)
            if (getPlayers()[i].Username == player.Username)
                players[i] = player;
    }

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

    public static List<Player> getPlayers()
    {
        return players;
    }

    public static byte[] createHash(string inputString)
    {
        HashAlgorithm algorithm = SHA256.Create();
        return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
    }

    public static string getHashString(string inputString)
    {
        var sb = new StringBuilder();
        foreach (var b in createHash(inputString))
            sb.Append(b.ToString("X2"));

        return sb.ToString();
    }

    public static void FinishUp()
    {
    }
}