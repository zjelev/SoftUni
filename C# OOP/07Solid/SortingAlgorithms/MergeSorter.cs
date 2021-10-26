using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public class MergeSorter : ISortingStrategy
    {
        public ICollection<int> Sort(ICollection<int> collection)
        {
            Console.WriteLine("Merge sort rulz");

            return collection;
        }
    }
}
