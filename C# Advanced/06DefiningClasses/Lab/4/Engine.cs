namespace CarManufacturer
{
    public class Engine
    {
        private int horsePower;
        public int HorsePower
        {
            get { return horsePower;}
            set { horsePower = value;}
        }

        private double cubicCapacity;
        public double CubicCapacity
        {
            get { return cubicCapacity;}
            set { cubicCapacity = value;}
        }
        
        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }
        
    }
}