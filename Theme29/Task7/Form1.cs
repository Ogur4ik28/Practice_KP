using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task7
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer animationTimer;
        private float time = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeAnimationTimer();
        }

        private void InitializeAnimationTimer()
        {
            animationTimer = new System.Windows.Forms.Timer { Interval = 5 };
            animationTimer.Tick += OnAnimationTimerTick;
            animationTimer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawXAxis(e.Graphics);
            DrawMovingCircle(e.Graphics);
        }

        private void DrawXAxis(Graphics graphics)
        {
            graphics.DrawLine(Pens.Black, 0, this.ClientSize.Height / 2, this.ClientSize.Width, this.ClientSize.Height / 2);
        }

        private void DrawMovingCircle(Graphics graphics)
        {
            float x = time;
            float y = (float)Math.Sin(time) * this.ClientSize.Height / 4 + this.ClientSize.Height / 2;
            graphics.FillEllipse(Brushes.Red, x, y, 10, 10);
        }

        private void OnAnimationTimerTick(object sender, EventArgs e)
        {
            time += 0.1f;
            if (time > this.ClientSize.Width)
                time = 0;
            this.Invalidate();
        }
    }
}
