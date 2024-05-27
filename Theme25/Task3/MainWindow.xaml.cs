using System;
using System.Text;
using System.Windows;
using System.Windows.Forms.DataVisualization.Charting;
namespace Task3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Chart _chart;

        public MainWindow()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            _chart = new Chart();
            ChartArea chartArea = new ChartArea();
            _chart.ChartAreas.Add(chartArea);
            FormsHost.Child = _chart;
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            double startX, endX, step;

            if (double.TryParse(StartXTextBox.Text, out startX) &&
                double.TryParse(EndXTextBox.Text, out endX) &&
                double.TryParse(StepTextBox.Text, out step))
            {
                StringBuilder dataTableBuilder = new StringBuilder();
                Series series = new Series
                {
                    ChartType = SeriesChartType.Line
                };

                for (double x = startX; x <= endX; x += step)
                {
                    double y = Math.Sin(x)*Math.Cos(x);
                    series.Points.AddXY(x, y);
                }

                _chart.Series.Clear();
                _chart.Series.Add(series);
            }
            else
            {
                MessageBox.Show("Невалидный набор данных");
            }
        }
    }
}
