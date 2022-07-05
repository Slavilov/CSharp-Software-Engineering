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
            List<string> sequenceOfWords = Console.ReadLine().Split(' ').ToList();
            sequenceOfWords = sequenceOfWords.ConvertAll(d => d.ToLower());
            Dictionary<string, int> numberOfOccur = new Dictionary<string, int>();

            foreach (var word in sequenceOfWords)
            {
                if (numberOfOccur.ContainsKey(word))
                {
                    numberOfOccur[word]++;
                }
                else
                {
                    numberOfOccur.Add(word, 1);
                }
            }

            foreach (var pair in numberOfOccur)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write(pair.Key + " ");
                }
            }
        }
    }
}