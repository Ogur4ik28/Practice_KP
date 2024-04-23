using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фрагмент текста:");
            string inputText = Console.ReadLine();

            Console.WriteLine("Введите символ для удаления слов:");
            char charToRemove = Console.ReadLine()[0];

            string resultText = RemoveWordsWithChar(inputText, charToRemove);

            Console.WriteLine("Результат:");
            Console.WriteLine(resultText);

            Console.ReadKey();
        }

        static string RemoveWordsWithChar(string text, char charToRemove)
        {
            string[] words = text.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                if (!word.ToLower().Contains(char.ToLower(charToRemove)))
                {
                    result.Append(word + " ");
                }
            }

            return result.ToString().Trim();
        }
    }
}
