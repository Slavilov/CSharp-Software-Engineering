using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Citizens : IAge, IBirthdate
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
        public string Birthdate { get ; set ; }
    }
}
