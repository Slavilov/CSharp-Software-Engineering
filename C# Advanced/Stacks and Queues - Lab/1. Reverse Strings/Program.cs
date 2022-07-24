using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stackOfChars = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stackOfChars.Push(input[i]);
            }

            while (stackOfChars.Count > 0)
            {
                StringBuilder temporaryChar = new StringBuilder();
                temporaryChar.Append(stackOfChars.Pop());
                Console.Write(temporaryChar);
            }
        }
    }
}