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
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> chemicalElements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                List<string> chemicalInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                
                for (int j = 0; j < chemicalInput.Count; j++)
                {
                    chemicalElements.Add(chemicalInput[j]);
                }
            }
            Console.Write(string.Join(' ', chemicalElements));
        }
    }
}
