using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double litersPerKm, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelCnsmPerKm = litersPerKm;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; private protected set; }

        public double FuelCnsmPerKm { get; private protected set; }

        public double TankCapacity { get; private protected set; }

        public virtual void Drive(double km)
        {
        }

        public virtual void Refuel(double fuel)
        {
        }
    }
}