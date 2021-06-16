namespace Vehicles.Model
{
    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(double fuelQty, double consumption, bool hasAirConditioner = true)
        {
            this.FuelQty = fuelQty;
            this.Consumption = consumption;
            this.HasAirConditioner = hasAirConditioner;
        }
        public double FuelQty { get; protected set; }

        public double Consumption { get; private set; }

        public bool HasAirConditioner { get; }

        public abstract double AirCondConsumtion { get; }

        public string Drive(double distance)
        {
            double fuelNeeded = distance * Consumption;

            if (this.HasAirConditioner)
            {
                fuelNeeded += distance * AirCondConsumtion;
            }

            if (FuelQty > fuelNeeded)
            {
                FuelQty -= fuelNeeded;
                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }

        public virtual void Refuel(double liters)
        {
            this.FuelQty += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQty:f2}";
        }
    }
}