using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Engine
    {
        public Engine(double speed, double power)
        {
            this.speed = speed;
            this.Power = power;
        }

        private double speed;
        private double power;

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public double Power
        {
            get { return power; }
            set { power = value; }
        }
    }
}
