using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Cake : Dessert
    {
        public Cake(string name, decimal price) : base(name, 5, 250, 1000)
        {

        }
    }
}
