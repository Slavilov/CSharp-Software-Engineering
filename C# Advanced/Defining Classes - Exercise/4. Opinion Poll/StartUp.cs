
using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> listOfPpl = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                List<string> listOfNamesAndAges = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                string name = listOfNamesAndAges[0];
                int age = int.Parse(listOfNamesAndAges[1]);

                Person person = new Person(name, age);
                listOfPpl.Add(person);
            }
            listOfPpl = listOfPpl.OrderBy(p => p.Name).Where(p => p.Age > 30).ToList();
            foreach (var person in listOfPpl)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}