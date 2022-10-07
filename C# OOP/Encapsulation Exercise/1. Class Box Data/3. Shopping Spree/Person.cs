using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Person
    {
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        private string name;
        private decimal money;
        private readonly List<Product> products;



        public List<Product> Products
        {
            get { return products; }
        }

        public string Name
        {
            get { return name; }

            private set 
            { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                else
                {
                    name = value;
                }
            }
        }

        public decimal Money
        {
            get { return money; }

            private set 
            { 
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be a negative");
                }
                else
                {
                    money = value; 
                }
            }
        }

        public bool AddProduct(Product product)
        {
            if (product.Cost > Money)
            {
                return false;
            }
            else
            {
                this.products.Add(product);
                this.Money -= product.Cost;
                return true;
            }
        }

        public override string ToString()
        {
            return $"{string.Join(", ", products)}";
        }
    }
}
