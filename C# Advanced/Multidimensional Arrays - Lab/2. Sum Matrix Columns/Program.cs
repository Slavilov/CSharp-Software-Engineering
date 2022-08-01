using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            string sizeOfRowsColumns = Console.ReadLine();
            int[] RowsAndColumns = sizeOfRowsColumns.Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = RowsAndColumns[0];
            int columns = RowsAndColumns[1];

            int[] sumOfColumns = new int[columns];

            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                string elements = Console.ReadLine();
                int[] elementsArray = elements.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = elementsArray[column];

                    sumOfColumns[column] += elementsArray[column];
                }
            }

            foreach (var item in sumOfColumns)
            {
                Console.WriteLine(item);
            }
        }
    }
}