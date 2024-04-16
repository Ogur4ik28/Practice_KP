using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите скорость лодки в стоячей воде (км/ч): ");
            double v = double.Parse(Console.ReadLine());

            Console.Write("Введите скорость течения реки (км/ч): ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Введите время движения по озеру (ч): ");
            double t1 = double.Parse(Console.ReadLine());

            Console.Write("Введите время движения против течения реки (ч): ");
            double t2 = double.Parse(Console.ReadLine());

            double S = (v - v1) * t1 + (v + v1) * t2;

            Console.WriteLine($"Путь, пройденный лодкой, составляет {S} км.");
            Console.ReadKey();
        }
    }
}
