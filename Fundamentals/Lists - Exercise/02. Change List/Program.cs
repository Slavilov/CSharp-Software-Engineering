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
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = string.Empty;

            while (input != "end")
            {
                input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                List<string> inputList = input.Split().ToList();

                if (inputList[0] == "Delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(inputList[1]));
                }
                else
                {
                    numbers.Insert(int.Parse(inputList[2]), int.Parse(inputList[1]));
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}