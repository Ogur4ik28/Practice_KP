using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomButtonControl
{
    public class ColorChangingButton : Button
    {
        private readonly Random random = new Random();

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = GetRandomColor();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = SystemColors.Control;
        }

        private Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
    }
}
