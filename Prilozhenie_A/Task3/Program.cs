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
            double x = 5.2;

            double y = Math.Pow(Math.Sin(x * x + 5), 2);
            y = Math.Pow(y, 3) - Math.Sqrt(x / 4);

            Console.WriteLine($"{y}");
            Console.ReadKey();
        }
    }
}
