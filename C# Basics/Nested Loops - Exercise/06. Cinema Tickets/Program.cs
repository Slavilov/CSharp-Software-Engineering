using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double percentageStudent = 0;
            double percentageStandard = 0;
            double percentageKids = 0;
            double percentageFull = 0;
            string movieName = string.Empty;
            string typeOfTicket = string.Empty;
            int freeSpaces = 0;
            double constantFreeSpaces = 0;

            double counterStud = 0;
            double counterStan = 0;
            double counterKid = 0;
            double counterAll = 0;
            double sumOfUsedTickets = 0;

            while (movieName != "Finish")
            {
                movieName = Console.ReadLine();

                if (movieName == "Finish")
                {
                    break;
                }
                freeSpaces = int.Parse(Console.ReadLine());
                constantFreeSpaces = freeSpaces;
                counterAll = 0;

                while (freeSpaces > 0 && typeOfTicket != "End")
                {
                    typeOfTicket = Console.ReadLine();

                    switch (typeOfTicket)
                    {
                        case "student":
                            counterStud++;
                            freeSpaces -= 1;
                            counterAll += 1;
                            sumOfUsedTickets += 1;
                            break;

                        case "standard":
                            counterStan++;
                            freeSpaces -= 1;
                            counterAll += 1;
                            sumOfUsedTickets += 1;
                            break;

                        case "kid":
                            counterKid++;
                            freeSpaces -= 1;
                            counterAll += 1;
                            sumOfUsedTickets += 1;
                            break;
                    }

                }
                typeOfTicket = String.Empty;
                if (freeSpaces <= 0)
                {
                    Console.WriteLine($"{movieName} - 100.00% full.");
                }
                else
                {
                    Console.WriteLine($"{movieName} - {((counterAll / constantFreeSpaces) * 100):f2}% full.");
                }

            }
            Console.WriteLine($"Total tickets: {counterStud + counterStan + counterKid}");
            Console.WriteLine($"{((counterStud / sumOfUsedTickets) * 100):f2}% student tickets.");
            Console.WriteLine($"{(counterStan / sumOfUsedTickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(counterKid / sumOfUsedTickets) * 100:f2}% kids tickets.");

        }
    }
}
