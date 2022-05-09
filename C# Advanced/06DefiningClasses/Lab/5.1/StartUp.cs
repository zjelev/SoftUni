using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input;
            List<CarTires> tires = new List<CarTires>();

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] token = input.Split();

                CarTires carTires = new CarTires();

                for (int i = 0; i < token.Length; i++)
                {   
                    Tire tire = new Tire(int.Parse(token[i]), double.Parse(token[i+1]));
                    carTires.AddTire(tire);
                    i++;
                }

                tires.Add(carTires);
            }

            List<Engine> engines = new List<Engine>();

            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] token = input.Split();

                Engine engine = new Engine(int.Parse(token[0]), double.Parse(token[1]));
                
                engines.Add(engine);
            }

            List<Car> cars = new List<Car>();

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] token = input.Split();

                Car car = new Car(token[0], token[1], int.Parse(token[2]), double.Parse(token[3]), 
                    double.Parse(token[4]), engines[int.Parse(token[5])], tires[int.Parse(token[6])]);

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                double tiresPressureSum = 0;
                foreach (var tire in car.CarTires.Tires)
                {
                    tiresPressureSum += tire.Pressure;
                }
                                
                if (car.Year >= 2017 && car.Engine.HorsePower >= 330 && tiresPressureSum >= 9 && tiresPressureSum <= 10)
                {
                    car.Drive(20);
                    
                    Console.WriteLine($"Make: {car.Make}");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Year: {car.Year}");
                    Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                    Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
                }

            }
        }
    }
}
