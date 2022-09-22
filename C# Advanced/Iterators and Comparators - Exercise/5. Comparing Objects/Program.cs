using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _5._Comparing_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPpl = new List<Person>();

            while (true)
            {
                List<string> input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (input[0] == "END")
                {
                    break;
                }

                Person newPerson = new Person();
                newPerson.Name = input[0];
                newPerson.Age = int.Parse(input[1]);
                newPerson.Town = input[2];

                listOfPpl.Add(newPerson);
            }
            int positionOfPersonToCompare = int.Parse(Console.ReadLine());
            Person comparer = listOfPpl[positionOfPersonToCompare-1];

           //Person comparer = new Person();
           //comparer.Name = listOfPpl[positionOfPersonToCompare - 1].Name;
           //comparer.Age = listOfPpl[positionOfPersonToCompare - 1].Age;
           //comparer.Town = listOfPpl[positionOfPersonToCompare - 1].Town;

            int equal = 0;

            foreach (var person in listOfPpl)
            {
                if (comparer.Name == person.Name)
                {
                    if (comparer.Age == person.Age)
                    {
                        if (comparer.Town == person.Town)
                        {
                            equal++;
                        }
                    }
                }
            }

            if (equal > 1)
            {
                Console.WriteLine($"{equal} {listOfPpl.Count - equal} {listOfPpl.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}