using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sumOfCoins = 0;
            double coins = 0;
            string product = string.Empty;

            while (input != "Start")
            {
                coins = double.Parse(input);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sumOfCoins += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                input = Console.ReadLine();
            }

            product = Console.ReadLine();
            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        if (sumOfCoins >= 2.0)
                        {
                            Console.WriteLine($"Purchased nuts");
                            sumOfCoins = sumOfCoins - 2.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        product = Console.ReadLine();
                        break;

                    case "Water":
                        if (sumOfCoins >= 0.7)
                        {
                            Console.WriteLine($"Purchased water");
                            sumOfCoins = sumOfCoins - 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        product = Console.ReadLine();
                        break;

                    case "Crisps":
                        if (sumOfCoins >= 1.5)
                        {
                            Console.WriteLine($"Purchased crisps");
                            sumOfCoins = sumOfCoins - 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        product = Console.ReadLine();
                        break;

                    case "Soda":
                        if (sumOfCoins >= 0.8)
                        {
                            Console.WriteLine($"Purchased soda");
                            sumOfCoins = sumOfCoins - 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        product = Console.ReadLine();
                        break;

                    case "Coke":
                        if (sumOfCoins >= 1.0)
                        {
                            Console.WriteLine($"Purchased coke");
                            sumOfCoins = sumOfCoins - 1.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        product = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        break;
                }
            }
            Console.WriteLine($"Change: {sumOfCoins:f2}");
        }
    }
}