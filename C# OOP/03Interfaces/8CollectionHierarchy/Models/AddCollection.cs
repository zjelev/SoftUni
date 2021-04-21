namespace CollectionHierarchy.Models
{
    using System.Collections.Generic;
    
    public class AddCollection : IAdd
    {
        private List<string> list;
        public AddCollection()
        {
            this.list = new List<string>();
        }

        protected List<string> List => this.list;
        public int Add(string s)
        {
            this.list.Add(s);
            return list.Count - 1;
        }
    }
}
