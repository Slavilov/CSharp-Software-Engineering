using System;

namespace TennisRankList
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int starterPoints = int.Parse(Console.ReadLine());
            double points = 0;
            double sumOfPoints = 0;
            double averagePointsPerTournament = 0;
            double tournamentsWon = 0;
            double percentageOfWins = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string stageOfTournament = Console.ReadLine();

                switch (stageOfTournament)
                {
                    case "W":
                        tournamentsWon = tournamentsWon + 1;
                        points = points + 2000;
                        break;

                    case "F":
                        points = points + 1200;
                        break;

                    case "SF":
                        points = points + 720;
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
            sumOfPoints = starterPoints + points;
            averagePointsPerTournament = points / tournaments;
            percentageOfWins = (tournamentsWon / tournaments) * 100;

            Console.WriteLine($"Final points: {sumOfPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePointsPerTournament)}");
            Console.WriteLine($"{percentageOfWins:f2}%");
        }
    }
}
