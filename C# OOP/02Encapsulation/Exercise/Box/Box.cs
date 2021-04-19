using System;

namespace BoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get { return length; }
            private set 
            { 
                if (isValid(value))
                {
                    length = value;
                }
            }
        }
        
        public double Width
        {
            get { return width; }
            private set 
            { 
                if (isValid(value))
                {
                    width = value;                    
                }
            }
        }
        
        public double Height
        {
            get { return height; }
            private set 
            { 
                if (isValid(value))
                {
                    height = value;                    
                }
            }
        }

        private bool isValid(double value)
        {
            return value >= 0;
        }
        
        public double SurfaceArea()
        {
            return 2 * (Length * Width + Length * Height + Width * Height);
        }

        public double LateralSurfaceArea()
        {
            return 2 * (Length * Height + Width * Height);
        }

        public double Volume()
        {
            return Length * Width * Height;
        }
    }
}
