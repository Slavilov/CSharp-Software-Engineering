using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string numToLetter = string.Empty;
            int counter = 0;

            for (int i = 1111; i <= 9999; i++)
            {
                numToLetter = i.ToString();

                for (int j = 0; j < numToLetter.Length; j++)
                {
                    //Console.WriteLine(numToLetter[j]);
                    if (numToLetter[j] != '0' && n % int.Parse(numToLetter[j].ToString()) == 0)
                    {
                        counter++;
                    }
                    if (counter == 4)
                    {
                        Console.Write(numToLetter + " ");
                    }
                }
                counter = 0;
            }
        }
    }
}
