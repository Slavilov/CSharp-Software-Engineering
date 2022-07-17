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
            string pathFileInput = Console.ReadLine();
            char[] separator = { '\\', '.' };
            List<string> listOfInput = pathFileInput.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

            Console.WriteLine($"File name: {listOfInput[listOfInput.Count - 2]}");
            Console.WriteLine($"File extension: {listOfInput[listOfInput.Count - 1]}");
        }
    }
}