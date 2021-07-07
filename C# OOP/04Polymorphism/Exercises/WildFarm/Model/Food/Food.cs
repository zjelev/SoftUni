namespace WildFarm.Model
{
    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public virtual int Quantity { get; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
