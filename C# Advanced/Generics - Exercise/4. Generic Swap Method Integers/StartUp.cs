using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BoxSwapper
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CustomList<Box<int>> customList = new CustomList<Box<int>>();
            int numberOfBoxes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfBoxes; i++)
            {
                Box<int> newBox = new Box<int>();
                newBox.AddToBox(int.Parse(Console.ReadLine()));
                customList.AddToCustomList(newBox);
            }
            List<int> inputNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int numOne = inputNumbers[0];
            int numTwo = inputNumbers[1];

            customList.BoxSwapper(numOne, numTwo);
            customList.Foreach();
        }
    }
}