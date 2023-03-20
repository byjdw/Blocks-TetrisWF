using System.Windows.Forms;
using AS_Coursework.@internal;
using AS_Coursework.models;

namespace AS_Coursework.game;

public partial class GameEnd : Form
{
    private GameSession session;

    public GameEnd(GameSession session)
    {
        InitializeComponent();
        this.session = session;
        lbl_score.Text = session.Score.ToString();
        var hstxt = lbl_HighScore.Text;
        if (session.Score > SessionManager.CurrentPlayer.HighScore)
        {
            lbl_GameStatus.Text = "Well Done!";
            hstxt = hstxt.Replace("{0}", "greater");
        }
        else
        {
            lbl_GameStatus.Text = "That's too bad...";
            hstxt = hstxt.Replace("{0}", "less");
        }

        hstxt = hstxt.Replace("{1}", SessionManager.CurrentPlayer.HighScore.ToString());
        lbl_HighScore.Text = hstxt;
    }
}