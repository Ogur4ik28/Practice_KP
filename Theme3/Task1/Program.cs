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
            Console.WriteLine("Введите начальное значение a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите конечное значение b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите шаг h:");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("x\t| f(x)");
            Console.WriteLine("------------------");

            for (double x = a; x <= b; x += h)
            {
                double fx = CalculateFunction(x);
                Console.WriteLine($"{x}\t| {fx}");
            }

            Console.ReadKey();
        }

        static double CalculateFunction(double x)
        {
            return x * x;
        }
    }
}
