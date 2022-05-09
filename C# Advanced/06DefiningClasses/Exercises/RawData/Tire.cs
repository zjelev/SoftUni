namespace RawData
{
    public class Tire
    {
        //-------------- Constructors --------------
        public Tire(int age, double pressure)
        {
            this.Age = age;
            this.Pressure = pressure;
        }
        
        //--------------- Properties ---------------
        public int Age { get; set; }

        public double Pressure { get; set; }
    }
}