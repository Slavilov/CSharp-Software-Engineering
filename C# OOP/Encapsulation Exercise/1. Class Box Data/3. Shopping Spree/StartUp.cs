using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Shopping
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<string> cmdPerson = Console.ReadLine()
                .Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> cmdProduct = Console.ReadLine()
                .Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, Person> personMoney = new Dictionary<string, Person>();
            Dictionary<string, Product> product = new Dictionary<string, Product>();

            try
            {
                for (int i = 0; i < cmdPerson.Count; i += 2)
                {
                    string nameOfPerson = cmdPerson[i];
                    decimal moneyOfPerson = decimal.Parse(cmdPerson[i + 1]);
                    Person newPerson = new Person(nameOfPerson, moneyOfPerson);
                    personMoney.Add(nameOfPerson, newPerson);
                }

                for (int i = 0; i < cmdProduct.Count; i += 2)
                {
                    string nameOfProduct = cmdProduct[i];
                    decimal priceOfProduct = decimal.Parse(cmdProduct[i + 1]);
                    Product newProduct = new Product(nameOfProduct, priceOfProduct);
                    product.Add(nameOfProduct, newProduct);
                }

                while (true)
                {
                    string command = Console.ReadLine();

                    if (command == "END")
                    {
                        break;
                    }

                    string[] purchaseCommand = command
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string personBuying = purchaseCommand[0];
                    string productBuying = purchaseCommand[1];

                    if (personMoney[personBuying].Money >= product[productBuying].Cost)
                    {
                        if (personMoney[personBuying].AddProduct(product[productBuying]) == false)
                        {
                            //Console.WriteLine($"{personBuying} can't afford {productBuying}");
                        }
                        else
                        {
                            Console.WriteLine($"{personBuying} bought {productBuying}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{personBuying} can't afford {productBuying}");
                    }
                }

                foreach (var person in personMoney)
                {
                    if (person.Value.Products.Count > 0)
                    {
                        Console.WriteLine($"{person.Key} - {string.Join(", ", person.Value.Products.Select(x => x.Name))}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Key} - Nothing bought");
                    }
                }
            }
            catch (Exception exc)
            {

                Console.WriteLine(exc.Message);
                return;
            }
        }
    }
}