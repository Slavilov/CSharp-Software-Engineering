using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace WildFarm
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            //List<Food> foods = new List<Food>();
            //string typeOfAnimalSafer = string.Empty;

            int line = 0;
            int animalNum = 0;

            while (true)
            {
                if (line % 2 != 0)
                {
                    List<string> infoAboutFood = Console.ReadLine()
                        .Split(' ')
                        .ToList();

                    string foodType = infoAboutFood[0];
                    int quantity = int.Parse(infoAboutFood[1]);

                    Food newFood = FoodPattern.getFood(foodType, quantity);
                    //foods.Add(newFood);

                    animals[animalNum - 1].FeedAnimal(foodType, quantity);

                    line++;
                    continue;
                }

                List<string> cmds = Console.ReadLine()
                    .Split(' ')
                    .ToList();

                if (cmds[0] == "End")
                {
                    break;
                }

                //typeOfAnimalSafer = cmds[0];

                if (cmds.Count == 5)
                {
                    if (cmds[0] == "Cat")
                    {
                        Cat newCat = new Cat(cmds[1], double.Parse(cmds[2]), cmds[3], cmds[4]);
                        newCat.AskForFood();

                        animals.Add(newCat);
                    }
                    else if (cmds[0] == "Tiger")
                    {
                        Tiger newTiger = new Tiger(cmds[1], double.Parse(cmds[2]), cmds[3], cmds[4]);
                        newTiger.AskForFood();

                        animals.Add(newTiger);
                    }
                }
                else if (cmds.Count == 4)
                {
                    if (cmds[0] == "Hen")
                    {
                        Hen newHen = new Hen(cmds[1], double.Parse(cmds[2]), double.Parse(cmds[3]));
                        newHen.AskForFood();

                        animals.Add(newHen);
                    }
                    else if (cmds[0] == "Owl")
                    {
                        Owl newOwl = new Owl(cmds[1], double.Parse(cmds[2]), double.Parse(cmds[3]));
                        newOwl.AskForFood();

                        animals.Add(newOwl);
                    }
                    else if (cmds[0] == "Dog")
                    {
                        Dog newDog = new Dog(cmds[1], double.Parse(cmds[2]), cmds[3]);
                        newDog.AskForFood();

                        animals.Add(newDog);
                    }
                    else if (cmds[0] == "Mouse")
                    {
                        Mouse newMouse = new Mouse(cmds[1], double.Parse(cmds[2]), cmds[3]);
                        newMouse.AskForFood();

                        animals.Add(newMouse);
                    }
                }
                animalNum++;
                line++;
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}