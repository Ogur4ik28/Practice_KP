using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelDrawing_Paint(object sender, PaintEventArgs e)
        {
            DrawWatermelon(e.Graphics);
        }

        private void DrawWatermelon(Graphics g)
        {
            // Устанавливаем сглаживание для более плавных линий
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Размеры арбуза
            int width = panelDrawing.Width;
            int height = panelDrawing.Height;

            // Центр и радиус
            Point center = new Point(width / 2, height / 2);
            int radius = Math.Min(width, height) / 2 - 10;

            // Наружная корка арбуза (зеленая)
            Rectangle outerRect = new Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2);
            g.FillEllipse(Brushes.DarkGreen, outerRect);

            // Внутренняя корка арбуза (светло-зеленая)
            int innerRadius = (int)(radius * 0.85);
            Rectangle innerRect = new Rectangle(center.X - innerRadius, center.Y - innerRadius, innerRadius * 2, innerRadius * 2);
            g.FillEllipse(Brushes.LightGreen, innerRect);

            // Мякоть арбуза (красная)
            int pulpRadius = (int)(radius * 0.7);
            Rectangle pulpRect = new Rectangle(center.X - pulpRadius, center.Y - pulpRadius, pulpRadius * 2, pulpRadius * 2);
            g.FillEllipse(Brushes.Red, pulpRect);

            // Семечки арбуза (черные)
            Random rnd = new Random();
            int seedCount = 20;
            for (int i = 0; i < seedCount; i++)
            {
                int seedX = rnd.Next(center.X - pulpRadius, center.X + pulpRadius);
                int seedY = rnd.Next(center.Y - pulpRadius, center.Y + pulpRadius);

                if (Math.Pow(seedX - center.X, 2) + Math.Pow(seedY - center.Y, 2) <= pulpRadius * pulpRadius)
                {
                    Rectangle seedRect = new Rectangle(seedX, seedY, 5, 10);
                    g.FillEllipse(Brushes.Black, seedRect);
                }
            }
        }
    }
}
