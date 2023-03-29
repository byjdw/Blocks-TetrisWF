using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AS_Coursework.controls
{

    public class CircularPictureBox : PictureBox
    {
        public CircularPictureBox()
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
            Paint += _paint;
        }

        private void _paint(object sender, PaintEventArgs e)
        {
            var rc = ClientRectangle;
            var gp = new GraphicsPath();
            gp.AddEllipse(rc);
            Region = new Region(gp);
        }
    }
}