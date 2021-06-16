using System;

namespace Vehicles.Model
{
    public class Truck : Vehicle
    {
        private const double DefaultACConsumption = 1.6;
        private const double RefuelPercent = 0.95;

        public Truck(double fuelQty, double consumption, double tankCapacity, bool hasAirConditioner) 
            : base(fuelQty, consumption, tankCapacity, hasAirConditioner = true)
        {
        }

        public override double AirCondConsumtion => DefaultACConsumption;

        public override void Refuel(double liters)
        {
            //this.FuelQty += liters * RefuelPercent;
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            
            if (this.FuelQty + liters > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            
            base.Refuel(liters * RefuelPercent);
        }
    }
}