using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public SportCar(int horsepower, double fuel) : base(horsepower, fuel)
        {

        }

        private new const double defaultFuelConsumption = 10;

        private double fuelConsumption;

        public override double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }


        public override void Drive(double kilometers)
        {
            if (this.fuelConsumption > 0)
            {
                Fuel = Fuel - (kilometers / 100) * this.FuelConsumption;
            }
            else
            {
                Fuel = Fuel - (kilometers / 100) * defaultFuelConsumption;
            }
        }
    }
}
