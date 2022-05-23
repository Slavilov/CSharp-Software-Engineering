using System;

namespace Conditions.GradeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesPerDay = int.Parse(Console.ReadLine());
            int razhodkiDnevno = int.Parse(Console.ReadLine());
            int caloriesPerDay = int.Parse(Console.ReadLine());

            double sumCaloriesPerMinutes = (minutesPerDay * razhodkiDnevno) * 5;

            if (sumCaloriesPerMinutes >= caloriesPerDay / 2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {sumCaloriesPerMinutes}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {sumCaloriesPerMinutes}.");
            }

        }
    }
}