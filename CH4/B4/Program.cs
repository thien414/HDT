using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b4
{
    class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee employee1 = new HourlyEmployee(1.5, 5.0, 2, "ngo", "hieu");
            SalariedEmployee employee2 = new SalariedEmployee(2.0, 1.5, 2.2, 3, "le", "tri");

            Console.WriteLine(employee1.toString());
            Console.WriteLine(employee1.pay());
            Console.WriteLine(employee2.toString());
            Console.WriteLine(employee2.pay());

            Console.ReadKey();
        }
    }
}
