using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[int.Parse(Console.ReadLine())];

            for (int i = 0; i < cars.Length; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double FuelConsumptionPerKilometer = double.Parse(input[2]);
                Car car = new Car(model, fuelAmount, FuelConsumptionPerKilometer);
                cars[i] = car;

            }

            string drive;

            while ((drive = Console.ReadLine()) != "End")
            {
                string carModel = drive.Split()[1];
                int currentCarIndex = Array.FindIndex(cars, row => row.Model == carModel);
                cars[currentCarIndex].Drive(double.Parse(drive.Split()[2]));
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
