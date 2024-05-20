using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Singleton
    {
        private static Singleton instance = null;

        private static readonly object lockObject = new object();

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Оба переменных ссылаются на один и тот же экземпляр.");
            }

            singleton1.ShowMessage("Hello, Singleton Pattern!");

            Console.ReadKey();
        }
    }
}
