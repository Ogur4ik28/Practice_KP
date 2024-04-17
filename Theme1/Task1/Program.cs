using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());

            double y = 0;

            if (x > 2)
            {
                y = Math.Pow(x, 3)*Math.Sqrt(x-2);
            }
            else if (x == 2)
            {
                y = x * Math.Sin(2 * x);
            }
            else
            {
                y = Math.Pow(Math.E,-2*x) * Math.Cos(2*x);
            }

            Console.WriteLine($"y = {y}");

            Console.ReadKey();
        }
    }
}
