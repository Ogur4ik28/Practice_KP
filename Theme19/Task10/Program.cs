using System;
using System.Collections.Generic;
using System.IO;

namespace Task10
{
    /// <summary>
    /// Класс, содержащий метод для подсчета четных чисел в файле.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод программы.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            string filePath = "input.txt";
            int evenCount = CountEvenNumbers(filePath);
            Console.WriteLine("Количество четных чисел: " + evenCount);

            Console.ReadKey();
        }

        /// <summary>
        /// Метод для подсчета четных чисел в файле.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        /// <returns>Количество четных чисел в файле.</returns>
        static int CountEvenNumbers(string filePath)
        {
            int evenCount = 0;

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] numbers = line.Split(' ');

                    foreach (string numberStr in numbers)
                    {
                        if (int.TryParse(numberStr, out int number))
                        {
                            if (number % 2 == 0)
                            {
                                evenCount++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Неверный формат числа: " + numberStr);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден: " + filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }

            return evenCount;
        }
    }
}
