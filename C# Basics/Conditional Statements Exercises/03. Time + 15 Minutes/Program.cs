using System;

namespace Conditions.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int hoursToMins = hours * 60;

            int sumOfAll = hoursToMins + minutes;
            int sumPlus = sumOfAll + 15;

            int newHours = sumPlus / 60;
            int newMinutes = sumPlus % 60;

            if (newHours >= 24)
            {
                newHours = 0;
                if (newMinutes < 10)
                {
                    Console.WriteLine($"{newHours}:0{newMinutes}");
                }
                else
                {
                    Console.WriteLine($"{newHours}:{newMinutes}");
                }
            }
            else if (newMinutes < 10)
            {
                Console.WriteLine($"{newHours}:0{newMinutes}");
            }
            else
            {
                Console.WriteLine($"{newHours}:{newMinutes}");
            }
        }
    }
}
