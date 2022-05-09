namespace CarManufacturer
{
    public class Tire
    {
        private int make;
        public int Make
        {
            get { return make;}
            set { make = value;}
        }

        private double pressure;
        public double Pressure
        {
            get { return pressure;}
            set { pressure = value;}
        }
        
        public Tire(int make, double pressure)
        {
            this.Make = make;
            this.Pressure = pressure;
        }
    }
}