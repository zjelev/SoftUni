using System;

namespace Vehicles.Model
{
    public class Bus : Vehicle
    {
        private const double DefaultACConsumption = 1.4;
        public Bus(double fuelQty, double consumption, double tankCapacity, bool hasAirConditioner = true) 
            : base(fuelQty, consumption, tankCapacity, hasAirConditioner)
        {
        }

        public override double AirCondConsumtion => DefaultACConsumption;
    }
}
