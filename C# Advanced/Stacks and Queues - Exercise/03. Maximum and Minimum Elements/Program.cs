using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> newStack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                List<string> listOfInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                if (listOfInput[0] == "1")
                {
                    newStack.Push(int.Parse(listOfInput[1]));
                }
                else if (listOfInput[0] == "2")
                {
                    if (newStack.Count > 0)
                    {
                        newStack.Pop();
                    }
                }
                else if (listOfInput[0] == "3")
                {
                    if (newStack.Count > 0)
                    {
                        Console.WriteLine(newStack.Max());
                    }
                }
                else if (listOfInput[0] == "4")
                {
                    if (newStack.Count > 0)
                    {
                        Console.WriteLine(newStack.Min());
                    }
                }
            }
            while (newStack.Count > 0)
            {
                Console.Write($"{newStack.Pop()}");
                if (newStack.Count > 0)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}