using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_bt1
{
    class Program
    {
        static void Main(string[] args)
        {

            Cylinder cylinder1 = new Cylinder(2.5,6.5,"black");
            Cylinder cylinder2 = new Cylinder(2.5, 6.5);


            Console.WriteLine("tru tron 1: ");
            Console.WriteLine(cylinder1.toString());
            Console.Write("the tich hinh tru tron la: ");
            Console.WriteLine(cylinder1.getVolume());

            Console.WriteLine("tru tron 2: ");
            Console.WriteLine(cylinder2.toString());
            Console.Write("the tich hinh tru tron la: ");
            Console.Write(cylinder2.getVolume());

            Console.ReadKey();
        }
    }
}
