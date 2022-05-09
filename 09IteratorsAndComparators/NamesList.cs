using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    class NamesList : IEnumerable<string>
    {
        private string[] names = {"Pesho", "Peshov", "Ivanov" };

        public NamesList()
        { }

        public NamesList(string[] names)
        {
            this.names = names;
        }
        public IEnumerator<string> GetEnumerator()
        {
            return new SUEnumerator(names.ToList());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}