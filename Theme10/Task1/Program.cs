using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    class Notebook
    {
        private string name;
        private int pageCount;

        public Notebook(string name, int pageCount)
        {
            this.name = name;
            this.pageCount = pageCount;
        }

        public string GetName()
        {
            return name;
        }

        public int GetPageCount()
        {
            return pageCount;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Тетрадь: {name}, Количество листов: {pageCount}");
        }

        public virtual double CalculateCost()
        {
            return 15 * pageCount;
        }
    }

    class EnhancedNotebook : Notebook
    {
        private string color;

        public EnhancedNotebook(string name, int pageCount, string color) : base(name, pageCount)
        {
            this.color = color;
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Цвет: {color}");
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 5;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notebook basicNotebook = new Notebook("Простая", 50);
            Console.WriteLine("Базовая тетрадь:");
            basicNotebook.DisplayInfo();
            Console.WriteLine($"Стоимость: {basicNotebook.CalculateCost()}");

            Console.WriteLine();

            EnhancedNotebook enhancedNotebook = new EnhancedNotebook("Цветная", 80, "Синий");
            Console.WriteLine("Улучшенная тетрадь:");
            enhancedNotebook.DisplayInfo();
            Console.WriteLine($"Стоимость: {enhancedNotebook.CalculateCost()}");

            Console.ReadKey();
        }
    }
}
