using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string inputText = Console.ReadLine();

            string pattern = @"\b\w*qu\w*\b";

            MatchCollection matches = Regex.Matches(inputText, pattern);

            Console.WriteLine("Слова, где 'q' следует за 'u':");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            Console.ReadLine();
        }
    }
}
