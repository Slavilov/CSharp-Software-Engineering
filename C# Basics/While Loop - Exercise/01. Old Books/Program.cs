using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            string bookSearch = "";
            int counter = 0;

            while (bookSearch != favoriteBook && bookSearch != "No More Books")
            {
                bookSearch = Console.ReadLine();
                if (bookSearch == "No More Books")
                {
                    break;
                }
                if (bookSearch == favoriteBook)
                {
                    break;
                }
                counter++;
            }
            if (bookSearch == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
            else
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
        }
    }
}
