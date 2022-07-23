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
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> planetsAttackedAndDestroyed = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                int counter = 0;
                string encryptedMessage = Console.ReadLine();
                StringBuilder stringbuilder = new StringBuilder();

                foreach (char c in encryptedMessage)
                {
                    if (c == 'S' || c == 's' || c == 'T' || c == 't' || c == 'A' || c == 'a' || c == 'R' || c == 'r')
                    {
                        counter++;
                    }
                }

                foreach (char c in encryptedMessage)
                {
                    stringbuilder.Append((char)(c - counter));
                }
                string almostDecrypted = stringbuilder.ToString();
                string pattern = @"@(?<Planet>[A-za-z]+)\d*[^@\-!:>]*:(?<Population>\d+)[^@\-!:>]*!(?<Action>[AD])![^@\-!:>]*->(?<Soldier>\d+)";
                MatchCollection matches = Regex.Matches(almostDecrypted, pattern);

                foreach (Match match in matches)
                {
                    string planetName = match.Groups["Planet"].Value;
                    int planetPopulation = int.Parse(match.Groups["Population"].Value);
                    string attackType = match.Groups["Action"].Value;
                    int soldierCount = int.Parse(match.Groups["Soldier"].Value);

                    if (attackType == "A")
                    {
                        if (planetsAttackedAndDestroyed.ContainsKey("Attack"))
                        {
                            planetsAttackedAndDestroyed["Attack"].Add(planetName);
                        }
                        else
                        {
                            planetsAttackedAndDestroyed.Add("Attack", new List<string>() { planetName });
                        }
                    }
                    else
                    {
                        if (planetsAttackedAndDestroyed.ContainsKey("Destroyed"))
                        {
                            planetsAttackedAndDestroyed["Destroyed"].Add(planetName);
                        }
                        else
                        {
                            planetsAttackedAndDestroyed.Add("Destroyed", new List<string>() { planetName });
                        }
                    };

                }
            }
            if (planetsAttackedAndDestroyed.ContainsKey("Attack"))
            {
                planetsAttackedAndDestroyed["Attack"].Sort();
            }
            if (planetsAttackedAndDestroyed.ContainsKey("Destroyed"))
            {
                planetsAttackedAndDestroyed["Destroyed"].Sort();
            }

            if (planetsAttackedAndDestroyed.ContainsKey("Attack"))
            {
                Console.WriteLine($"Attacked planets: {planetsAttackedAndDestroyed["Attack"].Count}");
                if (planetsAttackedAndDestroyed["Attack"].Count > 0)
                {
                    foreach (var attacked in planetsAttackedAndDestroyed["Attack"])
                    {
                        Console.WriteLine($"-> {attacked}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Attacked planets: 0");
            }

            if (planetsAttackedAndDestroyed.ContainsKey("Destroyed"))
            {
                Console.WriteLine($"Destroyed planets: {planetsAttackedAndDestroyed["Destroyed"].Count}");
                if (planetsAttackedAndDestroyed["Destroyed"].Count > 0)
                {
                    foreach (var destroyed in planetsAttackedAndDestroyed["Destroyed"])
                    {
                        Console.WriteLine($"-> {destroyed}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Destroyed planets: 0");
            }
        }
    }
}