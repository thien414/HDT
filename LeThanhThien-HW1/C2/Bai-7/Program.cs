using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeThanhThien_CH2_bt7
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien("hieu", "CD2", 9.5);
            SinhVien sv2 = new SinhVien("tam", "CD1", 4.5);
            SinhVien sv3 = new SinhVien("nha", "CD3", 7.5);

            Console.WriteLine(sv1.xepLoai());
            Console.WriteLine(sv2.xepLoai());
            Console.WriteLine(sv3.xepLoai());

            Console.ReadKey();
        }
    }
}
