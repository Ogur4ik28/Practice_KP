using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число n:");
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.");
            }

            int steps = CalculateStepsToReachOne(n);
            Console.WriteLine("Количество шагов до достижения единицы: " + steps);

            Console.ReadKey();
        }

        static int CalculateStepsToReachOne(int n)
        {
            int steps = 0;

            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
                steps++;
            }

            return steps;
        }
    }
}
