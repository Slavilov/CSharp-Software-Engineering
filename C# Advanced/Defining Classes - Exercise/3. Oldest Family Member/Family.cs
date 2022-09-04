using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Family
    {
        private List<Person> familyMembers = new List<Person>();

        public List<Person> FamilyMembers
        {
            get { return familyMembers; }
            set { familyMembers = value; }
        }

        public void AddMembers(Person member)
        {
            this.familyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestPerson = new Person();
            foreach (Person member in this.FamilyMembers)
            {
                if (member.Age > oldestPerson.Age)
                {
                    oldestPerson = member;
                }
            }

            return oldestPerson;
        }

    }
}
