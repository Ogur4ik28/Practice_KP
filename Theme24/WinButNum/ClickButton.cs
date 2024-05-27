using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinButNum
{
    public class ClickButton : Button
    {
        private int mClicks;

        public int Clicks
        {
            get { return mClicks; }
        }

        protected override void OnClick(EventArgs e)
        {
            mClicks++;
            base.OnClick(e);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            SizeF stringsize = g.MeasureString(Clicks.ToString(), Font, Width);
            g.DrawString(Clicks.ToString(), Font, SystemBrushes.ControlText,
                Width - stringsize.Width - 3, Height - stringsize.Height - 3);
        }
    }
}
