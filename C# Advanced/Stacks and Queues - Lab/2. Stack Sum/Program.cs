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
            string numbers = Console.ReadLine();
            List<int> numberList = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Stack<int> stackOfNumbers = new Stack<int>();
            int sum = 0;

            for (int i = 0; i < numberList.Count; i++)
            {
                stackOfNumbers.Push(numberList[i]);
            }

            while (true)
            {
                string commands = Console.ReadLine();

                if (commands.ToLower() == "end")
                {
                    break;
                }

                List<string> listOfCommands = commands.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                if (listOfCommands[0].ToLower() == "add")
                {
                    stackOfNumbers.Push(int.Parse(listOfCommands[1]));
                    stackOfNumbers.Push(int.Parse(listOfCommands[2]));
                }
                else
                {
                    if (stackOfNumbers.Count >= int.Parse(listOfCommands[1]))
                    {
                        for (int i = 0; i < int.Parse(listOfCommands[1]); i++)
                        {
                            stackOfNumbers.Pop();
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            while (stackOfNumbers.Count > 0)
            {
                sum += stackOfNumbers.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}