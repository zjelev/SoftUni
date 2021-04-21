namespace CollectionHierarchy.Models
{
    public class AddRemoveCollection : AddCollection, IAddRemove
    {
        public AddRemoveCollection() : base()
        { }
        public new int Add(string s)
        {
            this.List.Insert(0, s);
            return 0;
        }
        public virtual string Remove()
        {
            string element = this.List[this.List.Count - 1];
            this.List.RemoveAt(this.List.Count - 1);
            return element;
        }
    }
}