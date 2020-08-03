using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b5
{
    class Program
    {
        static void Main(string[] args)
        {
            Money m1 = new Money(10, 50);
            Money m2 = new Money(5, 80);
            Money m3 = new Money(16, 40);
            Money m4 = new Money(7, 70);
            

            Console.WriteLine("1 : {0} + {1} = {2}", m1.toString(), m2.toString(), (m1+m2).toString());
            Console.WriteLine("2 : {0} + {1} = {2}", m2.toString(), m4.toString(), (m2+m4).toString());
            Console.WriteLine("3 : {0} - {1} = {2}", m3.toString(), m2.toString(), (m3-m2).toString());
            Console.WriteLine("4 : {0} - {1} = {2}", m4.toString(), m1.toString(), (m4-m1).toString());

            Console.ReadKey();
        }
    }
}
