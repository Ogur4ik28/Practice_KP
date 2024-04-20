using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class CustomDivideByZeroException : Exception
    {
        public CustomDivideByZeroException(string message) : base(message)
        {
        }
    }
    internal class Program
    {
        static void genException()
        {
            Console.WriteLine("a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            double b = double.Parse(Console.ReadLine());
            double f = 1;
            try
            {
                for (double i = a; i <= b; ++i)
                {
                    try
                    {
                        f = checked((int)(f * i));
                        if (f - 1 < 0.000001)
                        {
                            throw new CustomDivideByZeroException("Custom DivideByZeroException: Division by very small number");
                        }
                        Console.WriteLine("y({0})={1:f6}", i, 100 / (f - 1));
                    }
                    catch (CustomDivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("ERROR");
                throw;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                genException();
            }
            catch
            {
                Console.WriteLine("НЕИСПРАВИМАЯ ОШИБКА!!!");
            }
        }
    }
}
