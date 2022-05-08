using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerName = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double priceOfFlower = 0;
            double finalPrice = 0;
            if (flowerName == "Roses")
            {
                if (numberOfFlowers > 80)
                {
                    priceOfFlower = numberOfFlowers * 5.0;
                    finalPrice = priceOfFlower - (priceOfFlower * 0.10);
                }
                else if (numberOfFlowers < 80)
                {
                    finalPrice = numberOfFlowers * 5.0;
                }
            }
            else if (flowerName == "Dahlias")
            {
                if (numberOfFlowers > 90)
                {
                    priceOfFlower = numberOfFlowers * 3.80;
                    finalPrice = priceOfFlower - (priceOfFlower * 0.15);
                }
                else if (numberOfFlowers < 90)
                {
                    finalPrice = numberOfFlowers * 3.80;
                }
            }
            else if (flowerName == "Tulips")
            {
                if (numberOfFlowers > 80)
                {
                    priceOfFlower = numberOfFlowers * 2.80;
                    finalPrice = priceOfFlower - (priceOfFlower * 0.15);
                }
                else if (numberOfFlowers < 80)
                {
                    finalPrice = numberOfFlowers * 2.80;
                }
            }
            else if (flowerName == "Narcissus")
            {
                if (numberOfFlowers <= 120)
                {
                    priceOfFlower = numberOfFlowers * 3.0;
                    finalPrice = priceOfFlower + (priceOfFlower * 0.15);
                }
                else if (numberOfFlowers > 120)
                {
                    finalPrice = numberOfFlowers * 3.0;
                }
            }
            else if (flowerName == "Gladiolus")
            {
                if (numberOfFlowers <= 80)
                {
                    priceOfFlower = numberOfFlowers * 2.50;
                    finalPrice = priceOfFlower + (priceOfFlower * 0.20);
                }
                else if (numberOfFlowers > 80)
                {
                    finalPrice = numberOfFlowers * 2.50;
                }

            }
            if (budget >= finalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowerName} and {(budget - finalPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(finalPrice - budget):f2} leva more.");
            }

        }
    }
}
