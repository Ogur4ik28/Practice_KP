using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    delegate int RandomInt();
    class Program
    {
        static void Main(string[] args)
        {
            RandomInt[] delegatesArray =
            {
            () => new Random().Next(1, 101),
            () => new Random().Next(1, 101),
            () => new Random().Next(1, 101)
            };

            Func<RandomInt[], double> averageMethod = delegate (RandomInt[] delegates)
            {
                double sum = 0;
                foreach (var del in delegates)
                {
                    sum += del();
                }
                return sum / delegates.Length;
            };

            Console.WriteLine("Среднее арифметическое случайных чисел: " + averageMethod(delegatesArray));

            Console.ReadKey();
        }
    }
}
