using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace UserInterface
{
    public class RoundedPictureBox:PictureBox
    {

        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region=new System.Drawing.Region(path);
            base.OnPaint(pe);
        }
    }
}
