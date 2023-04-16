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

        /// <summary>
        ///     This function creates an elliptical region for a control's client rectangle.
        /// </summary>
        /// <param name="sender">The object that raised the event, in this case it is the control that is being
        /// painted.</param>
        /// <param name="PaintEventArgs">PaintEventArgs is an event argument class that contains information
        /// about the Paint event, including the graphics context that can be used to draw on the control or
        /// form. It is typically used in the Paint event handler to perform custom painting on a control or
        /// form.</param>
        private void _paint(object sender, PaintEventArgs e)
        {
            var rc = ClientRectangle;
            var gp = new GraphicsPath();
            gp.AddEllipse(rc);
            Region = new Region(gp);
        }
    }
}