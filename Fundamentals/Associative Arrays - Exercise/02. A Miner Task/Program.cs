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
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            List<string> inputList = new List<string>();
            string input = string.Empty;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                inputList.Add(input);
            }

            for (int i = 0; i < inputList.Count; i += 2)
            {
                if (dictionary.ContainsKey(inputList[i]))
                {
                    dictionary[inputList[i]] += int.Parse(inputList[i + 1]);
                }
                else
                {
                    dictionary.Add(inputList[i], int.Parse(inputList[i + 1]));
                }
            }
            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}