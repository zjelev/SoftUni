namespace Vehicles.Model
{    public class Car : Vehicle
    {
        
        private const double DefaultACConsumption = 0.9;
        public Car(double fuelQty, double consumption, bool hasAirConditioner = true) 
            : base(fuelQty, consumption, hasAirConditioner)
        {
        }

        public override double AirCondConsumtion => DefaultACConsumption;


    }
}
