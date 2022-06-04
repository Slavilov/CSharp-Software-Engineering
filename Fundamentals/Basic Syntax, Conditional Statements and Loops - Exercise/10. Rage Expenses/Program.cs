using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double sumHeadset = 0;
            double sumMouse = 0;
            double sumKeyboard = 0;
            double sumDisplay = 0;
            int counterKeyboardSmash = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    sumHeadset += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    sumMouse += mousePrice;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    sumKeyboard += keyboardPrice;
                    counterKeyboardSmash++;

                    if (counterKeyboardSmash % 2 == 0)
                    {
                        sumDisplay += displayPrice;
                    }
                }

            }
            Console.WriteLine($"Rage expenses: {(sumHeadset + sumMouse + sumKeyboard + sumDisplay):f2} lv.");
        }
    }
}