using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Telephony
{
    public class StationaryPhone : ICalling
    {
        public void Call(string number)
        {
            Console.WriteLine($"Dialing... { number}");
        }
    }
}
