using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Person
    {
        public Person()
        {
            this.name = String.Empty;
            this.Age = 0;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


    }
}
