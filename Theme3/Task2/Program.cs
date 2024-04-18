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
            Console.Write("Введитее A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введитее B: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Введитее C: ");
            double C = double.Parse(Console.ReadLine());
            SortDec3(ref A, ref B, ref C);
            Console.WriteLine($"Упорядоченные значения: {A}, {B}, {C}");

            double A1 = 3, B1 = 7, C1 = 1;
            double A2 = 9, B2 = 4, C2 = 6;
            SortDecSets(ref A1, ref B1, ref C1, ref A2, ref B2, ref C2);
            Console.WriteLine($"Упорядоченные значения первого набора: {A1}, {B1}, {C1}");
            Console.WriteLine($"Упорядоченные значения второго набора: {A2}, {B2}, {C2}");

            Console.ReadLine();
        }

        static void SortDec3(ref double A, ref double B, ref double C)
        {
            if (A < B)
                Swap(ref A, ref B);
            if (A < C)
                Swap(ref A, ref C);
            if (B < C)
                Swap(ref B, ref C);
        }

        static void SortDecSets(ref double A1, ref double B1, ref double C1, ref double A2, ref double B2, ref double C2)
        {
            SortDec3(ref A1, ref B1, ref C1);
            SortDec3(ref A2, ref B2, ref C2);
        }

        static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
    }
   
}
