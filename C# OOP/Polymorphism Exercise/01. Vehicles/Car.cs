using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle, IVehicle
    {
        public Car(double fuelQuantity, double litersPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelCnsmPerKm = litersPerKm + 0.9;
        }

        public double FuelQuantity { get ; set ; }
        public double FuelCnsmPerKm { get ; set ; }

        public override void Drive(double km)
        {
            if (this.FuelQuantity >= km * this.FuelCnsmPerKm)
            {
                this.FuelQuantity -= km * this.FuelCnsmPerKm;
                Console.WriteLine($"Car travelled {km} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public override void Refuel(double fuel)
        {
            this.FuelQuantity += fuel;
        }
    }
}
