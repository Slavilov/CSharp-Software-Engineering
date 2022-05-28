using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int n1 = a; n1 <= b; n1++)
            {
                for (int n2 = a; n2 <= b; n2++)
                {
                    for (int n3 = a; n3 <= b; n3++)
                    {
                        for (int n4 = a; n4 <= b; n4++)
                        {
                            if (n1 > n4 && (n2 + n3) % 2 == 0)
                            {
                                if (n1 % 2 == 0 && n4 % 2 != 0)
                                {
                                    Console.Write($"{n1}{n2}{n3}{n4} ");
                                }
                                else if (n1 % 2 != 0 && n4 % 2 == 0)
                                {
                                    Console.Write($"{n1}{n2}{n3}{n4} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
