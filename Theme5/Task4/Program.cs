using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 100);
            }

            Console.WriteLine("Массив:");
            PrintArray(arr);

            double average = CalculateAverage(arr);
            Console.WriteLine($"Среднее значение всех элементов массива: {average}");

            int closestIndex = FindClosestElementIndex(arr, average);
            Console.WriteLine($"Индекс элемента, наиболее близкого к среднему значению: {closestIndex}");

            int sum = CalculateSum(arr);
            Console.WriteLine($"Сумма всех элементов массива: {sum}");

            bool isFourDigit = sum >= 1000 && sum <= 9999;
            Console.WriteLine($"Сумма значений элементов массива является четырехзначным числом: {isFourDigit}");

            Console.ReadKey();
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public static double CalculateAverage(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return (double)sum / arr.Length;
        }

        public static int FindClosestElementIndex(int[] arr, double target)
        {
            double minDifference = Math.Abs(arr[0] - target);
            int closestIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                double difference = Math.Abs(arr[i] - target);
                if (difference < minDifference)
                {
                    minDifference = difference;
                    closestIndex = i;
                }
            }
            return closestIndex;
        }

        public static int CalculateSum(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }
    }
}
