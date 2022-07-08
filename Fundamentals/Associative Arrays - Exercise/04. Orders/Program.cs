using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace AssociativeArraysExercise
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = new List<string>();
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            while (true)
            {
                inputList = Console.ReadLine().Split(' ').ToList();

                if (inputList[0] == "buy")
                {
                    break;
                }

                string productName = inputList[0];
                double price = double.Parse(inputList[1]);
                int quantity = int.Parse(inputList[2]);

                Product newProduct = new Product(productName, price, quantity);

                if (products.ContainsKey(productName))
                {
                    products[productName].Price = price;
                    products[productName].Quantity += quantity;
                }
                else
                {
                    products.Add(productName, newProduct);
                }

            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value.Price * product.Value.Quantity):f2}");
            }

        }
    }
}