using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pizza
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] cmdOfPizza = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                string nameOfPizza = cmdOfPizza[1];
                Pizza newPizza = new Pizza(nameOfPizza);



                List<string> cmdsDough = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string flourType = cmdsDough[1];
                string bakingTechnique = cmdsDough[2];
                double weight = double.Parse(cmdsDough[3]);

                Dough newDough = new Dough(flourType, bakingTechnique, weight);
                //Console.WriteLine($"{newDough.caloriesDough():f2}");

                newPizza.Dough = newDough;


                while (true)
                {
                    List<string> cmdsToppings = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                    if (cmdsToppings[0] == "END")
                    {
                        break;
                    }

                    string typeOfTopping = cmdsToppings[1];
                    double weightOfTopping = double.Parse(cmdsToppings[2]);

                    Toppings newTopping = new Toppings(typeOfTopping, weightOfTopping);
                    //Console.WriteLine($"{newTopping.caloriesToppings():f2}");

                    newPizza.AddTopping(newTopping);
                }

                Console.WriteLine($"{newPizza.Name} - {newPizza.Calories:f2} Calories.");
            }
            catch (Exception exc)
            {

                Console.WriteLine(exc.Message);
            }
        }
    }
}