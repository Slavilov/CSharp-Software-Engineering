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
            Box<string> newBox = new Box<string>();

            int nOfElements = int.Parse(Console.ReadLine());

            for (int i = 0; i < nOfElements; i++)
            {
                newBox.AddToBox(Console.ReadLine());
            }

            string elementForComparison = Console.ReadLine();
            Console.WriteLine(newBox.NumOfElementsLargerThanGivenElement(elementForComparison));
        }
    }
}