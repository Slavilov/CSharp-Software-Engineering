using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HelpMole
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];

            int damageOfSubmarine = 0;
            int destroyedBattleCruisers = 0;

            int submarinePositionRow = 0;
            int submarinePositionCol = 0;

            string command = string.Empty;

            for (int row = 0; row < sizeOfMatrix; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < sizeOfMatrix; col++)
                {
                    matrix[row, col] = input[col];

                    if (input[col] == 'S')
                    {
                        submarinePositionRow = row;
                        submarinePositionCol = col;
                    }
                }
            }
            matrix[submarinePositionRow, submarinePositionCol] = '-';

            while (true)
            {
                command = Console.ReadLine();

                if (command == "up")
                {
                    submarinePositionRow--;
                }
                else if (command == "down")
                {
                    submarinePositionRow++;

                }
                else if (command == "left")
                {
                    submarinePositionCol--;

                }
                else if (command == "right")
                {
                    submarinePositionCol++;

                }

                if (matrix[submarinePositionRow, submarinePositionCol] == '-')
                {

                }
                else if (matrix[submarinePositionRow, submarinePositionCol] == '*')
                {
                    damageOfSubmarine++;
                    matrix[submarinePositionRow, submarinePositionCol] = '-';

                    if (damageOfSubmarine > 2)
                    {
                        Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarinePositionRow}, {submarinePositionCol}]!");
                        break;
                    }
                }
                else if (matrix[submarinePositionRow, submarinePositionCol] == 'C')
                {
                    matrix[submarinePositionRow, submarinePositionCol] = '-';
                    destroyedBattleCruisers++;

                    if (destroyedBattleCruisers == 3)
                    {
                        Console.WriteLine($"Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                        break;
                    }
                }
            }

            matrix[submarinePositionRow, submarinePositionCol] = 'S';
            for (int row = 0; row < sizeOfMatrix; row++)
            {
                for (int col = 0; col < sizeOfMatrix; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}