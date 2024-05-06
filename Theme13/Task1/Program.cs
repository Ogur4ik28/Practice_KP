using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    delegate double MathFunction(double x);
    class Program
    {
        static void Main(string[] args)
        {
            MathFunction mathDelegate = CalculateFunction1;
            mathDelegate += CalculateFunction2;
            mathDelegate += CalculateFunction3;

            foreach (MathFunction function in mathDelegate.GetInvocationList())
            {
                try
                {
                    double result = function(5.0);
                    Console.WriteLine($"Результат: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при выполнении функции: {ex.Message}");
                }
            }

            Console.ReadKey();
        }

        static double CalculateFunction1(double x)
        {
            if (x == 0)
                throw new ArgumentException("Аргумент не может быть равен нулю.");

            return 1 / x;
        }

        static double CalculateFunction2(double x)
        {
            return Math.Sqrt(x);
        }

        static double CalculateFunction3(double x)
        {
            if (x < 0)
                throw new ArgumentException("Аргумент не может быть отрицательным.");

            return Math.Log(x);
        }
    }
}
