using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SimpelCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();
            int openingIndex = 0;
            int closingIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    openingIndex = indexes.Pop();
                    closingIndex = i + 1;
                    Console.WriteLine(input.Substring(openingIndex, closingIndex - openingIndex));
                }
            }

        }
    }
}