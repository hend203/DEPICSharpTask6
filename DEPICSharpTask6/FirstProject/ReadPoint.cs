using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPICSharpTask6.First_Project
{
    internal class ReadPoint
    {
        public static Point3D ReadValidPoint(string pointName)
        {
            Console.WriteLine("Enter coordinates for " + pointName + ":");
            double x = ReadDouble.ReadValidDouble("X: ");
            double y = ReadDouble.ReadValidDouble("Y: ");
            double z = ReadDouble.ReadValidDouble("Z: ");
            return new Point3D(x, y, z);
        }
    }
}
