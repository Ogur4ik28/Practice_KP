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
            Console.WriteLine("Введите значение n:");
            int n = int.Parse(Console.ReadLine());

            int result = CalculateF(n);

            Console.WriteLine($"f({n}) = {result}");

            Console.ReadKey();
        }

        static int CalculateF(int n)
        {
            if (n <= 4)
            {
                return 1;
            }
            return n * CalculateF(n - 1);
        }
    }
}
