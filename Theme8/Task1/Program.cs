using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    struct ZNAK
    {
        public string firstName;
        public string lastName;
        public string zodiacSign;
        public int[] birthDate;

        public ZNAK(string firstName, string lastName, string zodiacSign, int[] birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.zodiacSign = zodiacSign;
            this.birthDate = birthDate;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ZNAK[] people = new ZNAK[8];

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"Введите информацию о {i + 1}-м человеке:");
                Console.Write("Фамилия: ");
                string lastName = Console.ReadLine();
                Console.Write("Имя: ");
                string firstName = Console.ReadLine();
                Console.Write("Знак зодиака: ");
                string zodiacSign = Console.ReadLine();
                int[] birthDate = new int[3];
                Console.Write("Дата рождения (день месяц год): ");
                string[] dateParts = Console.ReadLine().Split();
                for (int j = 0; j < 3; j++)
                {
                    birthDate[j] = int.Parse(dateParts[j]);
                }
                people[i] = new ZNAK(firstName, lastName, zodiacSign, birthDate);
            }

            Array.Sort(people, (x, y) => {
                int result = x.birthDate[2].CompareTo(y.birthDate[2]);
                if (result == 0)
                {
                    result = x.birthDate[1].CompareTo(y.birthDate[1]);
                    if (result == 0)
                    {
                        result = x.birthDate[0].CompareTo(y.birthDate[0]);
                    }
                }
                return result;
            });

            Console.Write("Введите фамилию для поиска: ");
            string searchLastName = Console.ReadLine();
            bool found = false;
            foreach (var person in people)
            {
                if (person.lastName == searchLastName)
                {
                    Console.WriteLine($"Информация о человеке с фамилией {searchLastName}:");
                    Console.WriteLine($"Имя: {person.firstName}");
                    Console.WriteLine($"Знак зодиака: {person.zodiacSign}");
                    Console.WriteLine($"Дата рождения: {person.birthDate[0]} {person.birthDate[1]} {person.birthDate[2]}");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine($"Человек с фамилией {searchLastName} не найден.");
            }

            Console.ReadKey();
        }
    }
}
