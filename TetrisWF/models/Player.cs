using System;

namespace AS_Coursework.models;

[Serializable]
public class Player
{
    /* A default constructor. It is used to create an instance of the class. */
    public Player() { }

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

    /// <summary>
    /// The ToString() function is a method that is used to return a string representation of the object
    /// </summary>
    /// <returns>
    /// The ToString() method is being overridden to return the values of the properties.
    /// </returns>
    public override string ToString()
    {
        return $"Forename: {Forename}\n" +
               $"Surname: {Surname}\n" +
               $"Username: {Username}\n" +
               $"Password: {Password}";
    }
}