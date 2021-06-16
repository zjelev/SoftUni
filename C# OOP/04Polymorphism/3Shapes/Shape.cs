using System;

namespace Shapes
{
    public abstract class Shape
    {

        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
        public string Draw()
        {
            return "Drawing " + this.GetType().Name;
        }

    }
}