using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите расстояние до дачи в километрах: ");
            double distance = double.Parse(Console.ReadLine());

            Console.Write("Введите расход топлива вашего автомобиля на 100 км пробега (в литрах): ");
            double fuelConsumption = double.Parse(Console.ReadLine());

            Console.Write("Введите цену одного литра бензина: ");
            double fuelPrice = double.Parse(Console.ReadLine());

            double tripCost = distance * (2 * (fuelConsumption / 100)) * fuelPrice;

            Console.WriteLine($"Стоимость поездки на дачу (туда и обратно) составляет {tripCost} рублей.");

            Console.ReadKey();
        }
    }
}
