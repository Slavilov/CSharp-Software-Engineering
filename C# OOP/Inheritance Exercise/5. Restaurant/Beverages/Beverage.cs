﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Beverage : Product
    {
        public Beverage(string name, decimal price, double milliliters) : base (name, price)
        {
            this.milliliters = milliliters;
        }
        private double milliliters;

        public double Milliliters
        {
            get { return milliliters; }
            set { milliliters = value; }
        }

    }
}
