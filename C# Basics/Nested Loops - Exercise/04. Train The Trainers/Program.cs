using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double grade = 0;
            double counterGrade = 0;
            double averageGrade = 0; ;
            double counterAllGrades = 0;
            int i = 0;
            int counter = 0;

            while (input != "Finish")
            {
                for (i = 0; i < n; i++)
                {
                    grade = double.Parse(Console.ReadLine());
                    counterGrade += grade;
                }
                counter++;
                counterAllGrades += counterGrade;

                Console.WriteLine($"{input} - {(counterGrade / n):f2}.");
                counterGrade = 0;
                input = Console.ReadLine();

            }
            Console.WriteLine($"Student's final assessment is {(counterAllGrades / (n * counter)):f2}.");

        }
    }
}
