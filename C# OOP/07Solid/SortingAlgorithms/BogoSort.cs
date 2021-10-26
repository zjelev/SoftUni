using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public class BogoSort : ISortingStrategy
    {
        public ICollection<int> Sort(ICollection<int> collection)
        {
            Console.WriteLine("Bogo rulz");
            return collection;
        }
    }
}
