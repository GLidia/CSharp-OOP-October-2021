using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return this.radius; }
            private set { this.radius = value; }
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * this.radius * this.radius;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
