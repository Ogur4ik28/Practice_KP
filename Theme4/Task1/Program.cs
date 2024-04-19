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
            Console.WriteLine("Введите значение x для вычисления выражения y = 4 - (x-7)/(4-x):");
            try
            {
                double x = double.Parse(Console.ReadLine());

                if (x == 4)
                {
                    throw new DivideByZeroException("Знаменатель равен нулю (4-x).");
                }

                double y = 4 - (x - 7) / (4 - x);
                Console.WriteLine($"Результат выражения: y = {y}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.WriteLine("\nВведите значение x для вычисления выражения y = sin(x)/(x^3-1):");
            try
            {
                double x = double.Parse(Console.ReadLine());

                if (Math.Abs(Math.Pow(x, 3) - 1) < 0.0001)
                {
                    throw new DivideByZeroException("Знаменатель равен нулю (x^3-1).");
                }

                double y = Math.Sin(x) / (Math.Pow(x, 3) - 1);
                Console.WriteLine($"Результат выражения: y = {y}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
