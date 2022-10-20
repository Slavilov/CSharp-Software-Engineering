using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Pet : IBirthdate
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Birthdate { get; set; }
    }
}
