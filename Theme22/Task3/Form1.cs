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
            double f_x = Math.Sin(x);
            double expr1 = f_x + y + z;
            double expr2 = x * y * z;

            double maxExpr = Math.Max(expr1, expr2);
            double minExpr = Math.Min(expr1, expr2);

            return maxExpr / minExpr;
        }
    }
}
