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
            string input = Console.ReadLine();
            SumOfCharacters(input);
        }

        static void SumOfCharacters(string input)
        {
            List<string> inputList = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string firstString = inputList[0];
            string secondString = inputList[1];
            int sum = 0;
            int sumOfRemainingChars = 0;

            if (firstString.Length > secondString.Length)
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    sum += (int)firstString[i] * (int)secondString[i];

                    if (i == secondString.Length - 1)
                    {
                        for (int j = i + 1; j < firstString.Length; j++)
                        {
                            sumOfRemainingChars += (int)firstString[j];
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    sum += (int)firstString[i] * (int)secondString[i];

                    if (i == firstString.Length - 1)
                    {
                        for (int j = i + 1; j < secondString.Length; j++)
                        {
                            sumOfRemainingChars += (int)secondString[j];
                        }
                    }
                }
            }

            Console.WriteLine(sum + sumOfRemainingChars);

        }
    }
}