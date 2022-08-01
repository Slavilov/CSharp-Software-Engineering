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

            for (int row = 0; row < sizeOfSquare; row++)
            {
                string elements = Console.ReadLine();
                char[] elementsArray = elements.ToCharArray();

                for (int column = 0; column < sizeOfSquare; column++)
                {
                    matrix[row, column] = elementsArray[column];
                }
            }

            char symbolToFind = char.Parse(Console.ReadLine());

            for (int row = 0; row < sizeOfSquare; row++)
            {
                for (int column = 0; column < sizeOfSquare; column++)
                {
                    if (matrix[row, column] == symbolToFind)
                    {
                        Console.WriteLine($"({row}, {column})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbolToFind} does not occur in the matrix");
        }
    }
}