using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task1
{
    class Program
    {
        static AutoResetEvent firstDone = new AutoResetEvent(false);
        static AutoResetEvent secondDone = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(FirstThread);
            Thread thread2 = new Thread(SecondThread);
            Thread thread3 = new Thread(ThirdThread);

            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.Normal;
            thread3.Priority = ThreadPriority.Lowest;

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine("Главный поток завершен.");

            Console.ReadKey();
        }

        static void FirstThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Первый поток: {i}");
                secondDone.Set();
                firstDone.WaitOne();
                Thread.Sleep(100);
            }
        }

        static void SecondThread()
        {
            secondDone.WaitOne();
            for (int i = 10; i < 20; i++)
            {
                Console.WriteLine($"Второй поток: {i}");
                firstDone.Set();
                secondDone.WaitOne();
                Thread.Sleep(200);
            }
        }

        static void ThirdThread()
        {
            secondDone.WaitOne();
            for (int i = 20; i < 30; i++)
            {
                Console.WriteLine($"Третий поток: {i}");
                firstDone.Set();
                secondDone.WaitOne();
                Thread.Sleep(300);
            }
        }
    }
}
