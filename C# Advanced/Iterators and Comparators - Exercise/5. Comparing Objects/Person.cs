using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Comparing_Objects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

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

        public string Town
        {
            get { return town; }
            set { town = value; }
        }

        public int CompareTo(Person other)
        {
            if (this.Name == other.Name)
            {
                if (this.Age == other.Age)
                {
                    if (this.Town == other.Town)
                    {
                        return 0;
                    }
                    return -1;
                }
                return -1;
            }
            return -1;
        }
    }
}
