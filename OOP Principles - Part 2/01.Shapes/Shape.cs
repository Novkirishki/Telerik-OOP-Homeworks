using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return width; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be greater than 0");
                }
                width = value; 
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be greater than 0");
                }
                height = value; 
            }
        }

        public abstract double CalculateSurface();
    }
}
