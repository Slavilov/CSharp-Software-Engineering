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
            List<int> inputOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            SortedDictionary<int, int> result = new SortedDictionary<int, int>();

            foreach (var number in inputOfIntegers)
            {
                if (result.ContainsKey(number))
                {
                    result[number]++;
                }
                else
                {
                    result.Add(number, 1);
                }
            }

            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}