using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            int firstDigit = number / 100;

            int lastDigit = number % 10;

            int sum = firstDigit + lastDigit;

            Console.WriteLine($"Сумма первой и последней цифр числа {number} равна {sum}");

            Console.ReadKey();
        }
    }
}
