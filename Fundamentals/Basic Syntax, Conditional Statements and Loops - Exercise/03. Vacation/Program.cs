using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double sum = 0;

            switch (typeOfGroup)
            {
                case "Students":
                    if (dayOfWeek == "Friday")
                    {
                        sum = people * 8.45;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        sum = people * 9.80;
                    }
                    else
                    {
                        sum = people * 10.46;
                    }
                    if (people >= 30)
                    {
                        sum = sum - (sum * 0.15);
                    }
                    break;

                case "Business":
                    if (dayOfWeek == "Friday")
                    {
                        sum = people * 10.90;

                        if (people >= 100)
                        {
                            sum = sum - (10 * 10.90);
                        }
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        sum = people * 15.60;

                        if (people >= 100)
                        {
                            sum = sum - (10 * 15.60);
                        }
                    }
                    else
                    {
                        sum = people * 16.00;

                        if (people >= 100)
                        {
                            sum = sum - (10 * 16.00);
                        }
                    }
                    break;

                case "Regular":
                    if (dayOfWeek == "Friday")
                    {
                        sum = people * 15.00;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        sum = people * 20.00;
                    }
                    else
                    {
                        sum = people * 22.50;
                    }

                    if (people >= 10 && people <= 20)
                    {
                        sum = sum - (sum * 0.05);
                    }
                    break;
            }
            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}
