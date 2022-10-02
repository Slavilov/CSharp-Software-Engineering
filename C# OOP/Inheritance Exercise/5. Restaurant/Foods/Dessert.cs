﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Dessert : Food
    {
        public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
        {
            this.calories = calories;
        }

        private double calories;

        public double Calories
        {
            get { return calories; }
            set { calories = value; }
        }

    }
}
