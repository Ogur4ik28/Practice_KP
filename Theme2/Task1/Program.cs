using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class A
    {
        private int a;
        private int b;

        public A(int aValue, int bValue)
        {
            a = aValue;
            b = bValue;
        }

        public double CalculateExpression()
        {
            return (4.0 / (a + 2)) * b;
        }

        public double CalculateB()
        {
            return Math.Pow(b, 10);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A objA = new A(3,5);

            Console.WriteLine("Значение выражения (4/(a+2))*b: " + objA.CalculateExpression());
            Console.WriteLine("Значение b в степени 10: " + objA.CalculateB());

            Console.ReadKey();
        }
    }
}
