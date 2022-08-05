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

            int counterOfEquals = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int column = 0; column < cols - 1; column++)
                {
                    if (matrix[row, column] == matrix[row, column + 1] && matrix[row, column] == matrix[row + 1, column] && matrix[row, column] == matrix[row + 1, column + 1])
                    {
                        counterOfEquals++;
                    }
                }
            }

            if (counterOfEquals > 0)
            {
                Console.WriteLine(counterOfEquals);
            }
            else
            {
                Console.WriteLine("0");
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
