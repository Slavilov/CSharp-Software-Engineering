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
            int sizeOfSquare = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeOfSquare, sizeOfSquare];
            int sumOfDiagonal = 0;
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
                for (int column = 0;column < sizeOfSquare; column++)
                {
                    if (counter == 0)
                    {
                        counter++;
                        sumOfDiagonal += matrix[row, (column + row)];
                    }
                }
                counter = 0;
            }
            Console.WriteLine(sumOfDiagonal);
        }
    }
}
