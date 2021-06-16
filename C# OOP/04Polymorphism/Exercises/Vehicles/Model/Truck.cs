namespace Vehicles.Model
{
    public class Truck : Vehicle
    {
        private const double DefaultACConsumption = 1.6;
        private const double RefuelPercent = 0.95;
        public Truck(double fuelQty, double consumption, bool hasAirConditioner = true) 
            : base(fuelQty, consumption, hasAirConditioner)
        {
        }

        public override double AirCondConsumtion => DefaultACConsumption;

        public override void Refuel(double liters)
        {
            //this.FuelQty += liters * RefuelPercent;
            base.Refuel(liters * RefuelPercent);
        }
    }
}