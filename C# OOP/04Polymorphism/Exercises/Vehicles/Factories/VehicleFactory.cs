using Vehicles.Model;

namespace Vehicles.Factories
{
    public class VehicleFactory : IVehiclefactory
    {
        public IVehicle CreateVehicle(string type, double fuelQty, double consumption, bool hasAirConditioner)
        {
            IVehicle vehicle = null;

            if (type == nameof(Car))
            {
                vehicle = new Car(fuelQty, consumption, hasAirConditioner);
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(fuelQty, consumption, hasAirConditioner);
            }

            return vehicle;
        }
    }
}
