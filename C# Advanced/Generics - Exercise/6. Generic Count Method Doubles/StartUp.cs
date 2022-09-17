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
            Box<double> newBox = new Box<double>();

            int nOfElements = int.Parse(Console.ReadLine());

            for (int i = 0; i < nOfElements; i++)
            {
                newBox.AddToBox(double.Parse(Console.ReadLine()));
            }

            double elementForComparison = double.Parse(Console.ReadLine());
            Console.WriteLine(newBox.NumOfElementsLargerThanGivenElement(elementForComparison));
        }
    }
}