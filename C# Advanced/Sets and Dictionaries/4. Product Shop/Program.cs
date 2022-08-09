using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> productShop = new SortedDictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string input = Console.ReadLine();
                
                if (input == "Revision")
                {
                    break;
                }

                List<string> listOfInput = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
                
                string shop = listOfInput[0];
                string product = listOfInput[1];
                double price = double.Parse(listOfInput[2]);

                if (productShop.ContainsKey(shop))
                {
                    productShop[shop].Add(product, price);
                }
                else
                {
                    productShop.Add(shop,new Dictionary<string, double>());
                    productShop[shop].Add(product, price);
                }
            }
            foreach (var shop in productShop)
            {
                Console.WriteLine($"{shop.Key}->");

                var collection = shop.Value;

                foreach (var product in collection)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
