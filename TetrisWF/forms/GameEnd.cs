using AS_Coursework.models;
using System.Windows.Forms;

namespace AS_Coursework.game;

public partial class GameEnd : Form
{
    GameSession session;

    public GameEnd(GameSession session)
    {
        InitializeComponent();
        this.session = session;
        lbl_score.Text = session.Score.ToString() + "!";
    }
}