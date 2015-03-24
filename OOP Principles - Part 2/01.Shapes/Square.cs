using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Shapes
{
    public class Square : Shape
    {
        public Square(double width) : base(width, width)
        {

        }
        public override double CalculateSurface()
        {
            return (double)(this.Width * this.Width);
        }
    }
}
