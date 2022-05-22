using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int goals = 0;
            string bestPlayer = string.Empty;
            int bestGoals = 0;

            while (input != "END")
            {
                string footballer = input;
                goals = int.Parse(Console.ReadLine());

                if (goals > bestGoals)
                {
                    bestPlayer = input;
                    bestGoals = goals;
                }
                if (goals >= 10)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");

            if (bestGoals >= 3)
            {
                Console.WriteLine($"He has scored {bestGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestGoals} goals.");
            }
        }
    }
}
