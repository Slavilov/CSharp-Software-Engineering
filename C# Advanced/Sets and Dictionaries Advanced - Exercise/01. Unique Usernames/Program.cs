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
            HashSet<string> names = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i<n; i++)
            {
                names.Add(Console.ReadLine());
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}