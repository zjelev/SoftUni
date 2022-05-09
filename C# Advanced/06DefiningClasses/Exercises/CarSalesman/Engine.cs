using System;

namespace CarSalesman
{
    public class Engine
    {
        //-------------- Constructors --------------
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = 0;
            this.Efficiency = "n/a";
        }

        public Engine(string model, int power, int displacement)
            : this(model, power)
            {
                this.Displacement = displacement;
            }

        public Engine(string model, int power, string efficiency)
            : this(model, power)
            {
                this.Efficiency = efficiency;
            }
        public Engine(string model, int power, int displacement, string efficiency)
            : this(model, power)
            {
                this.Displacement = displacement;
                this.Efficiency = efficiency;
            }
        public Engine(string model, int power, string efficiency, int displacement)
            : this(model, power)
            {
                this.Displacement = displacement;
                this.Efficiency = efficiency;
            }
        //--------------- Properties ---------------        
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }
        
        //---------------- Methods -----------------

    }
}