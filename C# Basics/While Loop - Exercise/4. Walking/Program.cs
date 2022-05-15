using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            double sum = 0;
            double inputConvert = 0;

            while (true)
            {

                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    inputConvert = double.Parse(Console.ReadLine());
                    sum = sum + inputConvert;

                    if (sum < goal)
                    {
                        Console.WriteLine($"{goal - sum} more steps to reach goal.");
                    }
                    else
                    {
                        Console.WriteLine($"Goal reached! Good job!");
                        Console.WriteLine($"{sum - goal} steps over the goal!");
                    }

                    break;
                }

                inputConvert = double.Parse(input);
                sum = sum + inputConvert;

                if (sum >= goal)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{sum - goal} steps over the goal!");
                    break;
                }
            }
        }
    }
}
