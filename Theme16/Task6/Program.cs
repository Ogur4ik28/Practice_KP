using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {

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

        static string[] GetSolutionFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            return lines.Skip(1).ToArray();
        }

        static bool IsSolutionCorrect(string[] correctSolution, string[] studentSolution)
        {
            return string.Join("", correctSolution) == string.Join("", studentSolution);
        }

        static string GetStudentName(string filePath)
        {
            return Path.GetFileNameWithoutExtension(filePath);
        }
    }
}
