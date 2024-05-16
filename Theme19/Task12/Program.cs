using System;
using System.IO;

namespace Task12
{
    /// <summary>
    /// Класс, содержащий набор методов для работы с текстовыми файлами.
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

        /// <summary>
        /// Создает текстовый файл и записывает в него строки.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
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

        /// <summary>
        /// Выводит содержимое текстового файла в консоль.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        static void DisplayFileContent(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        /// <summary>
        /// Подсчитывает количество строк и количество символов в каждой строке файла.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        static void CountLinesAndCharacters(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine("Количество строк: " + lines.Length);
            foreach (string line in lines)
            {
                Console.WriteLine("Количество символов в строке \"" + line + "\": " + line.Length);
            }
        }

        /// <summary>
        /// Удаляет последнюю строку из файла и записывает результат в новый файл.
        /// </summary>
        /// <param name="filePath">Путь к исходному файлу.</param>
        /// <param name="newFilePath">Путь к новому файлу.</param>
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

        /// <summary>
        /// Выводит строки файла с номерами от s1 до s2 (включительно).
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        /// <param name="s1">Начальный номер строки.</param>
        /// <param name="s2">Конечный номер строки.</param>
        static void DisplayLinesInRange(string filePath, int s1, int s2)
        {
            string[] lines = File.ReadAllLines(filePath);
            for (int i = s1; i <= s2; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }

        /// <summary>
        /// Находит длину самой длинной строки в файле.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        /// <returns>Длина самой длинной строки.</returns>
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

        /// <summary>
        /// Выводит строки файла, начинающиеся с указанной буквы.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        /// <param name="startingLetter">Буква, с которой должны начинаться строки.</param>
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

        /// <summary>
        /// Переписывает строки файла в обратном порядке и записывает их в новый файл.
        /// </summary>
        /// <param name="filePath">Путь к исходному файлу.</param>
        /// <param name="reversedFilePath">Путь к новому файлу с перевернутыми строками.</param>
        static void ReverseLinesInFile(string filePath, string reversedFilePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            Array.Reverse(lines);
            File.WriteAllLines(reversedFilePath, lines);
            Console.WriteLine("Строки файла были переписаны в другой файл в обратном порядке: " + reversedFilePath);
        }
    }
}
