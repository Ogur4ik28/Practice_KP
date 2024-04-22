using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[] arr = new int[n];
            int elemCount = 0;
            int elemSum = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 100);
            }

            Console.WriteLine("массив: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 5 == 0)
                {
                    elemCount += 1;
                    elemSum += arr[i];
                }
            }
            if (elemCount != 0)
            {
                double average = elemSum / elemCount;
                Console.WriteLine($"среднее арифметическое чисел, кратных 5: {average}");
            }
            else
            {
                Console.WriteLine($"нет элементов кратных 5");
            }

            Console.ReadKey();
        }
    }
}
