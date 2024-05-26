using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FunctionPlotter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlotButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(StepTextBox.Text, out double h) && h > 0)
            {
                GenerateDataTable(h);
                DrawGraph(h);
            }
            else
            {
                MessageBox.Show("Please enter a valid step value.");
            }
        }

        private void GenerateDataTable(double h)
        {
            double x = 0;
            DataTable.Text = "X\tY\n";
            while (x <= Math.PI * 2)
            {
                double y = Math.Sin(x) * Math.Cos(x);
                DataTable.Text += $"{x:F2}\t{y:F2}\n";
                x += h;
            }
        }

        private void DrawGraph(double h)
        {
            GraphCanvas.Children.Clear();
            double x = 0;
            Point? lastPoint = null;

            while (x <= Math.PI * 2)
            {
                double y = Math.Sin(x) * Math.Cos(x);
                double canvasX = x / (Math.PI * 2) * GraphCanvas.ActualWidth;
                double canvasY = (1 - y) * GraphCanvas.ActualHeight / 2;

                if (lastPoint.HasValue)
                {
                    Line line = new Line
                    {
                        X1 = lastPoint.Value.X,
                        Y1 = lastPoint.Value.Y,
                        X2 = canvasX,
                        Y2 = canvasY,
                        Stroke = Brushes.Black,
                        StrokeThickness = 2
                    };
                    GraphCanvas.Children.Add(line);
                }

                lastPoint = new Point(canvasX, canvasY);
                x += h;
            }
        }
    }
}
