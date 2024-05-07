using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(CalculateSum);
            Thread thread2 = new Thread(CalculateSum);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Главный поток завершен.");

            Console.ReadKey();
        }

        static void CalculateSum()
        {
            DateTime startTime = DateTime.Now;

            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                Thread.Sleep(100);
            }

            DateTime endTime = DateTime.Now;

            TimeSpan elapsedTime = endTime - startTime;
            long milliseconds = (long)elapsedTime.TotalMilliseconds;

            Console.WriteLine($"Сумма чисел от 1 до 10: {sum}");
            Console.WriteLine($"Поток завершил выполнение за {milliseconds} миллисекунд.");
        }
    }
}
