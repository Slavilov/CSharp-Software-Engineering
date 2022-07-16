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
            string digits = "";
            string letters = "";
            string symbols = "";

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (char.IsDigit(c))
                {
                    digits += c;
                }
                else if (char.IsLetter(c))
                {
                    letters += c;
                }
                else
                {
                    symbols += c;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}