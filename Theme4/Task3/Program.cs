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
            try
            {
                DigitCountSum(12345);
                DigitCountSum(987654321);
                DigitCountSum(1000);
                DigitCountSum(123);
                DigitCountSum(999999);
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

        static void DigitCountSum(int K)
        {
            if (K <= 0)
            {
                throw new ArgumentException("Число должно быть положительным.");
            }

            int C = 0;
            int S = 0;
            int number = K;

            while (number > 0)
            {
                int digit = number % 10;
                C++;
                S += digit;
                number /= 10;
            }

            Console.WriteLine($"Для числа {K}: количество цифр = {C}, сумма цифр = {S}");
        }
    }
}
