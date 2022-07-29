using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SimpelCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Stack<int> stackOfClothes = new Stack<int>();

            int capacityOfRack = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for (int i = 0; i < listOfInput.Count; i++)
            {
                stackOfClothes.Push(listOfInput[i]);
            }

            counter++;
            while (stackOfClothes.Count > 0)
            {
                int lastClothes = stackOfClothes.Peek();
                sum += stackOfClothes.Pop();

                if (sum == capacityOfRack)
                {
                    sum = 0;
                    if (capacityOfRack > 0)
                    {
                        counter++;
                    }
                }
                else if (sum > capacityOfRack)
                {
                    sum = sum - lastClothes;
                    counter++;
                    stackOfClothes.Push(lastClothes);
                    sum = 0;
                }
            }

            Console.WriteLine(counter);

        }
    }
}