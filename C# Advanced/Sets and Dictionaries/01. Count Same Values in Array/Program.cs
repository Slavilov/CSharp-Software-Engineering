using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Counting
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<double> listOfNumbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            Dictionary<double, int> numbersOccurences = new Dictionary<double, int>();
            int counter = 0;

            for (int i = 0; i < listOfNumbers.Count; i++)
            {

                if (numbersOccurences.ContainsKey(listOfNumbers[i]))
                {
                    continue;
                }

                for (int j = 0; j < listOfNumbers.Count; j++)
                {
                    if (listOfNumbers[i] == listOfNumbers[j])
                    {
                        if (numbersOccurences.ContainsKey(listOfNumbers[i]))
                        {
                            numbersOccurences[listOfNumbers[i]]++;
                        }
                        else
                        {
                            numbersOccurences.Add(listOfNumbers[i], 1);
                        }
                    }
                }
            }

            foreach(var number in numbersOccurences)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times ");
            }
        }
    }
}
