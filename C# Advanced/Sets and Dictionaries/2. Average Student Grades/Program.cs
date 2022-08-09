using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i< n; i++)
            {
                List<string> inputList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                string student = inputList[0];
                decimal grade = decimal.Parse(inputList[1]);

                if (studentGrades.ContainsKey(student))
                {
                    studentGrades[student].Add(grade);
                }
                else
                {
                    studentGrades.Add(student, new List<decimal>());
                    studentGrades[student].Add(grade);
                }
            }

            foreach(var student in studentGrades)
            {
                Console.Write($"{student.Key} -> {string.Join(" ", student.Value.Select(v=>v.ToString("F2")))} (avg: {student.Value.Average():f2})");
                Console.WriteLine();
            }

        }
    }
}

