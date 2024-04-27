using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class PostWorker
    {
        public string Name { get; set; }
        public int HoursWorked { get; set; }

        public PostWorker(string name, int hoursWorked)
        {
            Name = name;
            HoursWorked = hoursWorked;
        }
    }

    class Accountant
    {
        public bool AskForBonus(PostWorker worker, int hours)
        {
            if (worker.HoursWorked > hours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PostWorker worker1 = new PostWorker("Иван", 180);

            Accountant accountant = new Accountant();

            bool bonus = accountant.AskForBonus(worker1, 160);

            if (bonus)
            {
                Console.WriteLine($"Сотруднику {worker1.Name} положена премия.");
            }
            else
            {
                Console.WriteLine($"Сотруднику {worker1.Name} премия не положена.");
            }

            Console.ReadKey();
        }
    }
}
