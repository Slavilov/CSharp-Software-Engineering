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
            bool flagIfChangesAreMade = false;

            while (input != "end")
            {
                input = Console.ReadLine();
                List<string> stringToList = input.Split(" ").ToList();

                switch (stringToList[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(stringToList[1]));
                        flagIfChangesAreMade = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(stringToList[1]));
                        flagIfChangesAreMade = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(stringToList[1]));
                        flagIfChangesAreMade = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(stringToList[2]), int.Parse(stringToList[1]));
                        flagIfChangesAreMade = true;
                        break;
                    case "Contains":
                        CheckIfItCointainsSuchNumber(numbers, int.Parse(stringToList[1]));
                        break;
                    case "PrintEven":
                        PrintEvenNumbers(numbers);
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        PrintOddNumbers(numbers);
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        SumAllNums(numbers);
                        break;
                    case "Filter":
                        Filter(numbers, stringToList[1], int.Parse(stringToList[2]));
                        Console.WriteLine();
                        break;
                }
            }
            if (flagIfChangesAreMade == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static void CheckIfItCointainsSuchNumber(List<int> numbers, int number)
        {
            bool flag = false;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == number)
                {
                    flag = true;
                    Console.WriteLine("Yes");
                    break;
                }
                else
                {
                    flag = false;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("No such number");
            }
        }

        static void PrintEvenNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }

        static void PrintOddNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }

        static void SumAllNums(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }

        static void Filter(List<int> numbers, string condition, int number)
        {
            if (condition == "<")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < number)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            else if (condition == ">")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > number)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            else if (condition == ">=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] >= number)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            else if (condition == "<=")
            {
                for (int i = 0; i > numbers.Count; i++)
                {
                    if (numbers[i] <= number)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
        }
    }
}