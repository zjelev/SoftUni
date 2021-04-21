using System;

namespace CollectionHierarchy
{
    public interface IList : IAddRemove
    {
        int Used { get; }
    }
}
