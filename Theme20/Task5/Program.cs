using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int> { 3, 7, 93, 90 };

            Parallel.ForEach(values, (N, state) =>
            {
                long sum = 0;
                long product = 1;

                for (int i = 1; i <= N; i++)
                {
                    sum += i;
                    product *= i;

                    if (sum > 2000 || product > 1000000)
                    {
                        Console.WriteLine($"Прерывание выполнения для N = {N} при sum = {sum}, product = {product}");
                        state.Break();
                        break;
                    }
                }

                if (!state.IsStopped)
                {
                    Console.WriteLine($"N = {N}: Sum = {sum}, Product = {product}");
                }
            });

            Console.WriteLine("Выполнение завершено.");

            Console.ReadKey();
        }
    }
}
