using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo(1, 4);
            PhanSo ps2 = new PhanSo(4, 5);

            Console.WriteLine("phan so: {0},{1} sau khi rut gon : {2}, {3}",ps1.toString(),ps2.toString(),ps1.rutGonPS().toString(), ps2.rutGonPS().toString());
            Console.WriteLine("phan so: {0} + {1} = {2}", ps1.toString(), ps2.toString(), (ps1 + ps2).rutGonPS().toString());
            Console.WriteLine("phan so: {0} > {1}", (ps1 > ps2) ? ps1.rutGonPS().toString() : ps2.rutGonPS().toString(), (ps2 < ps1) ? ps2.rutGonPS().toString() : ps1.rutGonPS().toString());
            Console.WriteLine("Phan so: {0} + 1 = {1}", ps1.rutGonPS().toString(), (+ps1).rutGonPS().toString());
            Console.ReadKey();
        }
    }
}
