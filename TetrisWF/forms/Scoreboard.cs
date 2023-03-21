using AS_Coursework.io;
using AS_Coursework.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AS_Coursework.forms;

public partial class Scoreboard : Form
{
    public Scoreboard()
    {
        InitializeComponent();
        List<Player> sortedPlayerArray = new List<Player>(DataManager.getPlayers());
        sortedPlayerArray.Sort((b, a) => a.HighScore.CompareTo(b.HighScore));
        List<String> names = new List<String>();
        foreach (Player player in sortedPlayerArray)
        {
            names.Add($"{player.Username} - {player.HighScore}");
        }
        label1.Text = String.Join("\n", names.ToArray());
    }
}