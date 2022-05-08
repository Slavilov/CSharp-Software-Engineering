using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double rent = 0;

            switch (season)
            {
                case "Spring":
                    rent = 3000;
                    if (fishermen <= 6)
                    {
                        rent = rent - (rent * 0.10);
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        rent = rent - (rent * 0.15);
                    }
                    else if (fishermen >= 12)
                    {
                        rent = rent - (rent * 0.25);
                    }

                    if (fishermen % 2 == 0)
                    {
                        rent = rent - (rent * 0.05);
                    }

                    break;

                case "Summer":
                    rent = 4200;
                    if (fishermen <= 6)
                    {
                        rent = rent - (rent * 0.10);
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        rent = rent - (rent * 0.15);
                    }
                    else if (fishermen >= 12)
                    {
                        rent = rent - (rent * 0.25);
                    }

                    if (fishermen % 2 == 0)
                    {
                        rent = rent - (rent * 0.05);
                    }

                    break;

                case "Autumn":
                    rent = 4200;
                    if (fishermen <= 6)
                    {
                        rent = rent - (rent * 0.10);
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        rent = rent - (rent * 0.15);
                    }
                    else if (fishermen >= 12)
                    {
                        rent = rent - (rent * 0.25);
                    }

                    break;

                case "Winter":
                    rent = 2600;
                    if (fishermen <= 6)
                    {
                        rent = rent - (rent * 0.10);
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        rent = rent - (rent * 0.15);
                    }
                    else if (fishermen >= 12)
                    {
                        rent = rent - (rent * 0.25);
                    }
                    if (fishermen % 2 == 0)
                    {
                        rent = rent - (rent * 0.05);
                    }

                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            if (budget >= rent)
            {
                Console.WriteLine($"Yes! You have {(budget - rent):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(rent - budget):f2} leva.");
            }

        }
    }
}
