using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string inputText = Console.ReadLine();

            string pattern = @"\b\w*[aeiouаеёиоуыэюя]\b";

            MatchCollection matches = Regex.Matches(inputText, pattern);

            Console.WriteLine("Слова, оканчивающиеся на гласную букву:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            Console.ReadLine();
        }
    }
}
