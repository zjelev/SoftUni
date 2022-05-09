namespace RawData
{
    public class Car
    {
        //---------------- Fields -----------------

        //-------------- Constructors -------------
        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }
        //--------------- Properties ---------------
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }

        //---------------- Methods -----------------
        
    }
}