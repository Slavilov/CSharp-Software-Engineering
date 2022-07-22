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
            List<string> itemsBought = new List<string>();
            double sum = 0;

            while (true)
            {
                string inputText = Console.ReadLine();

                if (inputText == "Purchase")
                {
                    break;
                }

                string pattern = @">>([A-Za-z]+)<<([0-9]+[.]?[0-9]+)[!](\d+)";

                Regex regex = new Regex(pattern);
                MatchCollection matches = Regex.Matches(inputText, pattern);


                foreach (Match match in matches)
                {
                    itemsBought.Add(match.Groups[1].Value);
                    sum += double.Parse(match.Groups[2].Value) * double.Parse(match.Groups[3].Value);
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in itemsBought)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}