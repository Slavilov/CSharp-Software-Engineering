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
            List<string> inputList = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            bool flag = false;

            foreach (var username in inputList)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    foreach (char c in username)
                    {
                        if (char.IsLetterOrDigit(c) || c == '_' || c == '-')
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if (flag == true)
                {
                    Console.WriteLine(username);
                }
                flag = false;
            }
        }
    }
}