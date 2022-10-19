using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Telephony
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<string> phoneNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> websites = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            StationaryPhone newStationaryPhone = new StationaryPhone();
            SmartPhone newSmartPhone = new SmartPhone();


            foreach (var number in phoneNumbers)
            {
                int newNumber = 0;
                bool successfullyParse = int.TryParse(number, out newNumber);

                if (successfullyParse == false)
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                } 
                
                if (number.Length == 10)
                {
                    newSmartPhone.Calling(int.Parse(number));
                }
                else if (number.Length ==  7)
                {
                    newStationaryPhone.Calling(int.Parse(number));
                }
            }

            foreach (var website in websites)
            {
                if (website.Any(char.IsDigit) == true)
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }
                else
                {
                    newSmartPhone.Browsing(website);
                }

            }
        }
    }
}