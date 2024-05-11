using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
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
