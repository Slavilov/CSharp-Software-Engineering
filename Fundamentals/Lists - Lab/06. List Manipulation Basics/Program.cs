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
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string input = string.Empty;

            while (input != "end")
            {
                input = Console.ReadLine();
                List<string> stringToList = input.Split(" ").ToList();

                switch (stringToList[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(stringToList[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(stringToList[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(stringToList[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(stringToList[2]), int.Parse(stringToList[1]));
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}