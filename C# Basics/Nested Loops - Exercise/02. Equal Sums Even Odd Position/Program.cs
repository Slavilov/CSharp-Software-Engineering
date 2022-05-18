using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int oddNum;
            int evenNum;
            string numToLetter;

            for (int i = n1; i <= n2; i++)
            {
                oddNum = 0;
                evenNum = 0;

                numToLetter = i.ToString();

                for (int j = 0; j < numToLetter.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenNum += numToLetter[j];
                    }
                    else
                    {
                        oddNum += numToLetter[j];
                    }

                }
                if (oddNum == evenNum)
                {
                    Console.Write(i + " ");
                }

            }
        }
    }
}
