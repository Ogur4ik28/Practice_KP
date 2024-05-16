using System;
using System.IO;

namespace Task14
{
    /// <summary>
    /// Класс, содержащий методы для работы с файлами, содержащими случайные числа.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод программы.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            string f1Path = "f1.dat";
            string f2Path = "f2.dat";

            CreateRandomNumberFile(f1Path, 20); // 20 чисел в f1.dat
            CreateRandomNumberFile(f2Path, 15); // 15 чисел в f2.dat

            FindClosestToMinInF2(f2Path);

            ComparePositiveNegativeZero(f1Path, f2Path);

            CheckAscendingOrder(f1Path);

            CheckAlternatingSequence(f1Path);

            Console.ReadKey();
        }

        /// <summary>
        /// Создает файл с случайными числами.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        /// <param name="count">Количество чисел.</param>
        static void CreateRandomNumberFile(string filePath, int count)
        {
            Random random = new Random();
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                for (int i = 0; i < count; i++)
                {
                    int number = random.Next(-100, 101);
                    writer.Write(number);
                }
            }
        }

        /// <summary>
        /// Находит число в файле f2.dat, наиболее близкое к минимальному числу.
        /// </summary>
        /// <param name="filePath">Путь к файлу f2.dat.</param>
        static void FindClosestToMinInF2(string filePath)
        {
            int minValue = int.MaxValue;
            int closestValue = 0;

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    int number = reader.ReadInt32();
                    if (number < minValue)
                    {
                        minValue = number;
                        closestValue = number;
                    }
                }
            }

            Console.WriteLine($"Наиболее близкое к минимальному числу в файле f2.dat: {closestValue}");
        }

        /// <summary>
        /// Сравнивает количество положительных, отрицательных и нулевых чисел в файлах f1.dat и f2.dat.
        /// </summary>
        /// <param name="filePath1">Путь к файлу f1.dat.</param>
        /// <param name="filePath2">Путь к файлу f2.dat.</param>
        static void ComparePositiveNegativeZero(string filePath1, string filePath2)
        {
            int positiveCountF1 = 0, negativeCountF1 = 0, zeroCountF1 = 0;
            int positiveCountF2 = 0, negativeCountF2 = 0, zeroCountF2 = 0;

            using (BinaryReader reader = new BinaryReader(File.Open(filePath1, FileMode.Open)))
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    int number = reader.ReadInt32();
                    if (number > 0)
                        positiveCountF1++;
                    else if (number < 0)
                        negativeCountF1++;
                    else
                        zeroCountF1++;
                }
            }

            using (BinaryReader reader = new BinaryReader(File.Open(filePath2, FileMode.Open)))
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    int number = reader.ReadInt32();
                    if (number > 0)
                        positiveCountF2++;
                    else if (number < 0)
                        negativeCountF2++;
                    else
                        zeroCountF2++;
                }
            }

            string fileWithMorePositive = positiveCountF1 > positiveCountF2 ? "f1.dat" : "f2.dat";
            string fileWithMoreNegative = negativeCountF1 > negativeCountF2 ? "f1.dat" : "f2.dat";
            string fileWithMoreZero = zeroCountF1 > zeroCountF2 ? "f1.dat" : "f2.dat";

            Console.WriteLine($"Больше всего положительных чисел в файле: {fileWithMorePositive}");
            Console.WriteLine($"Больше всего отрицательных чисел в файле: {fileWithMoreNegative}");
            Console.WriteLine($"Больше всего нулевых чисел в файле: {fileWithMoreZero}");
        }

        /// <summary>
        /// Проверяет, упорядочены ли числа в файле f1.dat по возрастанию.
        /// </summary>
        /// <param name="filePath">Путь к файлу f1.dat.</param>
        static void CheckAscendingOrder(string filePath)
        {
            int previousNumber = int.MinValue;
            bool isAscending = true;

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    int number = reader.ReadInt32();
                    if (number < previousNumber)
                    {
                        isAscending = false;
                        break;
                    }
                    previousNumber = number;
                }
            }

            if (isAscending)
                Console.WriteLine("Числа в файле f1.dat упорядочены по возрастанию.");
            else
                Console.WriteLine("Числа в файле f1.dat не упорядочены по возрастанию.");
        }

        /// <summary>
        /// Проверяет, образуют ли числа в файле f1.dat знакопеременную последовательность.
        /// </summary>
        /// <param name="filePath">Путь к файлу f1.dat.</param>
        static void CheckAlternatingSequence(string filePath)
        {
            bool isAlternating = true;

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                int previousSign = Math.Sign(reader.ReadInt32());
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    int sign = Math.Sign(reader.ReadInt32());
                    if (sign == previousSign)
                    {
                        isAlternating = false;
                        break;
                    }
                    previousSign = sign;
                }
            }

            if (isAlternating)
                Console.WriteLine("Числа в файле f1.dat образуют знакопеременную последовательность.");
            else
                Console.WriteLine("Числа в файле f1.dat не образуют знакопеременную последовательность.");
        }
    }
}
