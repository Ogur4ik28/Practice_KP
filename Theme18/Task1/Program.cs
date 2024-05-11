using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "abc#d##c";
            string result = ProcessBackspace(input);
            Console.WriteLine("Result: " + result);

            Console.ReadKey();
        }

        static string ProcessBackspace(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '#')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            char[] resultArray = stack.ToArray();
            Array.Reverse(resultArray);
            return new string(resultArray);
        }
    }
}
