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
            Console.WriteLine("Введите предложение:");
            string inputSentence = Console.ReadLine();

            string[] words = inputSentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string temp = words[0];
            words[0] = words[words.Length - 1];
            words[words.Length - 1] = temp;
            string result1 = string.Join(" ", words);

            string result2 = "";
            if (words.Length >= 3)
            {
                result2 = words[1] + words[2];
            }

            string result3 = "";
            if (words.Length >= 3)
            {
                char[] thirdWordChars = words[2].ToCharArray();
                Array.Reverse(thirdWordChars);
                result3 = new string(thirdWordChars);
            }

            string result4 = "";
            if (words.Length >= 1 && words[0].Length >= 2)
            {
                result4 = words[0].Substring(2);
            }

            Console.WriteLine("Результаты:");
            Console.WriteLine("Меняем местами первое и последнее слово: " + result1);
            Console.WriteLine("Склеиваем второе и третье слова: " + result2);
            Console.WriteLine("Третье слово в обратном порядке: " + result3);
            Console.WriteLine("В первом слове вырезаем первые две буквы: " + result4);

            Console.ReadKey();
        }
    }
}
