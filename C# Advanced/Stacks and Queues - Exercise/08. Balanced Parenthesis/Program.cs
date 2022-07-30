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


            Stack<char> stackOfParenthesis = new Stack<char>();
            Queue<char> queOfParenthesis = new Queue<char>();
            bool flag = true;

            for (int i = 0; i < input.Length / 2; i++)
            {
                queOfParenthesis.Enqueue(input[i]);
            }

            for (int i = input.Length / 2; i <= input.Length - 1; i++)
            {
                stackOfParenthesis.Push(input[i]);
            }

            while (stackOfParenthesis.Count > 0 && queOfParenthesis.Count > 0)
            {
                char queOf = queOfParenthesis.Dequeue();
                char stackOf = stackOfParenthesis.Pop();

                if (stackOf == '}' && queOf == '{')
                {

                }
                else if (stackOf == ']' && queOf == '[')
                {

                }
                else if (stackOf == ')' && queOf == '(')
                {

                }
                else
                {
                    flag = false;
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }
}