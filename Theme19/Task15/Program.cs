//16.6
using System;
using System.IO;

namespace Task15
{
    /// <summary>
    /// Класс, содержащий методы для сравнения решений студентов с правильным решением.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод программы.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            string folderPath = @"C:\Users\User\source\repos\practiсe_kp\Theme16\Task6\bin\Debug\StudentsSolutions";
            string outputPath = Path.Combine(folderPath, "output.txt");
            string resultsPath = Path.Combine(folderPath, "results.txt");

            try
            {
                string[] correctSolution = GetSolutionFromFile(outputPath);

                string[] studentFiles = Directory.GetFiles(folderPath, "student*.txt");

                using (StreamWriter resultsWriter = new StreamWriter(resultsPath))
                {
                    foreach (string studentFile in studentFiles)
                    {
                        string[] studentSolution = GetSolutionFromFile(studentFile);

                        if (IsSolutionCorrect(correctSolution, studentSolution))
                        {
                            string studentName = GetStudentName(studentFile);
                            resultsWriter.WriteLine(studentName);
                        }
                    }
                }

                Console.WriteLine("Файл results.txt успешно создан.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Получает решение из файла.
        /// </summary>
        /// <param name="filePath">Путь к файлу с решением.</param>
        /// <returns>Массив строк, содержащий решение.</returns>
        static string[] GetSolutionFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            return lines.Skip(1).ToArray();
        }

        /// <summary>
        /// Проверяет, является ли решение студента правильным.
        /// </summary>
        /// <param name="correctSolution">Правильное решение.</param>
        /// <param name="studentSolution">Решение студента.</param>
        /// <returns>True, если решение студента совпадает с правильным, иначе false.</returns>
        static bool IsSolutionCorrect(string[] correctSolution, string[] studentSolution)
        {
            return string.Join("", correctSolution) == string.Join("", studentSolution);
        }

        /// <summary>
        /// Получает имя студента из имени файла.
        /// </summary>
        /// <param name="filePath">Путь к файлу студента.</param>
        /// <returns>Имя студента.</returns>
        static string GetStudentName(string filePath)
        {
            return Path.GetFileNameWithoutExtension(filePath);
        }
    }
}
