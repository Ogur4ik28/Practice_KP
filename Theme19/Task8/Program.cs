using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Делегат для обработки строк.
        /// </summary>
        /// <param name="input">Входная строка.</param>
        delegate void StringManipulation(string input);

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            // Инициализация делегата с методами обработки строк.
            StringManipulation stringDelegate = ReverseString;
            stringDelegate += ConvertToUpperCase;
            stringDelegate += ConvertToLowerCase;

            // Вызов методов делегата с входной строкой.
            stringDelegate("Hello, World!");

            Console.ReadKey();
        }

        /// <summary>
        /// Метод для реверса строки.
        /// </summary>
        /// <param name="input">Входная строка.</param>
        static void ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine("Реверс строки: " + reversedString);
        }

        /// <summary>
        /// Метод для преобразования строки в верхний регистр.
        /// </summary>
        /// <param name="input">Входная строка.</param>
        static void ConvertToUpperCase(string input)
        {
            string upperCaseString = input.ToUpper();
            Console.WriteLine("Строка в верхнем регистре: " + upperCaseString);
        }

        /// <summary>
        /// Метод для преобразования строки в нижний регистр.
        /// </summary>
        /// <param name="input">Входная строка.</param>
        static void ConvertToLowerCase(string input)
        {
            string lowerCaseString = input.ToLower();
            Console.WriteLine("Строка в нижнем регистре: " + lowerCaseString);
        }
    }
}
