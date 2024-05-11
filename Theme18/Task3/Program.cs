using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Harvest<T>
    {
        private List<T> items;

        public Harvest()
        {
            items = new List<T>();
        }

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void RemoveItem(T item)
        {
            items.Remove(item);
        }

        public Harvest<T> Clone()
        {
            Harvest<T> clonedHarvest = new Harvest<T>();
            foreach (T item in items)
            {
                clonedHarvest.AddItem(item);
            }
            return clonedHarvest;
        }

        public void DisplayItems()
        {
            Console.WriteLine("Урожай:");
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Harvest<string> stringHarvest = new Harvest<string>();

            stringHarvest.AddItem("Яблоки");
            stringHarvest.AddItem("Груши");
            stringHarvest.AddItem("Сливы");

            stringHarvest.DisplayItems();

            stringHarvest.RemoveItem("Сливы");

            Harvest<string> clonedHarvest = stringHarvest.Clone();

            clonedHarvest.DisplayItems();

            Console.ReadKey();
        }
    }
}
