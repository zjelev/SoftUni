namespace Vehicles.Factories
{
    using Vehicles.Model;
    public interface IVehiclefactory
    {
        IVehicle CreateVehicle(string type, double fuelQty, double consumption, bool hasAirConditioner = true);
    }
}
