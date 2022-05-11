using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double pointsGivenAcademy = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double sumOfPoints = 0;
            for (int i = 0; i < n; i++)
            {
                string nameOfJudge = Console.ReadLine();
                double pointsOfJudge = double.Parse(Console.ReadLine());
                double pointsOfJudgeName = nameOfJudge.Length;

                sumOfPoints = sumOfPoints + (pointsOfJudgeName * pointsOfJudge) / 2;

                if (sumOfPoints + pointsGivenAcademy > 1250.5)
                {
                    i = n;
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {(sumOfPoints + pointsGivenAcademy):f1}!");
                }

            }
            if (sumOfPoints + pointsGivenAcademy < 1250.5)
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.5 - (sumOfPoints + pointsGivenAcademy):f1} more!");
            }


        }
    }
}
