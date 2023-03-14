using System.Drawing;
using System.Windows.Forms;

namespace AS_Coursework.controls;

public class CircularPictureBox : PictureBox
{
    public CircularPictureBox()
    {
        this.SizeMode = PictureBoxSizeMode.StretchImage;
        Paint += _paint;
    }

    private void _paint(object sender, PaintEventArgs e)
    {
        Rectangle rc = ClientRectangle;
        System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
        gp.AddEllipse(rc);
        Region = new Region(gp);
    }
}