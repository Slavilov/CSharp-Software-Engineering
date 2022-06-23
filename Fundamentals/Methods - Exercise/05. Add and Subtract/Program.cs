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
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            int sum = SumOfFirstTwo(numberOne, numberTwo);
            Console.WriteLine(SubstractionFromTheSum(sum, numberThree));
        }

        static int SumOfFirstTwo(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        static int SubstractionFromTheSum(int sum, int numberThree)
        {
            return sum - numberThree;
        }
    }
}