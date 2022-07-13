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
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                char[] newArray = input.ToCharArray();
                Array.Reverse(newArray);
                string newString = new string(newArray);
                Console.WriteLine($"{input} = {newString}");
            }
        }
    }
}