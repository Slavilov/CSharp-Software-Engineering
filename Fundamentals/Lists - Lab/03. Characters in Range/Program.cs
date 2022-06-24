using System;
using System.Text;
using System.Numerics;
using System.Linq;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            Console.WriteLine(CharactersInBetween(one, two));

        }

        static string CharactersInBetween(char one, char two)
        {
            //StringBuilder charsInBetween = new StringBuilder();
            string newString = string.Empty;

            if (two < one)
            {
                for (int i = two + 1; i < one; i++)
                {
                    newString += (char)i + " ";
                }
            }
            else
            {
                for (int i = one + 1; i < two; i++)
                {
                    newString += (char)i + " ";
                }
            }
            return newString;
        }

    }
}