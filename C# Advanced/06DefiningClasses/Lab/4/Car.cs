namespace CarManufacturer
{
    public class Car
    {
        private string make;
        public string Make
        {
            get { return make;}
            set { make = value;}
        }

        private string model;
        public string Model
        {
            get { return model;}
            set { model = value;}
        }
        
        private int year;
        public int Year
        {
            get { return year;}
            set { year = value;}
        }
        
        private double fuelQuantity;
        public double FuelQuantity
        {
            get { return fuelQuantity;}
            set { fuelQuantity = value;}
        }

        private double fuelConsumption;
        public double FuelConsumption
        {
            get { return fuelConsumption;}
            set { fuelConsumption = value;}
        }
        
        public void Drive(double distance)
        {
            double remainedFuel = FuelQuantity - distance / 100 * FuelConsumption;
            if (remainedFuel > 0)
            {
                fuelQuantity = remainedFuel;
            }
            else
            {
                System.Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";
        }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.fuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        private Engine engine;
        public Engine Engine
        {
            get { return engine;}
            set { engine = value;}
        }
        
        private Tire[] tires;
        public Tire[] Tires
        {
            get { return tires;}
            set { tires = value;}
        }
        
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }
    }
}