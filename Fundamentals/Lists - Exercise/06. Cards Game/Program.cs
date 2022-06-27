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
            List<int> firstHand = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondHand = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int temporaryCard = 0;

            while (firstHand.Count > 0 && secondHand.Count > 0)
            {
                for (int i = 0; i < firstHand.Count; i++)
                {
                    if (firstHand[i] > secondHand[i])
                    {
                        temporaryCard = firstHand[i];
                        firstHand.RemoveAt(i);
                        firstHand.Add(temporaryCard);
                        firstHand.Add(secondHand[i]);
                        secondHand.RemoveAt(i);
                        i = i - 1;

                        if (secondHand.Count == 0)
                        {
                            break;
                        }
                    }
                    else if (firstHand[i] < secondHand[i])
                    {
                        temporaryCard = secondHand[i];
                        secondHand.RemoveAt(i);
                        secondHand.Add(temporaryCard);
                        secondHand.Add(firstHand[i]);
                        firstHand.RemoveAt(i);
                        i = i - 1;

                        if (firstHand.Count == 0)
                        {
                            break;
                        }
                    }
                    else if (firstHand[i] == secondHand[i])
                    {
                        firstHand.RemoveAt(i);
                        secondHand.RemoveAt(i);
                        i = i - 1;
                    }
                }
            }

            if (firstHand.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
            }
        }
    }
}