using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace PasswordCheckUp
{
    class Program
    {
        static void Main(string[] args)
        {
            string arraySeparated = Console.ReadLine();
            List<int> numbers = new List<int>();
            int positionCounter = 0;
            int lastIndex = arraySeparated.Length - 1;

            for (int i = arraySeparated.Length - 1; i >= 0; i--)
            {
                if (arraySeparated[i] == '|' || i == 0)
                {
                    positionCounter = i;

                    for (int j = positionCounter; j < lastIndex + (arraySeparated.Length - lastIndex); j++)
                    {

                        switch (arraySeparated[j])
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
                                numbers.Add(int.Parse(arraySeparated[j].ToString()));
                                break;
                        }

                        if (j == arraySeparated.Length - 1 || arraySeparated[j + 1] == '|')
                        {
                            break;
                        }
                        lastIndex = i;
                    }
                }
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}