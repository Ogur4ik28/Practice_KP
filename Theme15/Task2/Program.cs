using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyDictionary<TKey, TValue>
    {
        interface IMyDictionary<TKey, TValue>
        {
            void Add(TKey key, TValue value);
            TValue this[TKey key] { get; }
            int Count { get; }
        }

        private List<TKey> keys = new List<TKey>();
        private List<TValue> values = new List<TValue>();

        public void Add(TKey key, TValue value)
        {
            keys.Add(key);
            values.Add(value);
        }

        public TValue this[TKey key]
        {
            get
            {
                int index = keys.IndexOf(key);
                if (index == -1)
                {
                    throw new KeyNotFoundException();
                }
                return values[index];
            }
        }

        public int Count
        {
            get { return keys.Count; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "One");
            myDictionary.Add(2, "Two");
            myDictionary.Add(3, "Three");

            Console.WriteLine("Значение по ключу 2: " + myDictionary[2]);
            Console.WriteLine("Количество пар ключ-значение: " + myDictionary.Count);

            Console.ReadKey();
        }
    }
}
