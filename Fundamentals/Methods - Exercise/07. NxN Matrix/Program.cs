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
            int n = int.Parse(Console.ReadLine());
            MatrixPrinter(n);
        }

        static void MatrixPrinter(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}