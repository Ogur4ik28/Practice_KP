using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Класс для выполнения программы по вычислению функции и выводу результатов.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
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

            // Выполнение цикла для вычисления функции и вывода результатов.
            for (double x = a; x <= b; x += h)
            {
                double fx = CalculateFunction(x);
                Console.WriteLine($"{x}\t| {fx}");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Метод для вычисления значения функции f(x) = x^2.
        /// </summary>
        /// <param name="x">Значение аргумента x.</param>
        /// <returns>Значение функции в точке x.</returns>
        static double CalculateFunction(double x)
        {
            return x * x;
        }
    }
}