using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = Math.PI / 3;
            double B = 3 * Math.PI / 2;
            int M = 15;

            double H = (B - A) / M;

            Console.WriteLine("Вычисление значений функции y = cos(x^2) на отрезке [{0}, {1}] с шагом {2:F2}:", A, B, H);

            double x = A;
            while (x <= B)
            {
                double y = Math.Cos(x * x);
                Console.WriteLine("F({0:F2}) = {1:F4}", x, y);
                x += H;
            }

            Console.ReadKey();
        }
    }
}
