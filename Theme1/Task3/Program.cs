using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер вагона:");
            int wagonNumber = int.Parse(Console.ReadLine());

            if (wagonNumber >= 1 && wagonNumber <= 17)
            {
                if (wagonNumber >= 10 && wagonNumber <= 17)
                {
                    Console.WriteLine("Купейный вагон");
                }
                else
                {
                    Console.WriteLine("Плацкартный вагон");
                }
            }
            else
            {
                Console.WriteLine("Вагон с таким номером отсутствует.");
            }

            Console.ReadKey();
        }
    }
}
