using System;
using System.IO;

namespace Task13
{
    /// <summary>
    /// Класс, содержащий методы для разделения строк файла на четные и нечетные и записи их в отдельные файлы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод программы.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            string inputFilePath = "input.txt";
            string evenLinesFilePath = "even.txt";
            string oddLinesFilePath = "odd.txt";

            try
            {
                SplitEvenOddLines(inputFilePath, evenLinesFilePath, oddLinesFilePath);
                Console.WriteLine("Четные и нечетные строки успешно записаны в файлы.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Метод для разделения строк файла на четные и нечетные и записи их в отдельные файлы.
        /// </summary>
        /// <param name="inputFilePath">Путь к исходному файлу.</param>
        /// <param name="evenLinesFilePath">Путь к файлу для записи четных строк.</param>
        /// <param name="oddLinesFilePath">Путь к файлу для записи нечетных строк.</param>
        static void SplitEvenOddLines(string inputFilePath, string evenLinesFilePath, string oddLinesFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            using (StreamWriter evenWriter = new StreamWriter(evenLinesFilePath))
            using (StreamWriter oddWriter = new StreamWriter(oddLinesFilePath))
            {
                string line;
                int lineNumber = 1;

                while ((line = reader.ReadLine()) != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        evenWriter.WriteLine(line);
                    }
                    else
                    {
                        oddWriter.WriteLine(line);
                    }

                    lineNumber++;
                }
            }
        }
    }
}
