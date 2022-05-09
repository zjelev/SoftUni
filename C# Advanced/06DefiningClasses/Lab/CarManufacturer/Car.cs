namespace CarManufacturer
{
    class Car
    {
        private string make;
        public string Make
        {
            get { return this.make;}
            private set { this.make = value;}
        }

        private string model;
        public string Model
        {
            get { return this.model;}
            private set { this.model = value;}
        }
        
        private int year;
        public int Year
        {
            get { return this.year;}
            private set { this.year = value;}
        }
        
        private double fuelQuantity;
        public double FuelQuantity
        {
            get { return this.fuelQuantity;}
            private set { this.fuelQuantity = value;}
        }

        private double fuelConsumption;
        public double FuelConsumption
        {
            get { return this.fuelConsumption;}
            private set { this.fuelConsumption = value;}
        }
        
        private Engine engine;
        public Engine Engine
        {
            get { return this.engine;}
            private set { this.engine = value;}
        }
        
        private Tire[] tires;
        public Tire[] Tires
        {
            get { return this.tires;}
            private set { this.tires = value;}
        }
        
        /*
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
        */
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
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
       
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }
    }
}