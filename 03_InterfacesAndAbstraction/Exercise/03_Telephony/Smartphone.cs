using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Telephony
{
    public class Smartphone : ICalling, IBrowsing
    {
        public void Call(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }

        public void Browse(string url)
        {
            Console.WriteLine($"Browsing: {url}!");
        }        
    }
}
