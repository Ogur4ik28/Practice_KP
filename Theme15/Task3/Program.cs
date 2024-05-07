using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    static class MyListExtensions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
    }

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

            int[] array = myList.GetArray();

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
