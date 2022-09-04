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

            Console.WriteLine($"First Person Name: {firstPerson.Name}");
            Console.WriteLine($"First Person Age: {firstPerson.Age}");
            Console.WriteLine();
            Person secondPerson = new Person(23);

            Console.WriteLine($"Second Person Name: {secondPerson.Name}");
            Console.WriteLine($"Second Person Age: {secondPerson.Age}");
            Console.WriteLine();
            Person thirdPerson = new Person("Velichko", 23);

            Console.WriteLine($"Third Person Name: {thirdPerson.Name}");
            Console.WriteLine($"Third Person Age: {thirdPerson.Age}");

        }
    }
}

