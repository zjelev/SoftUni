namespace _08Generics
{
    public class MyTuple<TItem1, TItem2, TItem3>
    {
        private TItem1 item1;
        private TItem2 item2;
        private TItem3 item3;

        public MyTuple(TItem1 item1, TItem2 item2, TItem3 item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public TItem1 Item1 => this.item1;
        public TItem2 Item2 => this.item2;
        public TItem3 Item3 => this.item3;

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2} -> {this.Item3}";
        }
    }
}