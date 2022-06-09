using System;
using System.Collections.Generic;
using System.Text;

namespace _08_CollectionHierarchy
{
    public class AddRemoveCollection : List<string>, IAddRemoveCollection
    {
        public int AddString(string item)
        {
            this.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            string itemToRemove = this[this.Count - 1];
            this.RemoveAt(this.Count - 1);
            return itemToRemove;
        }
    }
}
