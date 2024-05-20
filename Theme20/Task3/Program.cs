using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 100 || number > 999)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите трёхзначное число.");
            }

            Task<int> task1 = Task.Factory.StartNew(() =>
            {
                int firstDigit = number / 100;
                int lastDigit = number % 10;
                return firstDigit + lastDigit;
            });

            Task task2 = task1.ContinueWith(antecedentTask =>
            {
                int result = antecedentTask.Result;
                Console.WriteLine($"Сумма первой и последней цифры числа: {result}");
            });

            task2.Wait();

            Console.ReadKey();
        }
    }
}
