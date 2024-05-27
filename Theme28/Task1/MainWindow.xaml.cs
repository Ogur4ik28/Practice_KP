using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            DrawGraphics(drawingCanvas);
        }

        private void DrawGraphics(Canvas canvas)
        {
            // Нарисовать треугольник
            var triangle = CreatePolygon(new PointCollection
            {
                new Point(50, 0),
                new Point(0, 100),
                new Point(100, 100)
            }, Brushes.Black, 10, 10);
            canvas.Children.Add(triangle);

            // Нарисовать эллипс
            var ellipse = CreateEllipse(100, 50, Brushes.Black, null, 120, 10);
            canvas.Children.Add(ellipse);

            // Нарисовать закрашенный круг
            var filledCircle = CreateEllipse(100, 100, null, Brushes.Blue, 200, 10);
            canvas.Children.Add(filledCircle);

            // Нарисовать закрашенный прямоугольник
            var filledRectangle = CreateRectangle(100, 50, null, Brushes.Green, 320, 10);
            canvas.Children.Add(filledRectangle);

            // Нарисовать сектор
            var sector = CreateSector(new Point(100, 100), new Point(200, 100), new Point(150, 50), 50, Brushes.Red, 400, 10);
            canvas.Children.Add(sector);

            // Нарисовать три концентрических круга
            DrawConcentricCircles(canvas, 3, 50, 50, 200);

            // Нарисовать серию из семи квадратов
            DrawSeriesOfSquares(canvas, 7, 30, 50, 2, 150, 10, 400);

            // Нарисовать шахматную доску
            DrawCheckerboard(canvas, 8, 20, 20, 300, 10, 200);
        }

        private Polygon CreatePolygon(PointCollection points, Brush stroke, double top, double left)
        {
            var polygon = new Polygon
            {
                Points = points,
                Stroke = stroke
            };
            Canvas.SetTop(polygon, top);
            Canvas.SetLeft(polygon, left);
            return polygon;
        }

        private Ellipse CreateEllipse(double width, double height, Brush stroke, Brush fill, double top, double left)
        {
            var ellipse = new Ellipse
            {
                Width = width,
                Height = height,
                Stroke = stroke,
                Fill = fill
            };
            Canvas.SetTop(ellipse, top);
            Canvas.SetLeft(ellipse, left);
            return ellipse;
        }

        private Rectangle CreateRectangle(double width, double height, Brush stroke, Brush fill, double top, double left)
        {
            var rectangle = new Rectangle
            {
                Width = width,
                Height = height,
                Stroke = stroke,
                Fill = fill
            };
            Canvas.SetTop(rectangle, top);
            Canvas.SetLeft(rectangle, left);
            return rectangle;
        }

        private Path CreateSector(Point startPoint, Point lineEndPoint, Point arcPoint, double size, Brush fill, double top, double left)
        {
            var path = new Path { Fill = fill };
            var figure = new PathFigure { StartPoint = startPoint };
            figure.Segments.Add(new LineSegment(lineEndPoint, true));
            figure.Segments.Add(new ArcSegment(arcPoint, new Size(size, size), 0, false, SweepDirection.Clockwise, true));
            figure.Segments.Add(new LineSegment(startPoint, true));
            path.Data = new PathGeometry(new[] { figure });
            Canvas.SetTop(path, top);
            Canvas.SetLeft(path, left);
            return path;
        }

        private void DrawConcentricCircles(Canvas canvas, int count, double centerX, double centerY, double offsetX)
        {
            for (int i = 0; i < count; i++)
            {
                var circle = CreateEllipse(100 + i * 20, 100 + i * 20, Brushes.Black, null, centerY - i * 10, centerX - i * 10 + offsetX);
                circle.StrokeThickness = 2;
                canvas.Children.Add(circle);
            }
        }

        private void DrawSeriesOfSquares(Canvas canvas, int count, double width, double height, double strokeThickness, double topOffset, double leftOffset, double offsetX)
        {
            for (int i = 0; i < count; i++)
            {
                var square = CreateRectangle(width, height, Brushes.Black, null, topOffset + i * 35, leftOffset + i * 15 + offsetX);
                square.StrokeThickness = strokeThickness;
                canvas.Children.Add(square);
            }
        }

        private void DrawCheckerboard(Canvas canvas, int size, double squareWidth, double squareHeight, double topOffset, double leftOffset, double offsetX)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var square = CreateRectangle(squareWidth, squareHeight, null, (i + j) % 2 == 0 ? Brushes.Black : Brushes.White, topOffset + i * squareHeight, leftOffset + j * squareWidth + offsetX);
                    canvas.Children.Add(square);
                }
            }
        }
    }
}
