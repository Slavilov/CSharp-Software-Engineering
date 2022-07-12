using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace AssociativeArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> infoAboutStudentsGrades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (infoAboutStudentsGrades.ContainsKey(studentName))
                {
                    infoAboutStudentsGrades[studentName].Add(studentGrade);
                }
                else
                {
                    infoAboutStudentsGrades.Add(studentName, new List<double>());
                    infoAboutStudentsGrades[studentName].Add(studentGrade);
                }
            }

            foreach (var student in infoAboutStudentsGrades)
            {
                if (student.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }
            }

        }
    }
}