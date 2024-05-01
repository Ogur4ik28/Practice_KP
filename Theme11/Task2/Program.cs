using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class Clothing
    {
        protected string name;

        public Clothing(string name)
        {
            this.name = name;
        }

        public abstract double FabricConsumption();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Название: {name}");
        }
    }

    class Coat : Clothing
    {
        private double size;

        public Coat(string name, double size) : base(name)
        {
            this.size = size;
        }

        public override double FabricConsumption()
        {
            return size / 6.5 + 0.5;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Размер: {size}");
        }
    }

    class Suit : Clothing
    {
        private double height;

        public Suit(string name, double height) : base(name)
        {
            this.height = height;
        }

        public override double FabricConsumption()
        {
            return 2 * height + 0.3;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Рост: {height}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Clothing[] clothes = new Clothing[5];

            clothes[0] = new Coat("Пальто зимнее", 50);
            clothes[1] = new Suit("Костюм офисный", 180);
            clothes[2] = new Coat("Пальто весеннее", 48);
            clothes[3] = new Suit("Костюм вечерний", 175);
            clothes[4] = new Coat("Пальто демисезонное", 52);

            double totalFabricConsumption = 0;
            foreach (Clothing item in clothes)
            {
                item.DisplayInfo();
                Console.WriteLine($"Расход ткани: {item.FabricConsumption()} метров\n");
                totalFabricConsumption += item.FabricConsumption();
            }

            Console.WriteLine($"Суммарный расход ткани: {totalFabricConsumption} метров");

            Console.ReadKey();
        }
    }
}
