using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double sum = 0;

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        sum = quantity * 2.50;
                        Console.WriteLine($"{sum:F2}");
                        break;
                    case "apple":
                        sum = quantity * 1.20;
                        Console.WriteLine($"{sum:F2}");
                        break;
                    case "orange":
                        sum = quantity * 0.85;
                        Console.WriteLine($"{sum:F2}");
                        break;
                    case "grapefruit":
                        sum = quantity * 1.45;
                        Console.WriteLine($"{sum:F2}");
                        break;
                    case "kiwi":
                        sum = quantity * 2.70;
                        Console.WriteLine($"{sum:F2}");
                        break;
                    case "pineapple":
                        sum = quantity * 5.50;
                        Console.WriteLine($"{sum:F2}");
                        break;
                    case "grapes":
                        sum = quantity * 3.85;
                        Console.WriteLine($"{sum:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        sum = quantity * 2.70;
                        Console.WriteLine($"{sum:F2}");
                        break;
                    case "apple":
                        sum = quantity * 1.25;
                        Console.WriteLine($"{sum:F2}");
                        break;
                    case "orange":
                        sum = quantity * 0.90;
                        Console.WriteLine($"{sum:F2}");
                        break;
                    case "grapefruit":
                        sum = quantity * 1.60;
                        Console.WriteLine($"{sum:F2}");
                        break;
                    case "kiwi":
                        sum = quantity * 3.00;
                        Console.WriteLine($"{sum:F2}");
                        break;
                    case "pineapple":
                        sum = quantity * 5.60;
                        Console.WriteLine($"{sum:F2}");
                        break;
                    case "grapes":
                        sum = quantity * 4.20;
                        Console.WriteLine($"{sum:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }


            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}