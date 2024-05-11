using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "input.txt";
            int evenCount = CountEvenNumbers(filePath);
            Console.WriteLine("Количество четных чисел: " + evenCount);

            Console.ReadKey();
        }

        static int CountEvenNumbers(string filePath)
        {
            int evenCount = 0;

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] numbers = line.Split(' ');

                    foreach (string numberStr in numbers)
                    {
                        if (int.TryParse(numberStr, out int number))
                        {
                            if (number % 2 == 0)
                            {
                                evenCount++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Неверный формат числа: " + numberStr);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден: " + filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }

            return evenCount;
        }
    }
}
