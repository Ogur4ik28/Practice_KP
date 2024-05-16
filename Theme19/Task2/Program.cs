using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Класс для выполнения сортировки значений.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Введите C: ");
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

        /// <summary>
        /// Метод для упорядочивания трех значений по убыванию.
        /// </summary>
        /// <param name="A">Первое значение.</param>
        /// <param name="B">Второе значение.</param>
        /// <param name="C">Третье значение.</param>
        static void SortDec3(ref double A, ref double B, ref double C)
        {
            if (A < B)
                Swap(ref A, ref B);
            if (A < C)
                Swap(ref A, ref C);
            if (B < C)
                Swap(ref B, ref C);
        }

        /// <summary>
        /// Метод для упорядочивания двух наборов значений по убыванию.
        /// </summary>
        /// <param name="A1">Первое значение первого набора.</param>
        /// <param name="B1">Второе значение первого набора.</param>
        /// <param name="C1">Третье значение первого набора.</param>
        /// <param name="A2">Первое значение второго набора.</param>
        /// <param name="B2">Второе значение второго набора.</param>
        /// <param name="C2">Третье значение второго набора.</param>
        static void SortDecSets(ref double A1, ref double B1, ref double C1, ref double A2, ref double B2, ref double C2)
        {
            SortDec3(ref A1, ref B1, ref C1);
            SortDec3(ref A2, ref B2, ref C2);
        }

        /// <summary>
        /// Метод для обмена значений двух переменных.
        /// </summary>
        /// <param name="a">Первая переменная.</param>
        /// <param name="b">Вторая переменная.</param>
        static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
    }
}
