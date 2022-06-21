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
            string word = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string BigString = NewCombinedString(count, word);
            Console.WriteLine(BigString);
        }

        static string NewCombinedString(int count, string word)
        {
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                newString.Append(word);
            }
            return newString.ToString();
        }
    }
}