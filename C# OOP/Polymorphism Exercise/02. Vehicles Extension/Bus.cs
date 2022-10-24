using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double litersPerKm, double tankCapacity) : base(fuelQuantity, litersPerKm, tankCapacity)
        {
            if (fuelQuantity > tankCapacity)
            {
                this.FuelQuantity = 0;
            }
        }

        public override void Drive(double km)
        {
            if (this.FuelQuantity >= km * (this.FuelCnsmPerKm + 1.4))
            {
                this.FuelQuantity -= km * (this.FuelCnsmPerKm + 1.4);
                Console.WriteLine($"Bus travelled {km} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public void DriveEmpty(double km)
        {
            if (this.FuelQuantity >= km * this.FuelCnsmPerKm)
            {
                this.FuelQuantity -= km * this.FuelCnsmPerKm;
                Console.WriteLine($"Bus travelled {km} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
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
                    this.FuelQuantity += fuel;
                }
            }
        }
    }
}
