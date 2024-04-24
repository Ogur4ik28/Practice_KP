using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string inputText = Console.ReadLine();

            string pattern = @"\b[a-zA-Z0-9]+\b";

            MatchCollection matches = Regex.Matches(inputText, pattern);

            Console.WriteLine("Слова, состоящие только из букв и цифр:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            Console.ReadLine();
        }
    }
}
