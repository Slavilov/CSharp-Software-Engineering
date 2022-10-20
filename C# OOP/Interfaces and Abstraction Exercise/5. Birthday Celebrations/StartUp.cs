using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BorderControl
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Robot> listOfRobots = new List<Robot>();
            List<IBirthdate> listOfPetsAndCitizens = new List<IBirthdate>();

            while (true)
            {
                List<string> inputCmd = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (inputCmd[0] == "End")
                {
                    break;
                }

                if (inputCmd[0] == "Citizen")
                {
                    string name = inputCmd[1];
                    int age = int.Parse(inputCmd[2]);
                    string id = inputCmd[3];
                    string birthdate = inputCmd[4];

                    Citizens newCitizen = new Citizens(name, age, id, birthdate);
                    listOfPetsAndCitizens.Add(newCitizen);
                }
                else if (inputCmd[0] == "Pet")
                {
                    string name = inputCmd[1];
                    string birthdate = inputCmd[2];

                    Pet newPet = new Pet(name, birthdate);
                    listOfPetsAndCitizens.Add(newPet);
                }
                else
                {
                    string model = inputCmd[1];
                    string id = inputCmd[2];

                    Robot newRobot = new Robot(model, id);
                    listOfRobots.Add(newRobot);
                }

            }

            string specificYear = Console.ReadLine();

            string[] allBirthDates = listOfPetsAndCitizens.Where(x => x.Birthdate.EndsWith(specificYear)).Select(x => x.Birthdate).ToArray();

            if (allBirthDates.Length > 0) 
            {
                foreach (var years in allBirthDates)
                {
                    Console.WriteLine(years);
                }
            }
            else
            {
                Console.WriteLine("<empty output>");
            }
        }
    }
}