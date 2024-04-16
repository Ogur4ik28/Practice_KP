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
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());


            double x = (a + b) / 2;

            x = Math.Round(x, 3);
            Console.WriteLine($"{x}");

            Console.ReadKey();
        }
    }
}
