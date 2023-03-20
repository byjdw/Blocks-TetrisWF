using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using AS_Coursework.models;

namespace AS_Coursework.io;

internal static class DataManager
{
    private static List<Player> players = new();

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