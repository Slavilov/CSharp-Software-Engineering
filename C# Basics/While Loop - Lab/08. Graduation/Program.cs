using System;
using System.Threading;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int gradeCounter = 0;
            double grade = 0;
            double averageGrade = 0;
            double sumOfGrades = 0;

            while (gradeCounter < 12)
            {
                gradeCounter += 1;
                grade = double.Parse(Console.ReadLine());
                sumOfGrades = sumOfGrades + grade;
                if (grade < 4)
                {
                    Console.WriteLine($"{name} has been excluded at {gradeCounter} grade");
                    return;
                }
            }
            averageGrade = sumOfGrades / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
    }
}
