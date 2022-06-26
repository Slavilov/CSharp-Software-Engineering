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
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            int temporaryNum = 0;

            while (input != "End")
            {
                List<string> inputList = input.Split().ToList();

                if (inputList[0] == "Add")
                {
                    numbers.Add(int.Parse(inputList[1]));
                }

                else if (inputList[0] == "Insert")
                {
                    if (int.Parse(inputList[2]) > numbers.Count - 1 || int.Parse(inputList[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();

                        if (input == "End")
                        {
                            break;
                        }

                        continue;
                    }

                    numbers.Insert(int.Parse(inputList[2]), int.Parse(inputList[1]));
                }

                else if (inputList[0] == "Remove")
                {
                    if (int.Parse(inputList[1]) > numbers.Count - 1 || int.Parse(inputList[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();

                        if (input == "End")
                        {
                            break;
                        }

                        continue;
                    }

                    numbers.RemoveAt(int.Parse(inputList[1]));

                }

                else if (inputList[1] == "left")
                {
                    for (int i = 0; i < int.Parse(inputList[2]); i++)
                    {
                        temporaryNum = (numbers[0]);
                        numbers.RemoveAt(0);
                        numbers.Add(temporaryNum);
                    }
                }

                else if (inputList[1] == "right")
                {
                    for (int i = 0; i < int.Parse(inputList[2]); i++)
                    {
                        temporaryNum = (numbers[numbers.Count - 1]);
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, temporaryNum);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

        }
    }
}