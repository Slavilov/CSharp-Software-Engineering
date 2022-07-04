using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace SongsExerciseForObjectsAndClasses
{
    public class Person
    {
        public Person(string name, string id, int age)
        {
            this.NameOfPerson = name;
            this.IdOfPerson = id;
            this.AgeOfPerson = age;
        }

        public string NameOfPerson { get; set; }
        public string IdOfPerson { get; set; }
        public int AgeOfPerson { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputCommands = new List<string>();
            List<Person> listOfPersons = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }


                inputCommands = input.Split(' ').ToList();

                string name = inputCommands[0];
                string id = inputCommands[1];
                int age = int.Parse(inputCommands[2]);

                if (listOfPersons.Exists(x => x.IdOfPerson == id))
                {
                    int index = listOfPersons.FindIndex(x => x.IdOfPerson == id);

                    listOfPersons[index].NameOfPerson = name;
                    listOfPersons[index].AgeOfPerson = age;
                    continue;
                }

                Person newPerson = new Person(name, id, age);
                listOfPersons.Add(newPerson);
            }
            List<Person> sortedList = listOfPersons.OrderBy(x => x.AgeOfPerson).ToList();

            foreach (Person person in sortedList)
            {
                Console.WriteLine($"{person.NameOfPerson} with ID: {person.IdOfPerson} is {person.AgeOfPerson} years old.");
            }
        }
    }
}