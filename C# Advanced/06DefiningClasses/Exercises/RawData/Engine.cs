namespace RawData
{
    public class Engine
    {
        //-------------- Constructors --------------
        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        //--------------- Properties ---------------
        public int Speed { get; set; }
        public int Power { get; set; }

    }
}