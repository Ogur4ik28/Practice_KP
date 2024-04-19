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
            Console.WriteLine("Введите значение x для вычисления функции f:");

            try
            {
                double x = double.Parse(Console.ReadLine());

                double result;

                if (-1 < x && x < 1)
                {
                    result = x + 14;
                }
                else if (x >= 1)
                {
                    if (Math.Abs(x - 4) < 0.0001)
                    {
                        throw new DivideByZeroException("Знаменатель равен нулю (x-4).");
                    }

                    result = (x - 1) / (x - 4);
                }
                else
                {
                    throw new ArgumentOutOfRangeException("x", "x должен быть больше -1 и меньше 1.");
                }

                Console.WriteLine($"Результат вычисления функции f: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
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
