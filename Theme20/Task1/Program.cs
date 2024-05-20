using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырёхзначное число: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 1000 || number > 9999)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите четырёхзначное число.");
            }

            Task<int> task1 = Task.Factory.StartNew(() => SwapFirstTwoDigits(number));
            task1.Wait();
            Console.WriteLine($"Результат Task 1: {task1.Result}");

            Task<int> task2 = new Task<int>(() => SwapFirstTwoDigits(number));
            task2.Start();
            task2.Wait();
            Console.WriteLine($"Результат Task 2: {task2.Result}");

            Task<int> task3 = Task.Run(() => SwapFirstTwoDigits(number));
            task3.Wait();
            Console.WriteLine($"Результат Task 3: {task3.Result}");

            Console.ReadKey();
        }

        static int SwapFirstTwoDigits(int number)
        {
            string numberStr = number.ToString();
            char[] digits = numberStr.ToCharArray();

            char temp = digits[0];
            digits[0] = digits[1];
            digits[1] = temp;

            int result = int.Parse(new string(digits));
            return result;
        }
    }
}
