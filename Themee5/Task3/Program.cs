using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность квадратной матрицы (N < 10):");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите диапазон случайных чисел [a, b]:");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rand.Next(a, b + 1);
                }
            }

            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrix);

            int positiveSquaresSum = CalculatePositiveSquaresSum(matrix);
            Console.WriteLine($"Сумма квадратов положительных чисел: {positiveSquaresSum}");

            int[] rowSums = CalculateRowSums(matrix);
            Console.WriteLine("Суммы элементов каждой строки:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Строка {i + 1}: {rowSums[i]}");
            }

            Console.ReadKey();
        }

        public static void PrintMatrix(int[,] matrix)
        {
            int N = matrix.GetLength(0);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int CalculatePositiveSquaresSum(int[,] matrix)
        {
            int N = matrix.GetLength(0);
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sum += matrix[i, j] * matrix[i, j];
                    }
                }
            }
            return sum;
        }
        public static int[] CalculateRowSums(int[,] matrix)
        {
            int N = matrix.GetLength(0);
            int[] rowSums = new int[N];
            for (int i = 0; i < N; i++)
            {
                int sum = 0;
                for (int j = 0; j < N; j++)
                {
                    sum += matrix[i, j];
                }
                rowSums[i] = sum;
            }
            return rowSums;
        }
    }
}
