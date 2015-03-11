//Problem 1. Structure
//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
//Implement the ToString() to enable printing a 3D point.

//Problem 2. Static read-only field
//Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
//Add a static property to return the point O.

//Problem 3. Static class
//Write a static class with a static method to calculate the distance between two points in the 3D space.

//Problem 4. Path
//Create a class Path to hold a sequence of points in the 3D space.
//Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.

namespace Point
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    class Points
    {
        static void Main(string[] args)
        {
            //make points and calculate their distance
            Point3D a = new Point3D(1, 1, 1);
            Point3D b = new Point3D(2, 3, 4);
            Console.WriteLine("The points are: A{0} and B{1}", a.ToString(), b.ToString());
            Console.WriteLine("The distance between them is {0}", Distance.Calculate(a,b));

            //make path with three points and print it
            Path path = new Path();
            path.AddPoint(a);
            path.AddPoint(b);
            path.AddPoint(new Point3D(3, 4, 5));
            Console.WriteLine(path.ToString());

            //remove a point and print the path again
            path.RemovePoint(b);
            Console.WriteLine(path.ToString());

            //read path from file and print it
            Path path2 = PathStorage.Load("test.txt");
            Console.WriteLine(path2.ToString());

            //remove first element from this path and write it to file
            path2.RemovePoint(0);
            PathStorage.Save("test2.txt", path2);
        }
    }
}
