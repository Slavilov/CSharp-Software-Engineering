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
            string pattern = @"\b(\d{2})(\.|-|\/)([A-Z][a-z]{2})\2(\d{4})\b";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match item in matches)
            {
                var date = item.Groups[1].Value;
                var month = item.Groups[3].Value;
                var year = item.Groups[4].Value;

                Console.WriteLine($"Day: {date}, Month: {month}, Year: {year}");
            }

        }
    }
}