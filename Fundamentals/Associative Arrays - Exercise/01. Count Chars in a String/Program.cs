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
            input = input.Replace(" ", String.Empty);

            Dictionary<char, int> occurencesOfChar = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (occurencesOfChar.ContainsKey(input[i]))
                {
                    occurencesOfChar[input[i]]++;
                }
                else
                {
                    occurencesOfChar.Add(input[i], 1);
                }
            }
            foreach (var pair in occurencesOfChar)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}