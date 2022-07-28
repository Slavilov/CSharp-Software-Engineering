using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> inputList = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            int N = int.Parse(inputList[0]);
            int S = int.Parse(inputList[1]);
            int X = int.Parse(inputList[2]);

            string inputNumbers = Console.ReadLine();
            List<string> listOfNumbers = inputNumbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
            Stack<int> stackOfNumbers = new Stack<int>();
            int smallestNumber = int.MaxValue;

            bool isPresent = false;
            for (int i = 0; i < N; i++)
            {
                stackOfNumbers.Push(int.Parse(listOfNumbers[i]));
            }

            for (int i = 0; i < S; i++)
            {
                if (stackOfNumbers.Count == 0)
                {
                    Console.WriteLine("0");
                    break;
                }

                int temporaryNum = stackOfNumbers.Pop();

                if (temporaryNum == X && isPresent == false)
                {
                    isPresent = true;
                }
            }
            if (stackOfNumbers.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }
            if (isPresent == false)
            {
                while (stackOfNumbers.Count > 0)
                {
                    int temporarNum2 = stackOfNumbers.Pop();
                    if (temporarNum2 < smallestNumber)
                    {
                        smallestNumber = temporarNum2;
                    }
                }
                Console.WriteLine(smallestNumber);
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}