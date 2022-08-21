using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SortEvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> action = (x) => Console.WriteLine(x);
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var name in names)
            {
                action(name);
            }

        }
    }
}
