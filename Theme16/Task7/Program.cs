using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Список файлов на диске C:");
            ListFilesInDirectory("C:\\");

            string destinationDirectory = @"D:\Example_36tp";
            Directory.CreateDirectory(destinationDirectory);
            Console.WriteLine($"Каталог {destinationDirectory} создан успешно.");

            string sourceDirectory = @"C:\Users\User\Documents\Тестирование";
            CopyFiles(sourceDirectory, destinationDirectory, 3);
            Console.WriteLine("Файлы успешно скопированы.");

            ChangeAttributesAndCreateLinks(destinationDirectory);
            Console.WriteLine("Атрибуты файлов изменены, и созданы файлы ссылок.");

            Console.WriteLine("Готово.");

            Console.ReadKey();
        }

        static void ListFilesInDirectory(string directoryPath)
        {
            try
            {
                string[] files = Directory.GetFiles(directoryPath);
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void CopyFiles(string sourceDirectory, string destinationDirectory, int numberOfFiles)
        {
            try
            {
                string[] files = Directory.GetFiles(sourceDirectory);
                Random random = new Random();
                for (int i = 0; i < numberOfFiles; i++)
                {
                    string sourceFile = files[random.Next(files.Length)];
                    string destinationFile = Path.Combine(destinationDirectory, Path.GetFileName(sourceFile));
                    File.Copy(sourceFile, destinationFile);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при копировании файлов: {ex.Message}");
            }
        }

        static void ChangeAttributesAndCreateLinks(string directoryPath)
        {
            try
            {
                string[] files = Directory.GetFiles(directoryPath);
                foreach (string file in files)
                {
                    File.SetAttributes(file, File.GetAttributes(file) | FileAttributes.Hidden);

                    string linkFilePath = Path.Combine(directoryPath, $"{Path.GetFileNameWithoutExtension(file)}.lnk");
                    using (StreamWriter writer = new StreamWriter(linkFilePath))
                    {
                        writer.WriteLine($"Ссылка на файл: {file}");
                    }

                    File.Delete(file);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при изменении атрибутов и создании ссылок: {ex.Message}");
            }
        }
    }
}
