using System;

namespace Conditions.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int gpu = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double gpuPrice = gpu * 250;
            double cpuPrice = cpu * (gpuPrice * 0.35);
            double ramPrice = ram * (gpuPrice * 0.10);

            double sum = (gpuPrice + cpuPrice + ramPrice);

            if (gpu > cpu)
            {
                sum = sum - (sum * 0.15);
            }

            if (budget >= sum)
            {
                Console.WriteLine($"You have {budget - sum:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {sum - budget:F2} leva more!");
            }
        }
    }
}
