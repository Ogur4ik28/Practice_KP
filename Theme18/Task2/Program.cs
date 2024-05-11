using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начало интервала a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите конец интервала b: ");
            int b = int.Parse(Console.ReadLine());

            Queue<int> inRange = new Queue<int>();
            Queue<int> lessThanA = new Queue<int>();
            Queue<int> greaterThanB = new Queue<int>();

            string[] numbers = File.ReadAllLines("input.txt");
            foreach (string numberStr in numbers)
            {
                int number = int.Parse(numberStr);
                if (number >= a && number <= b)
                {
                    inRange.Enqueue(number);
                }
                else if (number < a)
                {
                    lessThanA.Enqueue(number);
                }
                else
                {
                    greaterThanB.Enqueue(number);
                }
            }

            Console.WriteLine("Числа от a до b: ");
            PrintQueue(inRange);
            Console.WriteLine("Числа меньше чем a: ");
            PrintQueue(lessThanA);
            Console.WriteLine("Числа больше чем b: ");
            PrintQueue(greaterThanB);

            Console.ReadKey();
        }

        static void PrintQueue(Queue<int> queue)
        {
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
