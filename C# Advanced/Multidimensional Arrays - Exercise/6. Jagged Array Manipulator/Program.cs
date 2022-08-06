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

            for (int row = 0; row < rows-1; row++)
            {
                if (jagged[row].Length == jagged[row+1].Length)
                {
                    for (int i = 0; i < jagged[row].Length; i++)
                    {
                        jagged[row][i] = jagged[row][i] * 2;
                        jagged[row+1][i] = jagged[row+1][i] * 2;
                    }
                }
                else
                {
                    for (int i = 0; i < jagged[row].Length; i++)
                    {
                        jagged[row][i] = jagged[row][i] / 2;
                    }

                    for (int i = 0; i < jagged[row+1].Length; i++)
                    {
                        jagged[row + 1][i] = jagged[row + 1][i] / 2;
                    }
                }
            }

            while (true)
            {
                string commands = Console.ReadLine();

                if (commands == "End")
                {
                    foreach (var item in jagged)
                    {
                        Console.WriteLine(string.Join(" ", item));
                    }
                    break;
                }

                List<string> listOfCommands = commands.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                string command = listOfCommands[0];
                int row = int.Parse(listOfCommands[1]);
                int column = int.Parse(listOfCommands[2]);
                int value = int.Parse(listOfCommands[3]);
                
                if (row >= 0 && row <= rows-1 && column <= jagged[row].Length-1 && column >= 0)
                {
                    if (command == "Add")
                    {
                        jagged[row][column] += value;
                    }
                    else if (command == "Subtract")
                    {
                        jagged[row][column] -= value;
                    }
                }
            }
        }
    }
}

