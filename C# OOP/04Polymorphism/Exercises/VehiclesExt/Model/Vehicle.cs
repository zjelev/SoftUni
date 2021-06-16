using System;

namespace Vehicles.Model
{
    public abstract class Vehicle : IVehicle
    {
        private const double DefaultFuelQty = 0;
        private double fuelQty;
        
        protected Vehicle(double fuelQty, double consumption, double tankCapacity, bool hasAirConditioner = true)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQty = fuelQty;
            this.Consumption = consumption;
            this.HasAirConditioner = hasAirConditioner;

        }
        public double FuelQty 
        { 
            get => this.fuelQty;
            
            protected set
            {
                if (value <= this.TankCapacity)
                {
                    this.fuelQty = value;
                }
                else
                {
                    this.fuelQty = DefaultFuelQty;
                }
            } 
        }

        public double Consumption { get; private set; }

        public double TankCapacity { get; }

        public bool HasAirConditioner { get; private set; }

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
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            
            if (this.FuelQty + liters > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            
            this.FuelQty += liters;
        }

        public void StartAC()
        {
            this.HasAirConditioner = true;
        }

        public void StopAC()
        {
            this.HasAirConditioner = false;

        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQty:f2}";
        }
    }
}