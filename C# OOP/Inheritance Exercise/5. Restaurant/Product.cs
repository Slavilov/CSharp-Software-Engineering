using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Product
    {
        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
        
        private decimal price;
        private string name;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }



    }
}
