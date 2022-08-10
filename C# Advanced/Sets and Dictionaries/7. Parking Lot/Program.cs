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
            HashSet<string> carPlates = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();
                
                if (input == "END")
                {
                    if (carPlates.Count > 0)
                    {
                        foreach (string car in carPlates)
                        {
                            Console.WriteLine(car);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Parking Lot is Empty");
                    }

                    break;
                }

                List<string> listOfInput = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
                
                string command = listOfInput[0];
                string plate = listOfInput[1];

                if (command == "IN")
                {
                    carPlates.Add(plate);
                }
                else
                {
                    carPlates.Remove(plate);
                }
            }
        }
    }
}
