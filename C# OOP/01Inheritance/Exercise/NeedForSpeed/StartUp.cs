using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            RaceMotorcycle raceMotorcycle = new RaceMotorcycle(100, 10);
            raceMotorcycle.Drive(1);
            Console.WriteLine(raceMotorcycle.FuelConsumption);
            Console.WriteLine(raceMotorcycle.Fuel);

            FamilyCar familyCar = new FamilyCar(100, 10);
            familyCar.Drive(1);
            Console.WriteLine(familyCar.FuelConsumption);
            Console.WriteLine(familyCar.Fuel);
        }
    }
}
