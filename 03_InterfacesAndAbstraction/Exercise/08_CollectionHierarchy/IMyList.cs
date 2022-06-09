using System;
using System.Collections.Generic;
using System.Text;

namespace _08_CollectionHierarchy
{
    public interface IMyList : IAddRemoveCollection
    {
        int Used { get; }
    }
}
