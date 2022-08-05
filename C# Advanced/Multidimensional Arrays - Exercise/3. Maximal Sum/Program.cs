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

            int maxSum = int.MinValue;
            int currentSum = 0;
            int maxRow = 0;
            int maxCol = 0;


            int[,] matrix = NewMethod(rows, cols);


            for (int row = 0; row < rows - 2; row++)
            {
                for (int column = 0; column < cols - 2; column++)
                {
                    currentSum =
                        matrix[row, column] +
                        matrix[row, column + 1] +
                        matrix[row, column + 2] +
                        matrix[row + 1, column] +
                        matrix[row + 1, column + 1] +
                        matrix[row + 1, column + 2] +
                        matrix[row + 2, column] +
                        matrix[row + 2, column + 1] +
                        matrix[row + 2, column + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = column;
                    }

                    currentSum = 0;
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]} {matrix[maxRow, maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]} {matrix[maxRow + 1, maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 2, maxCol]} {matrix[maxRow + 2, maxCol + 1]} {matrix[maxRow + 2, maxCol + 2]}");
        }

        private static int[,] NewMethod(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string elements = Console.ReadLine();
                int[] elementsArray = elements.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int column = 0; column < cols; column++)
                {
                    matrix[row, column] = elementsArray[column];
                }
            }
            return matrix;
        }
    }
}
