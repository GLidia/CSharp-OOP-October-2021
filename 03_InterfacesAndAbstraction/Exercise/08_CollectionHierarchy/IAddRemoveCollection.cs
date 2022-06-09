using System;
using System.Collections.Generic;
using System.Text;

namespace _08_CollectionHierarchy
{
    public interface IAddRemoveCollection : IAddCollection
    {
        string Remove();
    }
}
