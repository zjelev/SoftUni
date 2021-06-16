using System;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public override double CalculateArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        // public override string Draw()
        // {
        //     return base.Draw();
        // }
    }
}
