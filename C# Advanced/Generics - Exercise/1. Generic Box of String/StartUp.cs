using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GenericsExercise
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Box<string> newBox = new Box<string>();
                newBox.AddToBox(input);
                Console.WriteLine(newBox);
            }
        }
    }
}