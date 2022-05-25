using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1 = char.Parse(Console.ReadLine());
            char c2 = char.Parse(Console.ReadLine());
            char c3 = char.Parse(Console.ReadLine());
            int counter = 0;

            for (char firstC = c1; firstC <= c2; firstC++)
            {
                for (char secondC = c1; secondC <= c2; secondC++)
                {
                    for (char thirdC = c1; thirdC <= c2; thirdC++)
                    {
                        if (firstC != c3 && secondC != c3 && thirdC != c3)
                        {
                            counter++;
                            Console.Write($"{firstC}{secondC}{thirdC} ");
                        }
                    }
                }
            }
            Console.Write(counter);
        }
    }
}
