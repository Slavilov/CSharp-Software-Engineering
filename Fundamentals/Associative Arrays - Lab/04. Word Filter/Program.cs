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
            string[] words = Console.ReadLine().Split(' ').ToArray();
            string[] newWords = words.Where(n => n.Length % 2 == 0).ToArray();

            foreach (var word in newWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}