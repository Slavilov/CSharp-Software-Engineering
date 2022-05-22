using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfLuggageMoreThan20Kilos = double.Parse(Console.ReadLine());
            double weightInKilosOfLuggage = double.Parse(Console.ReadLine());
            int daysUntilTravel = int.Parse(Console.ReadLine());
            int numberOfLuggages = int.Parse(Console.ReadLine());
            double priceOfLuggage = 0;

            if (weightInKilosOfLuggage < 10.00)
            {
                priceOfLuggage = priceOfLuggageMoreThan20Kilos * 0.20;
            }
            else if (weightInKilosOfLuggage >= 10.00 && weightInKilosOfLuggage <= 20.00)
            {
                priceOfLuggage = priceOfLuggageMoreThan20Kilos * 0.50;
            }
            else
            {
                priceOfLuggage = priceOfLuggageMoreThan20Kilos;
            }

            if (daysUntilTravel > 30)
            {
                priceOfLuggage = priceOfLuggage + (priceOfLuggage * 0.10);
            }
            else if (daysUntilTravel >= 7 && daysUntilTravel <= 30)
            {
                priceOfLuggage = priceOfLuggage + (priceOfLuggage * 0.15);
            }
            else if (daysUntilTravel < 7)
            {
                priceOfLuggage = priceOfLuggage + (priceOfLuggage * 0.40);
            }

            Console.WriteLine($"The total price of bags is: {(priceOfLuggage * numberOfLuggages):f2} lv.");
        }
    }
}
