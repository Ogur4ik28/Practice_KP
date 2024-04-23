using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фрагмент текста:");
            string inputText = Console.ReadLine();

            string resultText = GetLastLettersOfWords(inputText);

            Console.WriteLine("Результат:");
            Console.WriteLine(resultText);

            Console.ReadKey();
        }

        static string GetLastLettersOfWords(string text)
        {
            string[] words = text.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    char lastLetter = word[word.Length - 1];
                    result.Append(lastLetter);
                }
            }

            return result.ToString();
        }
    }
}
