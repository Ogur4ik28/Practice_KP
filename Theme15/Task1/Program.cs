using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MyList<T>
    {
        private T[] items;
        private int count;

        public MyList()
        {
            items = new T[4];
            count = 0;
        }

        public void Add(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }

            items[count] = item;
            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }

                return items[index];
            }
        }

        public int Count
        {
            get { return count; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            Console.WriteLine("Элемент по индексу 0: " + myList[0]);
            Console.WriteLine("Количество элементов: " + myList.Count);

            Console.ReadKey();
        }
    }
}
