namespace Point
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    struct Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D o = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            string result = String.Format("{{{0}, {1}, {2}}}", this.x, this.y, this.z);
            return result;
        }

        internal static Point3D O
        {
            get { return Point3D.o; }
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Z
        {
            get { return z; }
            set { z = value; }
        }
    }
}
