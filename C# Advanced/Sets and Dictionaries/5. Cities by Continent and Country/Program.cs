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
            Dictionary<string, Dictionary<string, List<string>>> continentCountryCity = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                List<string> listOfInputs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                string continent = listOfInputs[0];
                string country = listOfInputs[1];
                string city = listOfInputs[2];

                if (continentCountryCity.ContainsKey(continent))
                {
                    if (continentCountryCity[continent].ContainsKey(country))
                    {
                        continentCountryCity[continent][country].Add(city);
                    }
                    else
                    {
                        continentCountryCity[continent].Add(country, new List<string>());
                        continentCountryCity[continent][country].Add(city);
                    }
                }
                else
                {
                    continentCountryCity.Add(continent, new Dictionary<string, List<string>>());
                    continentCountryCity[continent].Add(country, new List<string> { city });
                }
            }
            foreach (var continent in continentCountryCity)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
