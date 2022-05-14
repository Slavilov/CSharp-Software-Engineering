using System;

namespace ExamPreperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxBadGrades = int.Parse(Console.ReadLine());
            string zadacha = "";
            int grade = 0;
            int counter = 0;
            int counterBadGrade = 0;
            double counterGrade = 0;
            string counterZadacha = "";

            while (true)
            {
                counterZadacha = zadacha;
                zadacha = Console.ReadLine();

                if (zadacha == "Enough")
                {
                    break;
                }

                grade = int.Parse(Console.ReadLine());
                counter++;
                counterGrade = grade + counterGrade;

                if (grade <= 4)
                {
                    counterBadGrade++;
                }
                if (counterBadGrade >= maxBadGrades)
                {
                    break;
                }
            }
            if (zadacha == "Enough")
            {
                Console.WriteLine($"Average score: {(counterGrade / counter):f2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {counterZadacha}");
            }
            else
            {
                Console.WriteLine($"You need a break, {counterBadGrade} poor grades.");
            }

        }
    }
}
