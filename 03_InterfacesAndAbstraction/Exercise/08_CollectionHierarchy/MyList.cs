using System;
using System.Collections.Generic;
using System.Text;

namespace _08_CollectionHierarchy
{
    public class MyList : List<string>, IMyList
    {
        public int Used
        {
            get { return this.Count; }
        }

        public int AddString(string item)
        {
            this.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            string itemToRemove = this[0];
            this.RemoveAt(0);
            return itemToRemove;
        }
    }
}
