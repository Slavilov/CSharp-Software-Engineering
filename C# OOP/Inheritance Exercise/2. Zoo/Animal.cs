﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


    }
}
