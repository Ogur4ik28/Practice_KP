using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Животное питается");
        }

        public void Sleep()
        {
            Console.WriteLine("Животное спит");
        }
    }

    class Mammal : Animal
    {
        public void GiveBirth()
        {
            Console.WriteLine("Млекопитающее рожает потомство");
        }
    }

    class Artiodactyl : Mammal
    {
        public void Walk()
        {
            Console.WriteLine("Парнокопытное ходит");
        }
    }

    class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Птица летит");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Artiodactyl cow = new Artiodactyl();
            cow.Eat();
            cow.Sleep();
            cow.GiveBirth();
            cow.Walk();

            Bird parrot = new Bird();
            parrot.Eat();
            parrot.Sleep();
            parrot.Fly();

            Console.ReadKey();
        }
    }
}
