using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawGraphics(e.Graphics);
        }

        private void DrawGraphics(Graphics g)
        {
            // Рисуем треугольник
            Point[] trianglePoints = { new Point(50, 0), new Point(0, 100), new Point(100, 100) };
            g.DrawPolygon(Pens.Black, trianglePoints);

            // Рисуем эллипс
            g.DrawEllipse(Pens.Black, new Rectangle(120, 120, 100, 50));

            // Рисуем закрашенный круг
            g.FillEllipse(Brushes.Blue, new Rectangle(240, 240, 100, 100));

            // Рисуем закрашенный прямоугольник
            g.FillRectangle(Brushes.Green, new Rectangle(360, 360, 100, 50));

            // Рисуем сектор
            g.FillPie(Brushes.Red, new Rectangle(480, 480, 100, 100), 0, 120);

            // Рисуем три концентрических круга
            DrawConcentricCircles(g, 3, new Point(400, 150), 40);

            // Рисуем серию из семи квадратов
            DrawSeriesOfSquares(g, 7, new Point(200, 300), 30, 20);

            // Рисуем шахматную доску
            DrawCheckerboard(g, new Point(400, 400), 8, 20);
        }

        private void DrawConcentricCircles(Graphics g, int count, Point center, int initialRadius)
        {
            for (int i = 0; i < count; i++)
            {
                int radius = initialRadius + i * 20;
                g.DrawEllipse(Pens.Black, new Rectangle(center.X - radius, center.Y - radius, 2 * radius, 2 * radius));
            }
        }

        private void DrawSeriesOfSquares(Graphics g, int count, Point startPoint, int size, int offset)
        {
            for (int i = 0; i < count; i++)
            {
                g.DrawRectangle(Pens.Black, new Rectangle(startPoint.X + i * offset, startPoint.Y + i * offset, size, size));
            }
        }

        private void DrawCheckerboard(Graphics g, Point startPoint, int gridSize, int cellSize)
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    Brush brush = (i + j) % 2 == 0 ? Brushes.Black : Brushes.White;
                    g.FillRectangle(brush, new Rectangle(startPoint.X + j * cellSize, startPoint.Y + i * cellSize, cellSize, cellSize));
                }
            }
        }
    }
}
