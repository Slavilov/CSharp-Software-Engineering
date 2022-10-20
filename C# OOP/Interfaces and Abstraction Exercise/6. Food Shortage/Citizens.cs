using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Citizens : IAge, IBirthdate, IBuyer
    {
        public Citizens(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
        public int Food { get ;  set ; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
