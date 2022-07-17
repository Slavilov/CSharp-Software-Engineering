using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace AssociativeArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach (var ch in input)
            {
                int newCh = ((int)ch) + 3;
                char secondCh = (char)newCh;
                sb.Append(secondCh);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}