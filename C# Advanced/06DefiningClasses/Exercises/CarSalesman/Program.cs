using System;
using System.Linq;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Engine[] engines = new Engine[n];

            for (int i = 0; i < n; i++)
            {
                string[] enginesData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = enginesData[0];
                int power = int.Parse(enginesData[1]);
                Engine engine = new Engine(model, power);

                if (enginesData.Length == 3)
                {
                    int displacement;
                    if (int.TryParse(enginesData[2], out displacement))
                    {
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        engine.Efficiency = enginesData[2];
                    }
                }
                else if (enginesData.Length == 4)
                {
                    int displacement;
                    if (int.TryParse(enginesData[2], out displacement))
                    {
                        engine.Displacement = int.Parse(enginesData[2]);
                        engine.Efficiency = enginesData[3];
                    }
                    else
                    {
                        engine.Efficiency = enginesData[2];
                        engine.Displacement = int.Parse(enginesData[3]);
                    }
                }
                engines[i] = engine;
            }

            int m = int.Parse(Console.ReadLine());
            Car[] cars = new Car[m];

            for (int i = 0; i < m; i++)
            {
                string[] carsData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carsData[0];
                Engine engine = engines.Where(e => e.Model == carsData[1]).First();
                //Engine engine = Array.Find(engines, x => x.Model == carsData[1]);
                Car car = new Car(model, engine);

                if (carsData.Length == 3)
                {
                    int weight;
                    if (int.TryParse(carsData[2], out weight))
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        car.Color = carsData[2];
                    }
                }
                else if (carsData.Length == 4)
                {
                    int weight;
                    if (int.TryParse(carsData[2], out weight))
                    {
                        car.Weight = int.Parse(carsData[2]);
                        car.Color = carsData[3];
                    }
                    else
                    {
                        car.Weight = int.Parse(carsData[3]);
                        car.Color = carsData[2];
                    }
                }
                cars[i] = car;
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}