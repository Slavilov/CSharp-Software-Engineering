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
            while (input != "END")
            {
                PalindromeCheck(input);
                input = Console.ReadLine();
            }
        }

        static void PalindromeCheck(string input)
        {
            char[] stringArray = input.ToCharArray();
            Array.Reverse(stringArray);
            string reverseString = new string(stringArray);

            if (input == reverseString)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}