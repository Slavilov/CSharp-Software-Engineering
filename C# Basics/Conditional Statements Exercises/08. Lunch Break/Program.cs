using System;

namespace Conditions.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int lenghtOfEpisode = int.Parse(Console.ReadLine()); // duljina na epizoda
            int lenghtOfBreak = int.Parse(Console.ReadLine()); // vreme za pochivka

            double lunchBreakEat = lenghtOfBreak * 1.0 / 8.0; // vreme za obqd
            double otdih = lenghtOfBreak * 1.0 / 4.0; // vreme za otdih

            double sum = lenghtOfBreak - (lunchBreakEat + otdih);



            if (lenghtOfEpisode <= sum)
            {
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(sum - lenghtOfEpisode)} minutes free time.");
            }
            else
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(lenghtOfEpisode - sum)} more minutes.");

        }
    }
}
