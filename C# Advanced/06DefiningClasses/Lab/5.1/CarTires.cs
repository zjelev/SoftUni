using System.Collections.Generic;

namespace CarManufacturer
{
    public class CarTires
    {
        private List<Tire> tires;

        public List<Tire> Tires
        {
            get { return tires;}
            set { tires = value;}
        }
       
        public CarTires()
        {
            this.tires = new List<Tire>(4);
        }

        public void AddTire(Tire tire)
        {
            this.tires.Add(tire);
        }
    }
}