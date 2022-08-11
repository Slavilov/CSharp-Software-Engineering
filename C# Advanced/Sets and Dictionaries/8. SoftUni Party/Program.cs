using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UniqeNames
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> guests = new SortedSet<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "PARTY")
                {
                    while (true)
                    {
                        string secondInput = Console.ReadLine();
                        if (secondInput == "END")
                        {
                            Console.WriteLine(guests.Count);

                            foreach (string s in guests)
                            {
                                Console.WriteLine(s);
                            }
                            return;
                        }
                        guests.Remove(secondInput);
                    }
                }

                guests.Add(input);
            }
        }
    }
}