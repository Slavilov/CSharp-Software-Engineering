using System;

namespace Conditions.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfVacation = double.Parse(Console.ReadLine());
            double discount = 0;

            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int sumOfToys = puzzles + dolls + teddyBears + minions + trucks;

            double sumOfToysPrice = (puzzles * 2.60 + dolls * 3.00 + teddyBears * 4.10 + minions * 8.20 + trucks * 2.00);

            if (sumOfToys >= 50)
            {
                sumOfToysPrice = sumOfToysPrice - (sumOfToysPrice * 0.25);
            }

            sumOfToysPrice = sumOfToysPrice - (sumOfToysPrice * 0.10);

            if (sumOfToysPrice >= priceOfVacation)
            {
                Console.WriteLine($"Yes! {(sumOfToysPrice - priceOfVacation):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(priceOfVacation - sumOfToysPrice):F2} lv needed.");
            }
        }

    }
}
