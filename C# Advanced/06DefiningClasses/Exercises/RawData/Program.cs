using System;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n];
           
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);
                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);
                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);
                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire tire1 = new Tire(tire1Age, tire1Pressure);
                Tire tire2 = new Tire(tire2Age, tire2Pressure);
                Tire tire3 = new Tire(tire3Age, tire3Pressure);
                Tire tire4 = new Tire(tire4Age, tire4Pressure);
                Tire[] tires = new Tire[] {tire1, tire2, tire3, tire4 };
                Car car = new Car(model, engine, cargo, tires);
                cars[i] = car;
            }
          
            string printCondition = Console.ReadLine();
            if (printCondition == "fragile")
            {
                foreach (var car in cars)
                {
                    foreach (var tire in car.Tires)
                    {
                        if (tire.Pressure < 1)
                        {
                            Console.WriteLine(car.Model);
                            break;
                        }
                    }
                }
            }
            else if (printCondition == "flamable")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == "flamable" && car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
