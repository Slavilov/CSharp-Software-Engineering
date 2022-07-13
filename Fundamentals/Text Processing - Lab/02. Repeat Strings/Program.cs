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
            string[] arrayOfStrings = Console.ReadLine().Split(' ').ToArray();
            StringBuilder newString = new StringBuilder();

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                int lenghtOfWord = arrayOfStrings[i].Count();

                for (int j = 0; j < lenghtOfWord; j++)
                {
                    newString.Append(arrayOfStrings[i]);
                }
            }
            Console.WriteLine(newString);
        }
    }
}