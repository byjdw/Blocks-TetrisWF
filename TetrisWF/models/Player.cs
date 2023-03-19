using System;

namespace AS_Coursework.models;

[Serializable]
public class Player
{
    public Player()
    {
    }

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
        Ticks = 0;
    }

    public string Username { set; get; }

    public string Password { set; get; }

    public string Forename { set; get; }

    public string Surname { set; get; }

    public bool IsGuest { set; get; }

    public int Avatar { set; get; }

    public int HighScore { set; get; }

    public int AllScore { set; get; }

    public int BlocksPlaced { set; get; }

    public int Games { set; get; }

    public int PersonalRecords { set; get; }

    public int Ticks { set; get; }

    public GameState PreviousGameState { set; get; }

    public override string ToString()
    {
        return $"Forename: {Forename}\n" +
               $"Surname: {Surname}\n" +
               $"Username: {Username}\n" +
               $"Password: {Password}";
    }
}