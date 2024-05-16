using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    /// <summary>
    /// Делегат для генерации случайных целых чисел.
    /// </summary>
    /// <returns>Случайное целое число.</returns>
    delegate int RandomInt();

    /// <summary>
    /// Главный класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            // Массив делегатов для генерации случайных чисел.
            RandomInt[] delegatesArray =
            {
                () => new Random().Next(1, 101),
                () => new Random().Next(1, 101),
                () => new Random().Next(1, 101)
            };

            // Анонимный метод для вычисления среднего арифметического случайных чисел.
            Func<RandomInt[], double> averageMethod = delegate (RandomInt[] delegates)
            {
                double sum = 0;
                foreach (var del in delegates)
                {
                    sum += del();
                }
                return sum / delegates.Length;
            };

            // Вывод среднего арифметического случайных чисел.
            Console.WriteLine("Среднее арифметическое случайных чисел: " + averageMethod(delegatesArray));

            Console.ReadKey();
        }
    }
}
