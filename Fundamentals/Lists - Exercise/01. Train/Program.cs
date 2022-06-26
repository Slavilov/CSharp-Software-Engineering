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
            List<int> wagonsAndPassangers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string input = string.Empty;

            while (input != "end")
            {
                input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                List<string> inputList = input.Split(" ").ToList();

                if (inputList[0] == "Add")
                {
                    wagonsAndPassangers.Add(int.Parse(inputList[1]));
                }
                else
                {
                    for (int i = 0; i < wagonsAndPassangers.Count; i++)
                    {
                        if (wagonsAndPassangers[i] + int.Parse(inputList[0]) <= maxCapacity)
                        {
                            wagonsAndPassangers[i] = wagonsAndPassangers[i] + int.Parse(inputList[0]);
                            break;
                        }
                    }
                }
            }
            Console.Write(string.Join(" ", wagonsAndPassangers));
        }
    }
}