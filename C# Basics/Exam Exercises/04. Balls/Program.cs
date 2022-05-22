using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string colourOfBall = string.Empty;
            double points = 0;

            int counterBalls = 0;
            int counterRed = 0;
            int counterOrange = 0;
            int counterYellow = 0;
            int counterWhite = 0;
            int counterBlack = 0;
            int otherColours = 0;

            for (int i = 1; i <= n; i++)
            {
                colourOfBall = Console.ReadLine();
                counterBalls++;
                switch (colourOfBall)
                {
                    case "red":
                        points += 5;
                        counterRed++;
                        break;

                    case "orange":
                        points += 10;
                        counterOrange++;
                        break;

                    case "yellow":
                        points += 15;
                        counterYellow++;
                        break;

                    case "white":
                        points += 20;
                        counterWhite++;
                        break;

                    case "black":
                        points = Math.Floor(points / 2);
                        counterBlack++;
                        break;

                    default:
                        otherColours++;
                        break;

                }
                if (counterBalls == n)
                {
                    break;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {counterRed}");
            Console.WriteLine($"Orange balls: {counterOrange}");
            Console.WriteLine($"Yellow balls: {counterYellow}");
            Console.WriteLine($"White balls: {counterWhite}");
            Console.WriteLine($"Other colors picked: {otherColours}");
            Console.WriteLine($"Divides from black balls: {counterBlack}");
        }
    }
}
