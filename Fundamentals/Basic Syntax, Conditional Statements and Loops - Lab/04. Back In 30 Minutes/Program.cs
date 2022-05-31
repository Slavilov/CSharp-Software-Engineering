using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int hrsInMins = hours * 60;
            int sum = hrsInMins + minutes + 30;

            int hrs = sum / 60;
            int mins = sum % 60;

            if (hrs >= 24)
            {
                hrs = 0;
                Console.WriteLine($"{hrs}:{mins:d2}");
            }
            else
            {
                Console.WriteLine($"{hrs}:{mins:d2}");
            }
        }
    }
}