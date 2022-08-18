using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CountUpperCases
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new string[] {" " }, StringSplitOptions.RemoveEmptyEntries).Where(x => Char.IsUpper(x[0])).ToList();
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
