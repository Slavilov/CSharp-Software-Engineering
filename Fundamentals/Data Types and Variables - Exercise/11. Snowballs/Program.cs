using System;
using System.Text;
using System.Numerics;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger highestSnowballValue = 0;
            BigInteger sum = 0;
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;

            int maxSnowballSnow = 0;
            int maxSnowballQuality = 0;
            int MaxSnowballTime = 0;

            for (int i = 1; i <= n; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());

                sum = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (sum > highestSnowballValue)
                {
                    highestSnowballValue = sum;
                    maxSnowballSnow = snowballSnow;
                    maxSnowballQuality = snowballQuality;
                    MaxSnowballTime = snowballTime;
                }
            }
            Console.WriteLine($"{maxSnowballSnow} : {MaxSnowballTime} = {highestSnowballValue} ({maxSnowballQuality})");
        }
    }
}