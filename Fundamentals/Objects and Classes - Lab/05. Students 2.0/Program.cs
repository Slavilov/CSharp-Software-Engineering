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
        public string Age { get; set; }
        public string HomeTown { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listOfStudentsInfo = new List<Student>();
            List<string> temporaryList = new List<string>();
            string input = Console.ReadLine();
            bool flagForStudent = false;

            while (input != "end")
            {
                temporaryList = input.Split().ToList();

                string firstName = temporaryList[0];
                string lastName = temporaryList[1];
                string age = temporaryList[2];
                string homeTown = temporaryList[3];

                Student newStudent = new Student();
                {
                    newStudent.FirstName = firstName;
                    newStudent.LastName = lastName;
                    newStudent.Age = age;
                    newStudent.HomeTown = homeTown;
                }

                for (int i = 0; i < listOfStudentsInfo.Count; i++)
                {
                    if (listOfStudentsInfo[i].FirstName == firstName && listOfStudentsInfo[i].LastName == lastName)
                    {
                        listOfStudentsInfo.RemoveAt(i);
                        listOfStudentsInfo.Add(newStudent);
                        flagForStudent = true;
                        break;
                    }
                }

                if (flagForStudent == false)
                {
                    listOfStudentsInfo.Add(newStudent);
                }

                if (listOfStudentsInfo.Count == 0)
                {
                    listOfStudentsInfo.Add(newStudent);
                }

                flagForStudent = false;
                input = Console.ReadLine();
            }
            string cityName = Console.ReadLine();

            foreach (Student student in listOfStudentsInfo)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }

    }
}