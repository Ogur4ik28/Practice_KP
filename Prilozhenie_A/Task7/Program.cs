using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a :");
            double a = double.Parse(Console.ReadLine());

            double z1 = (Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a)) / (Math.Cos(a) - Math.Cos(3 * a) + Math.Cos(5 * a));

            double z2 = 2 * Math.Sin(a);

            Console.WriteLine($"Значение z1 = {z1}");
            Console.WriteLine($"Значение z2 = {z2}");

            Console.ReadKey();
        }
    }
}
