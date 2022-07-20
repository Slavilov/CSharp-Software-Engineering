using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegExExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> newList = new List<string>();
            string text = Console.ReadLine();
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match item in matches)
            {
                newList.Add(item.Value);
            }

            Console.WriteLine((string.Join(", ", newList)));

        }
    }
}