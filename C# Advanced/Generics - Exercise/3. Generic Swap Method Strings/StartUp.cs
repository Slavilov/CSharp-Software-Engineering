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
            CustomList<Box<string>> customList = new CustomList<Box<string>>();
            int numberOfBoxes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfBoxes; i++)
            {
                Box<string> newBox = new Box<string>();
                newBox.AddToBox(Console.ReadLine());
                customList.AddToCustomList(newBox);
            }
            List<int> inputNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int numOne = inputNumbers[0];
            int numTwo = inputNumbers[1];

            customList.BoxSwapper(numOne, numTwo);
            customList.Foreach();
        }
    }
}