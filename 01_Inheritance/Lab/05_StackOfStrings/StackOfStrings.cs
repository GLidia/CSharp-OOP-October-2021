using System;
using System.Collections.Generic;
using System.Text;

namespace CustomSTack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if (base.Count == 0)
            {
                return true;
            }

            return false;
        }

        public void AddRange(IEnumerable<string> collection)
        {
            foreach (string element in collection)
            {
                this.Push(element);
            }
        }
    }
}
