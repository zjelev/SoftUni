using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public class SelectionSorter : ISortingStrategy
    {
        public ICollection<int> Sort(ICollection<int> collection)
        {
            Console.WriteLine("Selection sort rulz");

            return collection;
        }
    }
}
