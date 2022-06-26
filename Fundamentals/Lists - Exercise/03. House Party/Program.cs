using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace PasswordCheckUp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> trackOfGuests = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> inputList = Console.ReadLine().Split(' ').ToList();

                if (inputList.Count == 3)
                {
                    if (trackOfGuests.Contains(inputList[0]))
                    {
                        Console.WriteLine($"{inputList[0]} is already in the list!");
                    }
                    else
                    {
                        trackOfGuests.Add(inputList[0]);
                    }
                }
                else if (inputList.Count > 3)
                {
                    if (trackOfGuests.Contains(inputList[0]))
                    {
                        trackOfGuests.Remove(inputList[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{inputList[0]} is not in the list!");
                    }
                }
            }
            foreach (var guest in trackOfGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}