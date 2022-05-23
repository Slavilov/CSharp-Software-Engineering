using System;

namespace Conditions.GradeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTournament = int.Parse(Console.ReadLine());
            string input = string.Empty;
            double moneyCounterForTheDay = 0;
            double moneyCounter = 0;
            int gamesCounter = 0;
            int gamesWonCounterDay = 0;
            int gamesLostCounterDay = 0;
            int gamesWon = 0;
            int gamesLost = 0;

            for (int i = 0; i < daysOfTournament; i++)
            {
                gamesWonCounterDay = 0;
                gamesLostCounterDay = 0;
                moneyCounterForTheDay = 0;

                while (true)
                {
                    string sport = Console.ReadLine();

                    if (sport == "Finish")
                    {
                        break;
                    }

                    string result = Console.ReadLine();
                    if (result == "win")
                    {
                        moneyCounterForTheDay += 20;
                        gamesWonCounterDay++;
                        gamesWon++;
                    }
                    else
                    {
                        gamesLostCounterDay++;
                        gamesLost++;
                    }
                }

                if (gamesWonCounterDay > gamesLostCounterDay)
                {
                    moneyCounterForTheDay = moneyCounterForTheDay + (moneyCounterForTheDay * 0.10);
                }

                moneyCounter += moneyCounterForTheDay;
            }
            if (gamesWon > gamesLost)
            {
                moneyCounter = moneyCounter + (moneyCounter * 0.20);
                Console.WriteLine($"You won the tournament! Total raised money: {moneyCounter:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {moneyCounter:f2}");
            }
        }
    }
}
