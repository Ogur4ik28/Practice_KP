using System;
using System.Windows.Forms;

namespace ExpressionCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBoxX.Text);
                double y = double.Parse(textBoxY.Text);
                double z = double.Parse(textBoxZ.Text);

                double result = CalculateExpression(x, y, z);

                resultLabel.Text = "Result: " + result.ToString("G6");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }

        private double CalculateExpression(double x, double y, double z)
        {
            double numerator1 = Math.Pow(y, x + 1);
            double denominator1 = Math.Pow(3, Math.Sqrt(Math.Abs(y - 2))) + 3;
            double numerator2 = (x + y / 2);
            double denominator2 = 2 * Math.Abs(x + y);
            double part1 = numerator1 / denominator1 + numerator2 / denominator2;
            double part2 = Math.Pow(x + 1, -1 / Math.Sin(z));

            return part1 * part2;
        }
    }
}
