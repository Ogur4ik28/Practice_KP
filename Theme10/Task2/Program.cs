using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class A
    {
        private int a = 5;
        private int b = 10;

        public int C
        {
            get { return a + b; }
        }
    }

    class B : A
    {
        private int d = 7;

        public B() { }

        public B(int d)
        {
            this.d = d;
        }

        public int D
        {
            get { return d; }
            set { d = value; }
        }

        public int C2
        {
            get
            {
                int result = 0;
                int i = 0;
                while (i < 5)
                {
                    result += C + D;
                    i++;
                }
                return result;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A objA = new A();
            B objB1 = new B();
            B objB2 = new B(3);

            Console.WriteLine($"Значение свойства C у объекта класса A: {objA.C}");
            Console.WriteLine($"Значение свойства C2 у объекта класса B (собственный конструктор): {objB1.C2}");
            Console.WriteLine($"Значение свойства C2 у объекта класса B (наследуемый конструктор): {objB2.C2}");

            Console.ReadKey();
        }
    }
}
