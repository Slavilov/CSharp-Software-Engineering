using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SimpelCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFoodForTheDay = int.Parse(Console.ReadLine());
            List<int> listOfOrders = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Queue<int> queOfOrders = new Queue<int>();

            for (int i = 0; i < listOfOrders.Count; i++)
            {
                queOfOrders.Enqueue(listOfOrders[i]);
            }
            Console.WriteLine(queOfOrders.Max());

            while (queOfOrders.Peek() <= quantityOfFoodForTheDay && quantityOfFoodForTheDay > 0)
            {
                int temporaryNum = queOfOrders.Dequeue();
                quantityOfFoodForTheDay -= temporaryNum;

                if (queOfOrders.Count == 0)
                {
                    break;
                }
            }

            if (queOfOrders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                while (queOfOrders.Count > 0)
                {
                    //int temporaryNum = queOfOrders.Dequeue();
                    Console.Write($"{queOfOrders.Dequeue()} ");
                }
            }
        }
    }
}