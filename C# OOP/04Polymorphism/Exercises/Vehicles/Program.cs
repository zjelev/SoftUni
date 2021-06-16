using System;
using Vehicles.Core;
using Vehicles.Factories;
using Vehicles.IO;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IVehiclefactory vehiclefactory = new VehicleFactory();

            IEngine engine = new Engine(reader, writer, vehiclefactory);
            engine.Run();
        }
    }
}
