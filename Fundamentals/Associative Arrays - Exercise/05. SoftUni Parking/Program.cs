using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace AssociativeArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingLot = new Dictionary<string, string>();
            List<string> inputList = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                inputList = Console.ReadLine().Split(' ').ToList();
                string userName = inputList[1];

                if (inputList[0] == "register")
                {
                    string licensePlate = inputList[2];

                    if (parkingLot.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                    else
                    {
                        parkingLot.Add(userName, licensePlate);
                        Console.WriteLine($"{userName} registered {licensePlate} successfully");
                    }

                }
                else
                {
                    if (!parkingLot.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        parkingLot.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
            }
            foreach (var registeredUser in parkingLot)
            {
                Console.WriteLine($"{registeredUser.Key} => {registeredUser.Value}");
            }

        }
    }
}