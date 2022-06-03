using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            int counter = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string pass = Console.ReadLine();
            while (pass != password)
            {
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                pass = Console.ReadLine();
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}