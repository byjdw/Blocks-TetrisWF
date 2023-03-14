using System;
using System.Drawing;

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
    }

    public string Username { set; get; }

    public string Password { set; get; }

    public string Forename { set; get; }

    public string Surname { set; get; }

    public bool IsGuest { set; get; }

    public int Avatar { set; get; }

    public GameSession CurrentSession { set; get; }

    public override string ToString()
    {
        return $"Forename: {Forename}\n" +
               $"Surname: {Surname}\n" +
               $"Username: {Username}\n" +
               $"Password: {Password}";
    }
}