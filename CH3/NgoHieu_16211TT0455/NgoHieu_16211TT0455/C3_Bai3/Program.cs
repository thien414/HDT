using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape sp1 = new Shape();
            Shape sp2 = new Shape("Blue", true);
            Circle c1 = new Circle();
            Circle c2 = new Circle("Black",true,3);
            Rectangle r = new Rectangle();
            Rectangle r1 = new Rectangle("with", true, 2, 3);
            Square s = new Square();
            Square s1 = new Square("red", true, 1, 1, 1);

            Console.WriteLine("Thong tin shape");
            Console.WriteLine(sp1.toString());
            Console.WriteLine(sp2.toString());
            Console.WriteLine("Thong tin Circle");
            Console.WriteLine(c1.toString());
            Console.WriteLine(c2.toString());
            Console.WriteLine("Thong tin Rectangle");
            Console.WriteLine(r.toString());
            Console.WriteLine(r1.toString());
            Console.WriteLine("Thong tin Square");
            Console.WriteLine(s.toString());
            Console.WriteLine(s1.toString());

            Console.ReadKey();








        }
    }
}
