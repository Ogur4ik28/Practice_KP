using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class File
    {
        private string fileName;
        private DateTime creationDate;
        private long fileSize;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }

        public long FileSize
        {
            get { return fileSize; }
            set
            {
                if (value >= 0)
                    fileSize = value;
                else
                    throw new ArgumentException("Размер файла не может быть отрицательным");
            }
        }

        public File(string fileName, DateTime creationDate, long fileSize)
        {
            if (fileSize >= 0)
            {
                this.fileName = fileName;
                this.creationDate = creationDate;
                this.fileSize = fileSize;
            }
            else
            {
                throw new ArgumentException("Размер файла не может быть отрицательным");
            }
        }

        public void AppendToFile(string additionalInfo)
        {
            Console.WriteLine("Добавляем информацию в конец файла: " + additionalInfo);
        }

        public void GetFileInfo()
        {
            Console.WriteLine($"Имя файла: {fileName}");
            Console.WriteLine($"Дата создания: {creationDate}");
            Console.WriteLine($"Размер файла: {fileSize} байт");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                File myFile = new File("example.txt", DateTime.Now, 1024);

                myFile.GetFileInfo();
                myFile.AppendToFile("Дополнительная информация");

                Console.ReadKey();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
