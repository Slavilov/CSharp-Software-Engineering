using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrimaryDiagonal
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];

            for (int row = 0; row < jagged.Length; row++)
            {
                int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                jagged[row] = new int[inputNumbers.Length];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = inputNumbers[col];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    foreach (var item in jagged)
                    {
                        Console.WriteLine(string.Join(' ', item));
                    }
                    break;
                }

                List<string> listOfInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                string command = listOfInput[0];
                int row = int.Parse(listOfInput[1]);
                int col = int.Parse(listOfInput[2]);
                int value = int.Parse(listOfInput[3]);

                if (command == "Add")
                {
                    if (row >= 0 && row <= rows - 1 && col >= 0 && col <= rows)
                    {
                        jagged[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else
                {
                    if (row >= 0 && row <= rows - 1 && col >= 0 && col <= rows)
                    {
                        jagged[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
            }
        }
    }
}
