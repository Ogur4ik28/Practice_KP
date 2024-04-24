using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string inputText = Console.ReadLine();

            string pattern = @"\""(.*?)\""";

            MatchCollection matches = Regex.Matches(inputText, pattern);

            Console.WriteLine("Слова, окруженные кавычками:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1].Value);
            }

            Console.ReadLine();
        }
    }
}
