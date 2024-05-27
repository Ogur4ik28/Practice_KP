using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        Bitmap banner;
        Rectangle rect;
        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        private int spacing = 50;

        public Form1()
        {
            InitializeComponent();
            try
            {
                banner = new Bitmap("source\\baner.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки баннера: " + ex.ToString(), "Ошибка");
                this.Close();
                return;
            }

            rect = new Rectangle(0, 0, banner.Width, banner.Height);
            timer1.Interval = 50;
            timer1.Tick += Timer1_Tick;
            this.DoubleBuffered = true;
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            this.MouseMove += Form1_MouseMove;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (banner == null) return;

            rect.X -= 1;
            if (Math.Abs(rect.X) > rect.Width + spacing)
                rect.X += rect.Width + spacing;

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (banner == null) return;

            Graphics g = e.Graphics;

            for (int i = 0; i <= this.ClientSize.Width / (rect.Width + spacing) + 1; i++)
            {
                g.DrawImage(banner, rect.X + i * (rect.Width + spacing), rect.Y);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Y < rect.Y + rect.Height) && (e.Y > rect.Y))
            {
                if (!timer1.Enabled)
                    timer1.Enabled = true;
            }
            else
            {
                if (timer1.Enabled)
                    timer1.Enabled = false;
            }
        }
    }
}
