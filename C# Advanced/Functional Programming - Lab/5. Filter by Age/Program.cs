using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> persons = new Dictionary<string, int>();
            
            for(int i = 0; i<n; i++)
            {
                List<string> person = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();
                persons.Add(person[0], int.Parse(person[1]));
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Filter(persons, condition, age, format);
        }

        static void Filter (Dictionary<string, int> persons,string Condition, int Age, string Format)
        {
            if (Condition == "older")
            {
                if (Format == "name age")
                {
                    foreach (var person in persons)
                    {
                        if (person.Value >= Age)
                        {
                            Console.WriteLine($"{person.Key} - {person.Value}");
                        }
                    }
                }
                else if (Format == "name")
                {
                    foreach (var person in persons)
                    {
                        if (person.Value >= Age)
                        {
                            Console.WriteLine($"{person.Key}");
                        }
                    }

                }
                else if (Format == "age")
                {
                    foreach (var person in persons)
                    {
                        if (person.Value >= Age)
                        {
                            Console.WriteLine($"{person.Value}");
                        }
                    }
                }
            }
            else if (Condition == "younger")
            {
                if (Format == "name age")
                {
                    foreach (var person in persons)
                    {
                        if (person.Value < Age)
                        {
                            Console.WriteLine($"{person.Key} - {person.Value}");
                        }
                    }
                }
                else if (Format == "name")
                {
                    foreach (var person in persons)
                    {
                        if (person.Value < Age)
                        {
                            Console.WriteLine($"{person.Key}");
                        }
                    }

                }
                else if (Format == "age")
                {
                    foreach (var person in persons)
                    {
                        if (person.Value < Age)
                        {
                            Console.WriteLine($"{person.Value}");
                        }
                    }
                }
            }
        }
    }
}
