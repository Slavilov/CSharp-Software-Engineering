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
            List<INameAndId> listOfRobotsandCitizens = new List<INameAndId>();

            while (true)
            {
                List<string> inputCmd = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (inputCmd[0] == "End")
                {
                    break;
                }

                if (inputCmd.Count == 3)
                {
                    string name = inputCmd[0];
                    int age = int.Parse(inputCmd[1]);
                    string id = inputCmd[2];

                    Citizens newCitizen = new Citizens(name, age, id);
                    listOfRobotsandCitizens.Add(newCitizen);
                }
                else
                {
                    string model = inputCmd[0];
                    string id = inputCmd[1];

                    Robot newRobot = new Robot(model, id);
                    listOfRobotsandCitizens.Add(newRobot);
                }

            }

            string fakeIds = Console.ReadLine();

            string[] fakeIDs = listOfRobotsandCitizens.Where(x => x.Id.EndsWith(fakeIds)).Select(x => x.Id).ToArray();

            foreach (var fakeId in fakeIDs)
            {
                Console.WriteLine(fakeId);
            }
        }
    }
}