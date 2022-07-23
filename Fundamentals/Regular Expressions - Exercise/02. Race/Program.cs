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
            string participants = Console.ReadLine();
            List<string> participantList = participants.Split(", ").ToList();
            Dictionary<string, int> namesAndDistance = new Dictionary<string, int>();

            foreach (var participant in participantList)
            {
                namesAndDistance.Add(participant, 0);
            }

            StringBuilder nameBuilder = new StringBuilder();
            string name = string.Empty;
            int distance = 0;



            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of race")
                {
                    break;
                }

                string namePattern = @"[A-Za-z]";
                Regex nameRegex = new Regex(namePattern);
                MatchCollection nameMatches = Regex.Matches(input, namePattern);
                foreach (Match match in nameMatches)
                {
                    nameBuilder.Append(match.Value);
                }
                name = nameBuilder.ToString();

                string distancePattern = @"[0-9]";
                Regex distanceRegex = new Regex(distancePattern);
                MatchCollection distanceMatches = Regex.Matches(input, distancePattern);
                foreach (Match match in distanceMatches)
                {
                    distance += int.Parse(match.Value);
                }

                if (namesAndDistance.ContainsKey(name))
                {
                    if (namesAndDistance[name] > 0)
                    {
                        namesAndDistance[name] += distance;
                    }
                    else
                    {
                        namesAndDistance[name] = distance;
                    }
                }

                nameBuilder.Clear();
                distance = 0;
            }
            List<string> topThreeWinners = new List<string>();
            var ordered = namesAndDistance.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            int counter = 0;
            foreach (var winners in ordered)
            {
                topThreeWinners.Add(winners.Key);
                counter++;
                if (counter == 3)
                {
                    break;
                }
            }


            Console.WriteLine($"1st place: {topThreeWinners[0]}");
            Console.WriteLine($"2nd place: {topThreeWinners[1]}");
            Console.WriteLine($"3rd place: {topThreeWinners[2]}");

        }
    }
}