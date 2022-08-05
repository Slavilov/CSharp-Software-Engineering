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
            int sizeOfSquare = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeOfSquare, sizeOfSquare];
            int sumOfPrimaryDiagonal = 0;
            int sumOfSecondaryDiagonal = 0; 
            int counter = 0;

            for (int row = 0; row < sizeOfSquare; row++)
            {
                string elements = Console.ReadLine();
                int[] elementsArray = elements.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int column = 0; column < sizeOfSquare; column++)
                {
                    matrix[row, column] = elementsArray[column];
                }

            }

            for (int row = 0; row < sizeOfSquare; row++)
            {
                for (int column = 0; column < sizeOfSquare; column++)
                {
                    if (counter == 0)
                    {
                        counter++;
                        sumOfPrimaryDiagonal += matrix[row, (column + row)];
                    }
                }
                counter = 0;
            }

            int secondaryCounter = 0;
            for (int row = sizeOfSquare-1; row >= 0; row--)
            {
                for (int column = 0; column < sizeOfSquare; column++)
                {
                    if (counter == 0)
                    {
                        counter++;
                        sumOfSecondaryDiagonal += matrix[row, secondaryCounter];
                        secondaryCounter++;
                    }
                }
                counter = 0;
            }
            Console.WriteLine(Math.Abs(sumOfPrimaryDiagonal-sumOfSecondaryDiagonal));
        }
    }
}
