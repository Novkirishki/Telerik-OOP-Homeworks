namespace Point
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Path
    {
        private List<Point3D> path;

        public Path()
        {
            path = new List<Point3D>();
        }

        public void AddPoint(Point3D a)
        {
            this.path.Add(a);
        }

        public void RemovePoint(Point3D a)
        {
            this.path.Remove(a);
        }

        public void RemovePoint(int index)
        {
            this.path.RemoveAt(index);
        }

        public void ClearPath()
        {
            this.path.Clear();
        }

        public override string ToString()
        {
            StringBuilder currentPath = new StringBuilder();
            foreach (var item in this.path)
            {
                currentPath.AppendLine(item.ToString());
            }

            return currentPath.ToString();
        }
    }
}
