using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task4
{
    class Program
    {
        static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static int numberOfThreads = 4;
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[numberOfThreads];
            int[] partialSums = new int[numberOfThreads];

            for (int i = 0; i < numberOfThreads; i++)
            {
                int threadIndex = i;
                threads[i] = new Thread(() =>
                {
                    partialSums[threadIndex] = CalculatePartialSum(threadIndex);
                });
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            int totalSum = 0;
            foreach (int sum in partialSums)
            {
                totalSum += sum;
            }

            Console.WriteLine($"Сумма четных чисел в массиве: {totalSum}");
            Console.WriteLine("Главный поток завершен.");

            Console.ReadKey();
        }

        static int CalculatePartialSum(int threadIndex)
        {
            int partialSum = 0;
            for (int i = threadIndex; i < numbers.Length; i += numberOfThreads)
            {
                if (numbers[i] % 2 == 0)
                {
                    partialSum += numbers[i];
                }
            }
            return partialSum;
        }
    }
}
