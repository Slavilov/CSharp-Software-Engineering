using System;

namespace Conditions.GradeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int numberOfSets = int.Parse(Console.ReadLine());
            double price = 0;

            switch (fruit)
            {
                case "Watermelon":
                    if (size == "small")
                    {
                        price = (2 * 56) * numberOfSets;
                    }
                    else
                    {
                        price = (5 * 28.70) * numberOfSets;
                    }
                    break;

                case "Mango":
                    if (size == "small")
                    {
                        price = (2 * 36.66) * numberOfSets;
                    }
                    else
                    {
                        price = (5 * 19.60) * numberOfSets;
                    }
                    break;

                case "Pineapple":
                    if (size == "small")
                    {
                        price = (2 * 42.10) * numberOfSets;
                    }
                    else
                    {
                        price = (5 * 24.80) * numberOfSets;
                    }
                    break;

                case "Raspberry":
                    if (size == "small")
                    {
                        price = (2 * 20) * numberOfSets;
                    }
                    else
                    {
                        price = (5 * 15.20) * numberOfSets;
                    }
                    break;

            }

            if (price >= 400 && price <= 1000)
            {
                price = price - (price * 0.15);
            }
            if (price > 1000)
            {
                price = price - (price * 0.50);
            }
            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
