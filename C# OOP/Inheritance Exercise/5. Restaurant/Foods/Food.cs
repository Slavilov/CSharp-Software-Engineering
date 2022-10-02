﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Food : Product
    {
        public Food(string name, decimal price, double grams) : base (name, price)
        {
            this.grams = grams;
        }

        private double grams;

        public double Grams
        {
            get { return grams; }
            set { grams = value; }
        }

    }
}
