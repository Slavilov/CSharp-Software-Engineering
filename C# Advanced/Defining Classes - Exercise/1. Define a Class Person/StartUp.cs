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
            Person firstPerson = new Person();
            firstPerson.Age = 20;
            firstPerson.Name = "Peter";

            Console.WriteLine($"First Person Name: {firstPerson.Name}");
            Console.WriteLine($"First Person Age: {firstPerson.Age}");

            Person secondPerson = new Person(Console.ReadLine(), int.Parse(Console.ReadLine()));

            Console.WriteLine($"Second Person Name: {secondPerson.Name}");
            Console.WriteLine($"Second Person Age: {secondPerson.Age}");
        }
    }
}
