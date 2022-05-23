using System;

namespace Conditions.GradeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int foodInGrams = food * 1000;
            int foodEatenCounter = 0;
            string input = Console.ReadLine();
            while (input != "Adopted")
            {
                int foodEaten = int.Parse(input);
                foodEatenCounter += foodEaten;
                input = Console.ReadLine();
            }

            if (foodEatenCounter <= foodInGrams)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInGrams - foodEatenCounter} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {foodEatenCounter - foodInGrams} grams more.");
            }
        }
    }
}
