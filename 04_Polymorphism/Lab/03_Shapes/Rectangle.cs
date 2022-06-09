using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public double Height
        { 
            get { return this.height; } 
            private set { this.height = value; }
        }

        public double Width
        {
            get { return this.width; }
            private set { this.width = value; }
        }

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double CalculatePerimeter()
        {
            return this.height * 2 + this.width * 2;
        }

        public override double CalculateArea()
        {
            return this.height * this.width;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
