﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Team
    {
        public Team(string name)
        {
            this.Name = name;
        }

        private string name;
        private List<Person> firstTeam = new List<Person>();
        private List<Person> reserveTeam = new List<Person>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return this.firstTeam.AsReadOnly(); }

        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return this.reserveTeam.AsReadOnly(); }

        }

        public void AddPlayer (Person person)
        {
            if (person.Age < 40)
            {
                this.firstTeam.Add(person);
            }
            else
            {
                this.reserveTeam.Add(person);
            }
        }

    }
}
