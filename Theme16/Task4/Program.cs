using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
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
