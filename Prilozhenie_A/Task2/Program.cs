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
            Console.Write("Введите четырехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            int firstDigit = number / 1000;
            int secondDigit = (number / 100) % 10;
            int otherDigits = number % 100;

            int result = secondDigit * 1000 + firstDigit * 100 + otherDigits;

            Console.WriteLine("Число, образуемое при перестановке двух первых цифр: " + result);
            Console.ReadKey();
        }
    }
}
