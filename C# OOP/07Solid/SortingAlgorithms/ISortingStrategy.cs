using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public interface ISortingStrategy
    {
        ICollection<int> Sort(ICollection<int> collection);
    }
}
