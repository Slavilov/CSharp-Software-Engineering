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
            string stringOfSnake = Console.ReadLine();

            string[,] matrix = new string[rows, cols];

            StringBuilder snake = new StringBuilder();
            for (int i = 0; i <= rows*2; i++)
            {
                snake.Append(stringOfSnake);
            }

            for (int row = 0; row < rows; row++)
            {
                if (row%2==0)
                {
                    for (int column = 0; column < cols; column++)
                    {
                        matrix[row, column] = snake[0].ToString();
                        snake.Remove(0, 1);
                    }
                }
                else
                {
                    for (int column = cols-1; column >= 0; column--)
                    {
                        matrix[row, column] = snake[0].ToString();
                        snake.Remove(0, 1);
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + "");
                }
                Console.WriteLine();
            }

        }
    }
}

