using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа a1 и b1:");
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите три числа a2, b2 и c2:");
            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());

            bool result = ArePositive(ArePositive(a1, b1), ArePositive(a2, b2, c2));

            Console.WriteLine($"Результат: {result}");

            Console.ReadKey();
        }

        /// <summary>
        /// Проверяет, являются ли оба переданных числа положительными.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>True, если оба числа положительные, иначе False.</returns>
        static bool ArePositive(int a, int b)
        {
            return a > 0 && b > 0;
        }

        /// <summary>
        /// Проверяет, являются ли все переданные числа положительными.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <param name="c">Третье число.</param>
        /// <returns>True, если все числа положительные, иначе False.</returns>
        static bool ArePositive(int a, int b, int c)
        {
            return a > 0 && b > 0 && c > 0;
        }

        /// <summary>
        /// Проверяет, являются ли результаты двух проверок положительными.
        /// </summary>
        /// <param name="result1">Результат первой проверки.</param>
        /// <param name="result2">Результат второй проверки.</param>
        /// <returns>True, если оба результаты положительные, иначе False.</returns>
        static bool ArePositive(bool result1, bool result2)
        {
            return result1 && result2;
        }
    }
}