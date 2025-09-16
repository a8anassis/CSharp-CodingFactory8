using PointApp.Model;

namespace PointApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new() { X = 10 };
            Point2D p2 = new() { X = 10, Y = 20 };
            Point3D p3 = new() { X = 10, Y = 20, Z = 30 };
            Point p4 = new Point3D() { X = 100, Y = 200, Z = 300 }; // Type polymorphism
        }
    }
}
