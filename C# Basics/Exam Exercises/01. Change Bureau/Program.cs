using System;

namespace Conditions.GradeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double chineseJuan = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            double bitcoinsToLevs = bitcoins * 1168.0;
            double chineseJuanToDollars = chineseJuan * 0.15;
            double dollarToLevs = chineseJuanToDollars * 1.76;
            double sumOfLevs = bitcoinsToLevs + dollarToLevs;

            double euroToLev = sumOfLevs / 1.95;
            comission = (euroToLev * (comission / 100));

            double sumOfAll = euroToLev - comission;

            Console.WriteLine($"{sumOfAll:f2}");

        }
    }
}
