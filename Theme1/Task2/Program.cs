using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число:");
            int number = int.Parse(Console.ReadLine());

            if (number >= 100 && number <= 999)
            {
                int firstDigit = number / 100;
                int secondDigit = (number / 10) % 10;
                int thirdDigit = number % 10;

                if (firstDigit > secondDigit)
                {
                    Console.WriteLine("Первая цифра больше второй.");
                }
                else if (secondDigit > firstDigit)
                {
                    Console.WriteLine("Вторая цифра больше первой.");
                }
                else
                {
                    Console.WriteLine("Первая и вторая цифры равны.");
                }
            }
            else
            {
                Console.WriteLine("Введено не трехзначное число.");
            }

            Console.ReadKey();
        }
    }
}
