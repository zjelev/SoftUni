namespace CarManufacturer
{
   class Tire
    {
        private int year;
        public int Year
        {
            get { return this.year; }
            private set { this.year = value; }
        }

        private double pressure;
        public double Pressure
        {
            get { return this.pressure; }
            private set { this.pressure = value; }
        }
        
        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
}