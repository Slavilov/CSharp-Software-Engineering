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
            double sum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }

                string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
                Regex regex = new Regex(pattern);
                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match item in matches)
                {
                    var customer = item.Groups["customer"].Value;
                    var product = item.Groups["product"].Value;
                    int count = int.Parse(item.Groups["count"].Value);
                    var price = double.Parse(item.Groups["price"].Value);

                    Console.WriteLine($"{customer}: {product} - {count * price:f2}");
                    sum += count * price;
                }
            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}