using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public class QuickSorter : ISortingStrategy
    {
        public ICollection<int> Sort(ICollection<int> collection)
        {
            Console.WriteLine("Quick sort rulz");

            return collection;
        }
    }
}
