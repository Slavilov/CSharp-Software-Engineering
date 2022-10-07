using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Product
    {
        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        private string name;
        private decimal cost;

        public string Name
        {
            get { return name; }

           private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be an empty string!");
                }
                else
                {
                    name = value;
                }
            }
        }

        public decimal Cost
        {
            get { return cost; }

           private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be a negative number!");
                }
                else
                {
                    cost = value;
                }
            }
        }
    }
}
