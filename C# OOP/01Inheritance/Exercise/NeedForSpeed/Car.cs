using System;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private const double DefaultConsumption = 3;

        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => DefaultConsumption;

    }
}