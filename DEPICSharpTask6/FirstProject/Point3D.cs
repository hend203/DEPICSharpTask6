using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPICSharpTask6.First_Project
{
    //Define 3D Point Class
    public class Point3D : IComparable, ICloneable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        //Basic Constructors

        // Full constructor — the "real" one that does the actual work
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Chains to the full constructor, defaulting Z to 0
        public Point3D(double x, double y) : this(x, y, 0)
        {
        }

        // Default constructor, chains to the full constructor with all zeros
        public Point3D() : this(0, 0, 0)
        {
        }

        // 2.  Override the ToString Function to produce this output -> "Point Coordinates: (10, 10, 10)"
        public override string ToString()
        {
            return "Point Coordinates: (" + X + ", " + Y + ", " + Z + ")";
        }

        // 5. Define an array of points and sort this array based on X & Y coordinates.
        public int CompareTo(object obj)
        {
            if (obj is Point3D other)
            {
                // Primary sort key: X
                if (this.X != other.X)
                    return this.X.CompareTo(other.X);

                // Secondary sort key: Y (used when X values are equal)
                return this.Y.CompareTo(other.Y);
            }

            throw new ArgumentException("Object is not a Point3D");
        }

        // 6. Implement ICloneable interface to be able to clone the object.

        public object Clone()
        {
            return new Point3D(this.X, this.Y, this.Z);
        }
    }
    }
