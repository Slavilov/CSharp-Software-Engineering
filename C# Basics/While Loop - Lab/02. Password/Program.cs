using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string passwordForLogin = Console.ReadLine();

            if (passwordForLogin == password)
            {
                Console.WriteLine($"Welcome {username}!");
            }

            while (passwordForLogin != password)
            {
                passwordForLogin = Console.ReadLine();
                if (passwordForLogin == password)
                {
                    Console.WriteLine($"Welcome {username}!");
                }
            }
        }
    }
}
