using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    interface Ix
    {
        void IxF0(double param);
        void IxF1();
    }

    interface Iy
    {
        void F0(double param);
        void F1();
    }

    interface Iz
    {
        void F0(double param);
        void F1();
    }

    class TestClass : Ix, Iy, Iz
    {
        private double w;

        public TestClass(double w)
        {
            this.w = w;
        }

        public void IxF0(double param)
        {
            Console.WriteLine($"IxF0: {Math.Cos(w)}");
        }

        public void IxF1()
        {
            Console.WriteLine($"IxF1: {Math.Cos(w)}");
        }

        public void F0(double param)
        {
            Console.WriteLine($"F0 (неявная): {Math.Exp(w)}");
        }

        public void F1()
        {
            Console.WriteLine($"F1 (неявная): {Math.Exp(w)}");
        }

        void Iz.F0(double param)
        {
            Console.WriteLine($"F0 (явная): {1 / Math.Exp(w)}");
        }

        void Iz.F1()
        {
            Console.WriteLine($"F1 (явная): {1 / Math.Exp(w)}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestClass obj = new TestClass(1.0);

            ((Iy)obj).F0(1.0);
            ((Iy)obj).F1();
            ((Iz)obj).F0(1.0);
            ((Iz)obj).F1();

            Ix objAsIx = obj;
            objAsIx.IxF0(1.0);
            objAsIx.IxF1();

            Console.ReadKey();
        }
    }
}
