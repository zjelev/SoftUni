using Vehicles.Model;

namespace Vehicles.Factories
{
    public class VehicleFactory : IVehiclefactory
    {
        public IVehicle CreateVehicle(string type, double fuelQty, double consumption, double tankCapacity, bool hasAirConditioner)
        {
            IVehicle vehicle = null;

            if (type == nameof(Car))
            {
                vehicle = new Car(fuelQty, consumption, tankCapacity, hasAirConditioner);
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(fuelQty, consumption, tankCapacity, hasAirConditioner);
            }
            else if (type == nameof(Bus))
            {
                vehicle = new Bus(fuelQty, consumption, tankCapacity, hasAirConditioner);
            }

            return vehicle;
        }
    }
}
