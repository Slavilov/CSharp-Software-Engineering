using System;

namespace Conditions.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int statisti = int.Parse(Console.ReadLine());
            double outfitPrice = double.Parse(Console.ReadLine());
            double finalOutfitPrice = statisti * outfitPrice;

            double decor = money * 0.10;
            if (statisti > 150)
            {
                finalOutfitPrice = finalOutfitPrice - (finalOutfitPrice * 0.10);

            }

            if (decor + finalOutfitPrice > money)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {((decor + finalOutfitPrice) - money):F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(money - (decor + finalOutfitPrice)):F2} leva left.");
            }
        }

    }
}
