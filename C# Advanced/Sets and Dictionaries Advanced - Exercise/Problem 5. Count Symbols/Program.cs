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
            string text = Console.ReadLine();

            SortedDictionary<char, int> symbolCounter = new SortedDictionary<char, int>();
            
            for (int i = 0; i < text.Length; i++)
            {
                if (symbolCounter.ContainsKey(text[i]))
                {
                    symbolCounter[text[i]]++;
                }
                else
                {
                    symbolCounter.Add(text[i], 1);
                }
            }

            foreach (var symbol in symbolCounter)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}

