using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            double xStart, xEnd, xStep;
            if (double.TryParse(txtXStart.Text, out xStart) &&
                double.TryParse(txtXEnd.Text, out xEnd) &&
                double.TryParse(txtXStep.Text, out xStep))
            {
                PlotFunction(xStart, xEnd, xStep);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите правильные числовые значения.");
            }
        }

        private void PlotFunction(double xStart, double xEnd, double xStep)
        {
            chart.Series.Clear();
            var series = new Series
            {
                Name = "sin(x) * cos(x)",
                ChartType = SeriesChartType.Line,
                BorderWidth = 2
            };

            for (double x = xStart; x <= xEnd; x += xStep)
            {
                double y = Math.Sin(x) * Math.Cos(x);
                series.Points.AddXY(x, y);
            }

            chart.Series.Add(series);
            chart.ChartAreas[0].RecalculateAxesScale();
        }
    }
}
