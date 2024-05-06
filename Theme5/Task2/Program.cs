using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в массиве:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 100);
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Array.Sort(arr);

            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Введите число для бинарного поиска:");
            int k = int.Parse(Console.ReadLine());

            int index = Array.BinarySearch(arr, k);
            if (index >= 0)
            {
                Console.WriteLine($"Число {k} найдено в массиве на позиции {index}");
            }
            else
            {
                Console.WriteLine($"Число {k} не найдено в массиве");
            }

            int oddCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    oddCount++;
                }
            }

            Console.WriteLine($"Количество нечетных чисел в массиве: {oddCount}");

            Console.ReadKey();
        }
    }
}
