namespace Vehicles.Core
{
    using Vehicles.IO;
    using Vehicles.Factories;
    using Vehicles.Model;
    using System;

    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private readonly IVehiclefactory vehiclefactory;

        public Engine(IReader reader, IWriter writer, IVehiclefactory vehiclefactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.vehiclefactory = vehiclefactory;
        }

        public void Run()
        {
            string[] vehicleData = this.reader.CustomReadLine().Split();
            IVehicle car = CreateVehicle(vehicleData);

            vehicleData = this.reader.CustomReadLine().Split();
            IVehicle truck = CreateVehicle(vehicleData);

            int n = int.Parse(this.reader.CustomReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] args = this.reader.CustomReadLine().Split();
                string command = args[0];
                string vehicleType = args[1];
                double arg = double.Parse(args[2]);
                
                if (command == "Drive")
                {
                    this.DriveCommand(vehicleType, car, truck, arg);
                }
                else if (command == "Refuel")
                {
                    this.RefuelCommand(vehicleType, car, truck, arg);
                }
            }
            
            this.writer.CustomWriteLine(car.ToString());
            this.writer.CustomWriteLine(truck.ToString());
        }

        private void RefuelCommand(string vehicleType, IVehicle car, IVehicle truck, double arg)
        {
            if (vehicleType == nameof(Car))
            {
                car.Refuel(arg);
            }
            else if (vehicleType == nameof(Truck))
            {
                truck.Refuel(arg);
            }
        }

        private void DriveCommand(string vehicleType, IVehicle car, IVehicle truck, double arg)
        {
            if (vehicleType == nameof(Car))
            {
                this.writer.CustomWriteLine(car.Drive(arg));
            }
            else if (vehicleType == nameof(Truck))
            {
                this.writer.CustomWriteLine(truck.Drive(arg));
            }
        }

        private IVehicle CreateVehicle(string[] data)
        {
            string type = data[0];
            double fuelQty = double.Parse(data[1]);
            double fuelConsumption = double.Parse(data[2]);

            return this.vehiclefactory.CreateVehicle(type, fuelQty, fuelConsumption);
        }
    }
}