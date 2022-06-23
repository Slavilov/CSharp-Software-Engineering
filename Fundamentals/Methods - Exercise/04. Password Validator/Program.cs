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
            string password = Console.ReadLine();
            NumberOfCharactersValidator(password);
            LettersAndDigitsCheckUp(password);
            DigitsValidator(password);

        }


        static bool NumberOfCharactersValidator(string password)
        {

            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            else
            {
                return true;
            }

        }

        static bool LettersAndDigitsCheckUp(string password)
        {
            foreach (char c in password)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                }
            }
            return true;
        }

        static bool DigitsValidator(string password)
        {

            int digitCounter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                switch (password[i])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        digitCounter++;
                        break;
                }
            }

            if (digitCounter < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            else
            {
                Console.WriteLine("Password is valid");
                return true;
            }
        }

    }
}