using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int purvoChislo = int.Parse(Console.ReadLine());
            int vtoroChislo = int.Parse(Console.ReadLine());
            int magicN = int.Parse(Console.ReadLine());
            int counter = 0;
            bool flag = false;

            for (int i = purvoChislo; i <= vtoroChislo; ++i)
            {
                for (int j = purvoChislo; j <= vtoroChislo; ++j)
                {
                    counter++;
                    if (i + j == magicN)
                    {
                        flag = true;
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicN})");
                        break;
                    }
                }
                if (flag == true)
                {
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicN}");
            }
        }
    }
}
