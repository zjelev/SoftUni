namespace SpeedRacing
{
    public class Car
    {
        //----------------- Fields -----------------
        //-------------- Constructors --------------
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
         {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = 0;
        }

        //--------------- Properties ---------------
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        //---------------- METHODS -----------------
        public void Drive(double distance)
        {
            double remainedFuel = FuelAmount - distance * FuelConsumptionPerKilometer;
            if (remainedFuel >= 0)
            {
                FuelAmount = remainedFuel;
                TravelledDistance += distance;
            }
            else
            {
                System.Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:F2} {this.TravelledDistance}";
        }
    }
}