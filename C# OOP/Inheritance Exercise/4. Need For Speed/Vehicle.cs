using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public const double defaultFuelConsumption = 1.25;
        private double fuelConsumption;
        private double fuel;
        private int horsePower;


        public virtual double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public int HorsePower
        {
            get { return horsePower; }
            private set { horsePower = value; }
        }

        public virtual void Drive(double kilometers)
        {
            if (fuelConsumption > 0)
            {
                Fuel = Fuel - (kilometers / 100) * FuelConsumption;
            }
            else
            {
                Fuel = Fuel - (kilometers / 100) * defaultFuelConsumption;
            }
        }

    }
}
