using System;

namespace _09_10_Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double group1 = 0;
            double group2 = 0;
            double group3 = 0;
            double group4 = 0;
            double group5 = 0;
            double sumOfAll = 0;

            for (int i = 0; i < n; i++)
            {
                int personPerGroup = int.Parse(Console.ReadLine());
                sumOfAll = sumOfAll + personPerGroup;

                if (personPerGroup <= 5)
                {
                    group1 = group1 + personPerGroup;
                }
                else if (personPerGroup >= 6 && personPerGroup <= 12)
                {
                    group2 = group2 + personPerGroup;
                }
                else if (personPerGroup >= 13 && personPerGroup <= 25)
                {
                    group3 = group3 + personPerGroup;
                }
                else if (personPerGroup >= 26 && personPerGroup <= 40)
                {
                    group4 = group4 + personPerGroup;
                }
                else if (personPerGroup >= 41)
                {
                    group5 = group5 + personPerGroup;
                }
            }
            Console.WriteLine($"{(group1 / sumOfAll) * 100:f2}%");
            Console.WriteLine($"{(group2 / sumOfAll) * 100:f2}%");
            Console.WriteLine($"{(group3 / sumOfAll) * 100:f2}%");
            Console.WriteLine($"{(group4 / sumOfAll) * 100:f2}%");
            Console.WriteLine($"{(group5 / sumOfAll) * 100:f2}%");
        }
    }
}
