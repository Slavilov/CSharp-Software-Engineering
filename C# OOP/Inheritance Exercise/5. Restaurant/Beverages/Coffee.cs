using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Coffee : HotBeverage
    {
        public Coffee(string name, double caffeine) : base(name, 3.50m, 50)
        {
            this.caffeine = caffeine;
        }

        private double caffeine;

        public double Caffeine
        {
            get { return caffeine; }
            set { caffeine = value; }
        }


    }
}
