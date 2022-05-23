using System;

namespace Conditions.GradeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            int dogFoodEatenPerDay = 0;
            int catFoodEatenPerDay = 0;
            int counterPer3Days = 0;
            double eatenFoodForTheDay = 0;
            double biscuitWeight = 0;
            double biscuitCounter = 0;
            double counterDogFood = 0;
            double counterCatFood = 0;
            double counterBothFood = 0;

            for (int i = 1; i <= days; i++)
            {
                biscuitWeight = 0;
                dogFoodEatenPerDay = int.Parse(Console.ReadLine());
                counterDogFood += dogFoodEatenPerDay;
                catFoodEatenPerDay = int.Parse(Console.ReadLine());
                counterCatFood += catFoodEatenPerDay;
                eatenFoodForTheDay = dogFoodEatenPerDay + catFoodEatenPerDay;
                biscuitWeight = eatenFoodForTheDay * 0.10;
                counterPer3Days++;
                counterBothFood += (dogFoodEatenPerDay + catFoodEatenPerDay);
                if (i == 3 || i == 6 || i == 9 || i == 12 || i == 15 || i == 18 || i == 21 || i == 24 || i == 27 || i == 30)
                {
                    biscuitCounter = biscuitCounter + biscuitWeight;
                }
            }
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuitCounter)}gr.");
            Console.WriteLine($"{((counterDogFood + counterCatFood) / food) * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{(counterDogFood / counterBothFood) * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{(counterCatFood / counterBothFood) * 100:f2}% eaten from the cat.");

        }
    }
}
