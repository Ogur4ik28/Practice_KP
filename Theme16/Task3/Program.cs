using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "input.txt";

            CreateTextFile(filePath);

            Console.WriteLine("Содержимое файла:");
            DisplayFileContent(filePath);

            CountLinesAndCharacters(filePath);

            string newFilePath = "new_input.txt";
            DeleteLastLine(filePath, newFilePath);

            Console.Write("Введите s1 и s2: ");
            int s1 = int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());
            DisplayLinesInRange(filePath, s1, s2);

            int maxLength = FindLongestLine(filePath);
            Console.WriteLine("Длина самой длинной строки: " + maxLength);

            Console.Write("Введите букву: ");
            char startingLetter = char.Parse(Console.ReadLine());
            Console.WriteLine($"Строки начинающаяся на букву {startingLetter}: ");
            DisplayLinesStartingWith(filePath, startingLetter);

            string reversedFilePath = "reversed_string_input.txt";
            ReverseLinesInFile(filePath, reversedFilePath);

            Console.ReadKey();
        }

        static void CreateTextFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Short line");
                writer.WriteLine("A bit longer line");
                writer.WriteLine("This line is longer than the others");
                writer.WriteLine("Another line here with some text");
                writer.WriteLine("The longest line in this file");
            }
        }

        static void DisplayFileContent(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        static void CountLinesAndCharacters(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine("Количество строк: " + lines.Length);
            foreach (string line in lines)
            {
                Console.WriteLine("Количество символов в строке \"" + line + "\": " + line.Length);
            }
        }

        static void DeleteLastLine(string filePath, string newFilePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length > 1)
            {
                string[] newLines = new string[lines.Length - 1];

                Array.Copy(lines, newLines, lines.Length - 1);

                File.WriteAllLines(newFilePath, newLines);

                Console.WriteLine("Последняя строка удалена. Результат записан в файл: " + newFilePath);
            }
            else
            {
                Console.WriteLine("Файл содержит только одну строку. Нечего удалять.");
            }
        }

        static void DisplayLinesInRange(string filePath, int s1, int s2)
        {
            string[] lines = File.ReadAllLines(filePath);
            for (int i = s1; i <= s2; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }

        static int FindLongestLine(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int maxLength = 0;
            foreach (string line in lines)
            {
                if (line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
            }
            return maxLength;
        }

        static void DisplayLinesStartingWith(string filePath, char startingLetter)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (line.Length > 0 && char.ToUpper(line[0]) == char.ToUpper(startingLetter))
                {
                    Console.WriteLine(line);
                }
            }
        }

        static void ReverseLinesInFile(string filePath, string reversedFilePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            Array.Reverse(lines);
            File.WriteAllLines(reversedFilePath, lines);
            Console.WriteLine("Строки файла были переписаны в другой файл в обратном порядке: " + reversedFilePath);
        }
    }
}
