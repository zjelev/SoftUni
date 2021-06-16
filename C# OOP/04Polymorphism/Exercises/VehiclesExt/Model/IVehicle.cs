namespace Vehicles.Model
{
    public interface IVehicle
    {
        double FuelQty { get; }
        double Consumption { get; }

        bool HasAirConditioner { get; }

        double AirCondConsumtion { get; }

        double TankCapacity { get; }
        
        string Drive(double km);
        void Refuel(double liters);

        void StartAC();

        void StopAC();
    }
}