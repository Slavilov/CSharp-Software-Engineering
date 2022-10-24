using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle, IVehicle
    {
        public Truck(double fuelQuantity, double fuelCnsmPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelCnsmPerKm = fuelCnsmPerKm + 1.6;
        }

        public double FuelQuantity { get; set; }
        public double FuelCnsmPerKm { get; set; }

        public override void Drive(double km)
        {
            if (this.FuelQuantity >= km*this.FuelCnsmPerKm)
            {
                this.FuelQuantity -= km * this.FuelCnsmPerKm;
                Console.WriteLine($"Truck travelled {km} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double fuel)
        {
            this.FuelQuantity += (fuel * 0.95);
        }
    }
}
