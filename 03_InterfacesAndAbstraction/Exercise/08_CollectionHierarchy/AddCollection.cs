using System;
using System.Collections.Generic;
using System.Text;

namespace _08_CollectionHierarchy
{
    public class AddCollection : List<string>, IAddCollection
    {
        public new int AddString(string item)
        {
            this.Add(item);
            return this.Count - 1;
        }
    }
}
