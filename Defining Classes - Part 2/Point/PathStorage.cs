namespace Point
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    static class PathStorage
    {
        public static Path Load(string filename)
        {
            Path path = new Path();
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    String line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] coordinates = line.Split(new char[] { ' ', '{', ',', '}' }, StringSplitOptions.RemoveEmptyEntries);
                        Point3D point = new Point3D(double.Parse(coordinates[0]), double.Parse(coordinates[1]), double.Parse(coordinates[2]));
                        path.AddPoint(point);
                        line = sr.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return path;
        }

        public static void Save(string filename, Path path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    sw.Write(path.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be written:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
