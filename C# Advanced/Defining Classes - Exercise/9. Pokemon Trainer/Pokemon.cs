using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Pokemon
    {
        public Pokemon(string name, string element,double health)
        {
            this.name = name;
            this.Element = element;
            this.health = health;
        }

        private string name;
        private string element;
        private double health;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Element
        {
            get { return element; }
            set { element = value; }
        }

        public double Health
        {
            get { return health; }
            set { health = value; }
        }
    }
}
