using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }


        private int age;
        private string name;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("A person cannot have negative age!");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}