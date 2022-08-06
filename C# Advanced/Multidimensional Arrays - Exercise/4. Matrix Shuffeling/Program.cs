using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rowsAndCols = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            string[,] matrix = NewMethod(rows, cols);

            string swap1 = string.Empty;
            string swap2 = string.Empty;

            while (true)
            {
                string commands = Console.ReadLine();
                if (commands == "END")
                {
                    break;
                }

                List<string> listOfCommands = commands.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                if (listOfCommands[0] == "swap" && 
                    listOfCommands.Count == 5 && 
                    int.Parse(listOfCommands[1]) >= 0 &&
                    int.Parse(listOfCommands[1]) <= rows-1 &&
                    int.Parse(listOfCommands[2]) >= 0 &&
                    int.Parse(listOfCommands[2]) <= cols-1 &&
                    int.Parse(listOfCommands[3]) >= 0 &&
                    int.Parse(listOfCommands[3]) <= rows - 1 &&
                    int.Parse(listOfCommands[4]) >= 0 &&
                    int.Parse(listOfCommands[4]) <= cols - 1)
                {
                    swap1 = matrix[int.Parse(listOfCommands[1]), int.Parse(listOfCommands[2])];
                    swap2 = matrix[int.Parse(listOfCommands[3]), int.Parse(listOfCommands[4])];

                    matrix[int.Parse(listOfCommands[3]), int.Parse(listOfCommands[4])] = swap1; 
                    matrix[int.Parse(listOfCommands[1]), int.Parse(listOfCommands[2])] = swap2;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }

        private static string[,] NewMethod(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string elements = Console.ReadLine();
                string[] elementsArray = elements.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int column = 0; column < cols; column++)
                {
                    matrix[row, column] = elementsArray[column];
                }
            }
            return matrix;
        }
    }
}
