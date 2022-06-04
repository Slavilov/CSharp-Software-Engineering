using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string nString = n.ToString();
            double sum = 1;
            double counter = 0;

            for (int i = 0; i < nString.Length; i++)
            {
                sum = 1;
                char a = nString[i];
                int b = a - '0';

                if (b == 0)
                {
                    counter = counter + 1;
                    continue;
                }

                for (int j = 1; j <= b; j++)
                {
                    sum = sum * j;
                }
                counter += sum;
            }
            if (counter == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}