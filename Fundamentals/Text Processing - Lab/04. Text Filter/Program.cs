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
            List<string> bannedWords = Console.ReadLine().Split(", ").ToList();
            string text = Console.ReadLine();
            string replacement = string.Empty;
            string newText = text;

            for (int i = 0; i < bannedWords.Count; i++)
            {
                for (int j = 0; j < bannedWords[i].Length; j++)
                {
                    replacement += "*";
                }
                newText = newText.Replace(bannedWords[i], replacement);
                replacement = "";
            }
            Console.WriteLine(newText);
        }
    }
}