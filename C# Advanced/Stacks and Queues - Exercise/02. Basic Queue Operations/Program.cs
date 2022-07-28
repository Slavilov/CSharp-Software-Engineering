using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BasicOperations
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
            List<string> listOfNumbers = inputNumbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            Queue<int> queOfNumbers = new Queue<int>();

            for (int i = 0; i < N; i++)
            {
                queOfNumbers.Enqueue(int.Parse(listOfNumbers[i]));
            }

            for (int i = 0; i < S; i++)
            {
                if (queOfNumbers.Count == 0)
                {
                    Console.WriteLine("0");
                    break;
                }
                queOfNumbers.Dequeue();
            }
            if (queOfNumbers.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }
            if (queOfNumbers.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queOfNumbers.Min());
            }

        }
    }
}