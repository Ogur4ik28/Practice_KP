using System;
using System.IO;

namespace Task11
{
    /// <summary>
    /// Класс, содержащий метод для создания новой папки.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод программы.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            string folderPath = "New_folder";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Папка успешно создана: " + folderPath);
            }
            else
            {
                Console.WriteLine("Папка уже существует: " + folderPath);
            }

            Console.ReadKey();
        }
    }
}
