using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string accommodation = Console.ReadLine();
            string grade = Console.ReadLine();
            double sum = 0;
            days = days - 1;
            switch (accommodation)
            {
                case "room for one person":
                    sum = days * 18.00;

                    break;

                case "apartment":
                    sum = days * 25.00;
                    if (days < 10)
                    {
                        sum = sum - (sum * 0.30);
                    }
                    else if (days <= 15 && days >= 10)
                    {
                        sum = sum - (sum * 0.35);
                    }
                    else if (days > 15)
                    {
                        sum = sum - (sum * 0.50);
                    }
                    break;

                case "president apartment":
                    sum = days * 35.00;
                    if (days < 10)
                    {
                        sum = sum - (sum * 0.10);
                    }
                    else if (days <= 15 && days >= 10)
                    {
                        sum = sum - (sum * 0.15);
                    }
                    else if (days > 15)
                    {
                        sum = sum - (sum * 0.20);
                    }
                    break;

            }
            if (grade == "positive")
            {
                sum = sum + (sum * 0.25);
            }
            else if (grade == "negative")
            {
                sum = sum - (sum * 0.10);
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}