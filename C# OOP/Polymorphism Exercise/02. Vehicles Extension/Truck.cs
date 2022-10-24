using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double litersPerKm, double tankCapacity) : base(fuelQuantity, litersPerKm, tankCapacity)
        {
            this.FuelCnsmPerKm = litersPerKm + 1.6;

            if (fuelQuantity > tankCapacity)
            {
                this.FuelQuantity = 0;
            }
        }

        public override void Drive(double km)
        {
            if (this.FuelQuantity >= km * this.FuelCnsmPerKm)
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
            if (fuel <= 0)
            {
                Console.WriteLine($"Fuel must be a positive number");
            }
            else
            {
                if (this.FuelQuantity + fuel > this.TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                }
                else
                {
                    this.FuelQuantity += (fuel * 0.95);
                }
            }
        }
    }
}
