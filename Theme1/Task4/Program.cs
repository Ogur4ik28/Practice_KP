using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите способ решения задачи:");
            Console.WriteLine("1. Цикл while");
            Console.WriteLine("2. Цикл do while");
            Console.WriteLine("3. Цикл for");
            Console.Write("Введите номер способа (1, 2 или 3): ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите 1, 2 или 3.");
            }

            switch (choice)
            {
                case 1:
                    FindNumbersWithDuplicateDigitsWhile();
                    break;
                case 2:
                    FindNumbersWithDuplicateDigitsDoWhile();
                    break;
                case 3:
                    FindNumbersWithDuplicateDigitsFor();
                    break;
            }
            Console.ReadKey();
        }

        static void FindNumbersWithDuplicateDigitsWhile()
        {
            int number = 100;

            while (number <= 999)
            {
                int digit1 = number / 100;
                int digit2 = (number / 10) % 10;
                int digit3 = number % 10;

                if (digit1 == digit2 || digit1 == digit3 || digit2 == digit3)
                {
                    Console.Write($"{number} ");
                }

                number++;
            }
        }

        static void FindNumbersWithDuplicateDigitsDoWhile()
        {
            int number = 100;

            do
            {
                int digit1 = number / 100;
                int digit2 = (number / 10) % 10;
                int digit3 = number % 10;

                if (digit1 == digit2 || digit1 == digit3 || digit2 == digit3)
                {
                    Console.Write($"{number} ");
                }

                number++;
            } while (number <= 999);
        }

        static void FindNumbersWithDuplicateDigitsFor()
        {
            for (int number = 100; number <= 999; number++)
            {
                int digit1 = number / 100;
                int digit2 = (number / 10) % 10;
                int digit3 = number % 10;

                if (digit1 == digit2 || digit1 == digit3 || digit2 == digit3)
                {
                    Console.Write($"{number} ");
                }
            }

            
        }
    }
}
