using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Rebel : IBuyer, INameAndId
    {
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Id = group;
        }

        public string Name { get; set ; }
        public int Age { get ; set ; }
        public int Food { get ; set ; }
        public string Id { get ; set ; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
