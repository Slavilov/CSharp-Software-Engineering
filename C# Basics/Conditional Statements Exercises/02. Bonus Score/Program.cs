using System;

namespace Conditions.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if (points <= 100)
            {
                bonusPoints = 5;
            }

            else if (points > 1000)
            {
                bonusPoints = points * 0.10;
            }

            else if (points > 100)
            {
                bonusPoints = points * (20 / 100.0);
            }

            if (points % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            if (points % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(points + bonusPoints);
        }
    }
}
