using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _6._Equality_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> setOfPpl = new SortedSet<Person>();
            HashSet<Person> hashOfPpl = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                Person newPerson = new Person();
                newPerson.Name = input[0].ToLower();
                newPerson.Age = int.Parse(input[1]);

                setOfPpl.Add(newPerson);
                hashOfPpl.Add(newPerson);
            }
            Console.WriteLine(setOfPpl.Count);
            Console.WriteLine(hashOfPpl.Count);
        }
    }
}