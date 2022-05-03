using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConcatenateData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string city = Console.ReadLine();
            Console.WriteLine($"You are {name} {surname}, a {age}-years old person from {city}.");

        }
    }
}
