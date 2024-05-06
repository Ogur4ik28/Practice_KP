using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> Add = (x, y) => x + y;
            Func<double, double, double> Sub = (x, y) => x - y;
            Func<double, double, double> Mul = (x, y) => x * y;
            Func<double, double, double> Div = (x, y) =>
            {
                if (y == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                    return double.NaN;
                }
                else
                {
                    return x / y;
                }
            };

            Console.WriteLine("Выберите операцию: ");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;

            switch (choice)
            {
                case 1:
                    result = Add(num1, num2);
                    Console.WriteLine($"Результат сложения: {result}");
                    break;
                case 2:
                    result = Sub(num1, num2);
                    Console.WriteLine($"Результат вычитания: {result}");
                    break;
                case 3:
                    result = Mul(num1, num2);
                    Console.WriteLine($"Результат умножения: {result}");
                    break;
                case 4:
                    result = Div(num1, num2);
                    if (!double.IsNaN(result))
                        Console.WriteLine($"Результат деления: {result}");
                    break;
                default:
                    Console.WriteLine("Ошибка: Некорректный выбор операции.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
