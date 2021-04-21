namespace CollectionHierarchy.Models
{
    public class MyList : AddRemoveCollection, IList
    {
        public MyList() : base()
        { }
        public int Used 
        {
            get => this.List.Count;
        } 
        public override string Remove()
        {
            string firstElement = this.List[0];
            this.List.RemoveAt(0);
            return firstElement;
        }
    }
}