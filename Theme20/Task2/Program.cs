using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a (в радианах): ");
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }

            Task<double>[] tasks = new Task<double>[2];

            tasks[0] = Task<double>.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                return 1 - (0.25) * Math.Sin(a) * Math.Sin(a) + Math.Cos(2 * a);
            });

            tasks[1] = Task<double>.Factory.StartNew(() =>
            {
                Thread.Sleep(2000);
                return Math.Cos(a) * Math.Cos(a) + Math.Cos(a) * Math.Cos(a) * Math.Cos(a) * Math.Cos(a);
            });

            Task.WaitAll(tasks);
            Console.WriteLine("Все задачи завершены:");
            Console.WriteLine($"Результат задачи 1 (z1): {tasks[0].Result}");
            Console.WriteLine($"Результат задачи 2 (z2): {tasks[1].Result}");

            Task.WaitAny(tasks);
            Console.WriteLine("Хотя бы одна задача завершена:");
            foreach (var task in tasks)
            {
                if (task.IsCompleted)
                {
                    Console.WriteLine($"Завершённая задача результат: {task.Result}");
                }
            }

            Console.ReadKey();
        }
    }
}
