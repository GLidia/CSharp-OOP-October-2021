using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    class RandomList : List<string>
    {
        public string RandomString()
        {
            Random rnd = new Random();
            string randomString = base[rnd.Next(base.Count)];
            base.Remove(randomString);
            return randomString;
        }
    }
}
