using System;
namespace barcodeGeneratorNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            string startNum = Console.ReadLine(); string finalNum = Console.ReadLine();
            for (int a = startNum[0]; a <= finalNum[0]; a++)
            {
                for (int b = startNum[1]; b <= finalNum[1]; b++)
                {
                    for (int c = startNum[2]; c <= finalNum[2]; c++)
                    {
                        for (int d = startNum[3]; d <= finalNum[3]; d++)
                        {
                            if ((char)a % 2 == 1 && (char)b % 2 == 1
                            && (char)c % 2 == 1 && (char)d % 2 == 1)
                            {
                                Console.Write($"{(char)a}{(char)b}{(char)c}{(char)d} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
