using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Cargo
    {
        public Cargo(string type, double weight)
        {
            this.type = type;
            this.Weight = weight;
        }

        private string type;
        private double weight;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}