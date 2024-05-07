using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число N:");
            int N = int.Parse(Console.ReadLine());

            Thread thread1 = new Thread(() =>
            {
                long result1 = CalculateSum(A, N);
                Console.WriteLine($"Результат первого метода: {result1}");
            });
            thread1.Start();

            long result2 = CalculateProduct(A, N);
            Console.WriteLine($"Результат второго метода: {result2}");

            Console.WriteLine("Главный поток завершен.");

            Console.ReadKey();
        }

        static long CalculateSum(int A, int N)
        {
            long sum = 0;
            long power = 1;
            for (int i = 0; i <= N; i++)
            {
                sum += power;
                power *= A;
                Thread.Sleep(100);
            }
            return sum;
        }

        static long CalculateProduct(int A, int N)
        {
            long product = 1;
            long power = A;
            for (int i = 0; i < N; i++)
            {
                product *= power;
                power *= A;
                Thread.Sleep(100);
            }
            return product;
        }
    }
}
