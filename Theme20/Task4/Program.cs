using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 5;
            int B = -8;

            int start = Math.Min(A, B);
            int end = Math.Max(A, B);

            double[] results = new double[end - start + 1];

            Parallel.For(0, results.Length, i =>
            {
                int x = start + i;
                results[i] = Math.Cos(x * x);
            });

            for (int i = 0; i < results.Length; i++)
            {
                int x = start + i;
                Console.WriteLine($"Cos({x}^2) = {results[i]}");
            }

            Console.ReadKey();
        }
    }
}
