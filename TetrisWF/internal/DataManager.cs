using AS_Coursework.models;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace AS_Coursework.io;

internal static class DataManager
{
    private static List<Player> players = new List<Player>();

    public static void AddPlayer(Player player)
    {
        players.Add(player);
        SavePlayers();
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
        StringBuilder sb = new StringBuilder();
        foreach (byte b in createHash(inputString))
            sb.Append(b.ToString("X2"));

        return sb.ToString();
    }

    public static void FinishUp()
    {
    }
}