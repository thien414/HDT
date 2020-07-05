//Nguyen Truong Thinh
//Bai 2 chuong 2
//Ngay: 18.5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenTruongThinh_Chuong2_Bai2
{
    class Time_Test
    {
        static void Main(string[] args)
        {
            //Khoi tao mot intance cua lop Time
            Time timea = new Time();

            //in thong tin len man Console
            Console.Write(timea.printTime());

            Console.ReadKey();
        }
    }
}
