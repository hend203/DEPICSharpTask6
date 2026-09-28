using DEPICSharpTask6.First_Project;
using DEPICSharpTask6.SecondProject;
using DEPICSharpTask6.ThirdProject;

namespace DEPICSharpTask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------- First Project --------
            // 2. ToString demo
            Point3D P = new Point3D(10, 10, 10);
            Console.WriteLine(P.ToString()); // "Point Coordinates: (10, 10, 10)"

          // 3. Read P1 and P2 from the user, safely (TryParse-based, no crashes on bad input)
            Point3D P1 = ReadPoint.ReadValidPoint("P1");
            Point3D P2 = ReadPoint.ReadValidPoint("P2");

            // 4. Try using ==
            if (P1 == P2)
                Console.WriteLine("P1 equals P2");
            else
                Console.WriteLine("P1 does NOT equal P2");

            /*
             * If (P1 == P2) Does it work properly??
             * Answer: No, it does not work properly because the == operator is not overloaded for the Point3D class. 
             * By default, the == operator checks for reference equality, meaning it checks if both variables point to the same object in memory. 
             * Since P1 and P2 are two different instances of Point3D, even if they have the same coordinates, the comparison will return false unless you overload the == operator to compare the values of X, Y, and Z instead of their references.
             */

            // 5. Define an array of points and sort this array based on X & Y coordinates.
            Point3D[] points = new Point3D[]
           {
                new Point3D(3, 5, 1),
                new Point3D(1, 9, 2),
                new Point3D(1, 2, 3),
                new Point3D(2, 0, 4)
           };

            Array.Sort(points); // works because Point3D implements IComparable

            Console.WriteLine("\nSorted points:");
            foreach (Point3D p in points)
                Console.WriteLine(p.ToString());

            // 6. Clone P1 and show that the clone is a separate object
            Point3D original = new Point3D(7, 8, 9);
            Point3D cloned = (Point3D)original.Clone();
            cloned.X = 100; // modifying the clone should NOT affect the original

            Console.WriteLine("\nOriginal: " + original.ToString());
            Console.WriteLine("Cloned (modified): " + cloned.ToString());


            //-------- Second Project --------

            Maths math = new Maths(); // requires creating an instance

            Console.WriteLine("Add: " + math.Add(5, 3));
            Console.WriteLine("Subtract: " + math.Subtract(5, 3));
            Console.WriteLine("Multiply: " + math.Multiply(5, 3));
            Console.WriteLine("Divide: " + math.Divide(5, 3));


            // Calling directly on the class name — no "new MathsStatic()" needed
            Console.WriteLine("Add: " + MathsStatic.Add(5, 3));
            Console.WriteLine("Subtract: " + MathsStatic.Subtract(5, 3));
            Console.WriteLine("Multiply: " + MathsStatic.Multiply(5, 3));
            Console.WriteLine("Divide: " + MathsStatic.Divide(5, 3));

            /* What changed: marking the class and its methods static means they belong to the class itself, 
             * not to any particular object. There is only ever one shared copy of a static method, 
             * so it's called through the class name directly (MathsStatic.Add(...)) instead of needing new Maths().Add(...)
             */

            //-------- Third Project --------
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString()); // "Hours: 1, Minutes :10, Seconds :15"

            Duration D1b = new Duration(3600);
            Console.WriteLine(D1b.ToString()); // "Hours: 1, Minutes :0, Seconds :0"

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2.ToString()); // "Hours: 2, Minutes :10, Seconds :0"

            Duration D3 = new Duration(666);
            Console.WriteLine(D3.ToString()); // "Minutes :11, Seconds :6"

            // Equals/GetHashCode demo
            Duration a = new Duration(0, 5, 0);
            Duration b = new Duration(300); // 5 minutes = 300 seconds
            Console.WriteLine("a.Equals(b): " + a.Equals(b)); // True — same total duration
            Console.WriteLine("a.GetHashCode() == b.GetHashCode(): " + (a.GetHashCode() == b.GetHashCode())); // True
        }
    }
}
