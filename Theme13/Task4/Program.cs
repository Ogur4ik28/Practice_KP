using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class EventPublisher
    {
        public delegate void MyEventHandler(object sender, EventArgs e);

        public event MyEventHandler MyEvent;

        public void RaiseEvent()
        {
            MyEvent?.Invoke(this, EventArgs.Empty);
        }
    }

    class Observer1
    {
        public void EventHandler1(object sender, EventArgs e)
        {
            Console.WriteLine("Обработчик события от Observer1 вызван!");
        }
    }

    class Observer2
    {
        public void EventHandler2(object sender, EventArgs e)
        {
            Console.WriteLine("Обработчик события от Observer2 вызван!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();
            Observer1 observer1 = new Observer1();
            Observer2 observer2 = new Observer2();

            publisher.MyEvent += observer1.EventHandler1;
            publisher.MyEvent += observer2.EventHandler2;
            publisher.MyEvent += observer1.EventHandler1;

            publisher.RaiseEvent();

            Console.WriteLine("\nПосле удаления одного обработчика:\n");

            publisher.MyEvent -= observer1.EventHandler1;

            publisher.RaiseEvent();

            Console.ReadKey();
        }
    }
}
