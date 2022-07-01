using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace SongsExerciseForObjectsAndClasses
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> listOfStudents = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                List<string> studentsInfo = Console.ReadLine().Split(' ').ToList();
                Student newStudent = new Student(studentsInfo[0], studentsInfo[1], double.Parse(studentsInfo[2]));

                listOfStudents.Add(newStudent);
            }
            List<Student> sortedStudents = listOfStudents.OrderBy(x => x.Grade).ToList();
            sortedStudents.Reverse();

            foreach (Student student in sortedStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}