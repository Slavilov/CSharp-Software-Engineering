using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
            if (base.Age > 15)
            {
                throw new Exception("Children should not be able to have an age greather than 15");
            }
            else
            {
                this.Age = base.Age;
            }
        }
    }
}