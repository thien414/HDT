using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D p = new Point2D(2.0f,3.0f);
            Point3D p1 = new Point3D(2.0f, 3.0f, 5.0f);
            Point2D p2 = new Point2D();
            Point3D p3 = new Point3D();

            Console.WriteLine(p.toString());
            Console.WriteLine(p1.toString());
            Console.WriteLine(p2.toString());
            Console.WriteLine(p3.toString());
            Console.ReadKey();


        }
    }
}
