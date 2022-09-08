﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Tire
    {
        public Tire(double pressure, int age)
        {
            this.pressure = pressure;
            this.age = age;
        }

        private double pressure;
        private int age;
        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
