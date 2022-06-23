using System;
using System.Text;
using System.Numerics;
using System.Linq;

namespace PasswordCheckUp
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(MiddleCharacters(input));
        }

        static string MiddleCharacters(string input)
        {
            string twoChars = string.Empty;
            if (input.Length % 2 == 0)
            {
                for (int i = (input.Length / 2) - 1; i < (input.Length / 2) + 1; i++)
                {
                    twoChars += input[i];
                }
                return twoChars;

            }
            else
            {
                for (int i = (input.Length / 2); i < (input.Length / 2) + 1; i++)
                {
                    return input[i].ToString();
                }
            }
            return twoChars;
        }
    }
}