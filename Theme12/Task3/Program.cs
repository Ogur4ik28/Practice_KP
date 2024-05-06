using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        delegate void StringManipulation(string input);
        static void Main(string[] args)
        {
            StringManipulation stringDelegate = ReverseString;
            stringDelegate += ConvertToUpperCase;
            stringDelegate += ConvertToLowerCase;

            stringDelegate("Hello, World!");

            Console.ReadKey();
        }

        static void ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine("Реверс строки: " + reversedString);
        }

        static void ConvertToUpperCase(string input)
        {
            string upperCaseString = input.ToUpper();
            Console.WriteLine("Строка в верхнем регистре: " + upperCaseString);
        }

        static void ConvertToLowerCase(string input)
        {
            string lowerCaseString = input.ToLower();
            Console.WriteLine("Строка в нижнем регистре: " + lowerCaseString);
        }
    }
}
