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
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();

            while (secondStr.Contains(firstStr))
            {
                int indexOfWord = secondStr.IndexOf(firstStr);
                secondStr = secondStr.Remove(indexOfWord, firstStr.Length);
            }
            Console.WriteLine(secondStr);
        }
    }
}