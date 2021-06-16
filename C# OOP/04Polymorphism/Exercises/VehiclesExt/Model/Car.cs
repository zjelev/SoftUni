namespace Vehicles.Model
{    public class Car : Vehicle
    {
        
        private const double DefaultACConsumption = 0.9;

        public Car(double fuelQty, double consumption, double tankCapacity, bool hasAirConditioner = true) 
            : base(fuelQty, consumption, tankCapacity, hasAirConditioner)
        {
        }

        public override double AirCondConsumtion => DefaultACConsumption;


    }
}
