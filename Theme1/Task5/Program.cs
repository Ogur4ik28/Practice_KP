using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N (1 <= N <= 20):");
            int N;

            while (!int.TryParse(Console.ReadLine(), out N) || N < 1 || N > 20)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число от 1 до 20.");
            }

            double sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += 1.0 / i;
            }

            Console.WriteLine("Сумма 1 + 1/2 + 1/3 + ... + 1/{0} = {1:F4}", N, sum);

            Console.ReadKey();
        }
    }
}
