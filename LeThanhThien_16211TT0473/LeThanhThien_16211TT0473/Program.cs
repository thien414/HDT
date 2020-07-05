using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeThanhThien_16211TT0473
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("39 duong 385","quan 9", "TP.HCM");

            Person person = new Person("thien", "le",new Address( "46 duong duong dinh hoi", "quan thu duc", "TP.HCM"));
            Person person1 = new Person("hieu", "ngo",new Address( "12 duong so 8", "quan thu duc", "TP.HCM"));
            Person person2 = new Person("thuan", "tran",new Address( "46 duong 147", "quan 9", "TP.HCM"));

            Money money = new Money(2,59);
            Money money1 = new Money();

            Console.WriteLine("---------------Address------------------\n");
            Console.WriteLine(address.toString());
            Console.WriteLine("\n--------------Person---------------------\n");
            Console.WriteLine(person.toString());
            Console.WriteLine(person1.toString());
            Console.WriteLine(person2.toString());
            Console.WriteLine(Person.CountOfPerson);
            Console.WriteLine("\n---------------Money---------------------\n");
            Console.WriteLine(money.toString());
            Console.WriteLine(money1.toString());
            Console.WriteLine($"getValue Money1: {money.getValue()}");
            Console.WriteLine($"getValue Money2: {money1.getValue()}");
            Console.ReadKey();
        }
    }
}
