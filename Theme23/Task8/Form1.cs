using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            // Исходный массив из 15 целых чисел
            int[] numbers = { 10, 5, -3, 8, -7, 2, 0, 9, -4, 6, -1, 3, 4, -6, 1 };

            int count = CountOddPositiveNumbers(numbers);

            MessageBox.Show($"Количество нечетных положительных чисел: {count}");
        }

        private int CountOddPositiveNumbers(int[] numbers)
        {
            int count = 0;
            foreach (int num in numbers)
            {
                if (num > 0 && num % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
