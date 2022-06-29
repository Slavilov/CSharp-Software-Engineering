using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace SongsExerciseForObjectsAndClasses
{
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public int SerialNumber { get; set; }
        public string Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForBox { get; set; }
        public double BoxItemPrice { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> listOfBoxes = new List<Box>();
            List<string> inputCommand = new List<string>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                inputCommand = input.Split(' ').ToList();

                Item newItem = new Item();
                {
                    newItem.Name = inputCommand[1];
                    newItem.Price = double.Parse(inputCommand[3]);
                }

                int itemQuantityTemp = int.Parse(inputCommand[2]);

                Box newBox = new Box();
                {
                    newBox.SerialNumber = int.Parse(inputCommand[0]);
                    newBox.Item = inputCommand[1];
                    newBox.ItemQuantity = int.Parse(inputCommand[2]);
                    newBox.PriceForBox = (itemQuantityTemp * newItem.Price);
                    newBox.BoxItemPrice = double.Parse(inputCommand[3]);
                }

                listOfBoxes.Add(newBox);
                input = Console.ReadLine();
            }
            List<Box> sortedBoxes = listOfBoxes.OrderBy(x => x.PriceForBox).ToList();
            sortedBoxes.Reverse();

            foreach (Box box in sortedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item} - ${box.BoxItemPrice:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }
    }
}