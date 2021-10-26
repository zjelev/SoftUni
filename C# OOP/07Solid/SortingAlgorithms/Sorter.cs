using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SortingAlgorithms
{
    public class Sorter
    {
        public ICollection<int> Sort(ICollection<int> collection, string algorithm)
        {
            //ISortingStrategy strategy = null;

            // Without Reflection
            // if (algorithm.ToLower() == "selection")
            // {
            //     strategy = new SelectionSorter();
            // }            
            // if (algorithm.ToLower() == "quick")
            // {
            //     strategy = new QuickSorter();
            // }
            // if (algorithm.ToLower() == "merge")
            // {
            //     strategy = new MergeSorter();
            // }

            var sorterType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where( t => typeof(ISortingStrategy).IsAssignableFrom(t) && t.IsClass)
                .FirstOrDefault(t => t.Name.ToLower().Contains(algorithm));

            ISortingStrategy strategy = (ISortingStrategy)Activator.CreateInstance(sorterType);

            return strategy.Sort(collection);
        }
    }
}
