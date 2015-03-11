namespace Point
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    static class Distance
    {
        public static double Calculate(Point3D a, Point3D b)
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2) + Math.Pow(a.Z - b.Z, 2));
            return distance;
        }
    }
}
