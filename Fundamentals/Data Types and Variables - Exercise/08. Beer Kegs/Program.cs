using System;
using System.Text;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int nKegs = int.Parse(Console.ReadLine());
            string biggestKeg = string.Empty;
            double volume = 0;
            double maxVolume = 0;

            for (int j = 1; j <= nKegs; j++)
            {
                string kegName = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                volume = Math.PI * radius * radius * height;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestKeg = kegName;
                }

            }
            Console.WriteLine(biggestKeg);
        }
    }
}