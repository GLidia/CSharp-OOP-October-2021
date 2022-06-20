using System;
using System.Collections.Generic;
using System.Text;

namespace _04_WildFarm
{
    public abstract class Food
    {
        public int Quantity { get; protected set;}

        public Food(int quantity)
        {
            this.Quantity = quantity;
        }
    }
}
