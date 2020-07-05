using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeThanhThien_CH2_bt6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCircle myCircleA = new MyCircle(new MyPoint(4, 5), 4);
            MyCircle myCircleB = new MyCircle(new MyPoint(5, 8), 4);

            Console.WriteLine("hinh tron 1: ");
            Console.WriteLine(myCircleA.toString());

            Console.WriteLine("hinh tron 2: ");
            Console.WriteLine(myCircleB.toString());

            Console.Write("Khoang cach giua hinh tron 1 va 2 la:  ");
            Console.Write(myCircleA.distance(myCircleB));


            Console.ReadKey();
        }
    }
}
