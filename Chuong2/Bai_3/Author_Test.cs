//Nguyen Truong Thinh
//Bai 3 chuong 2
//Ngay: 23/5/2020
using NguyenTruongThinh_Chuong2_Bai3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BTChuong2
{
    class Author_Test
    {
        static void Main(string[] args)
        {
            //Tao 2 instance cua lop Author
            Author au1 = new Author("Nguyen Van Teo", 'u', new DateTime(), "");
            Author au2 = new Author("Nguyen Truong Thinh", 'm',new DateTime (2000, 5, 28),"student");

            //in len man Console
            Console.Write($"Thong tin cua cac tac gia:\nAuthor 1:\t{au1.printInfo()}\nAuthor 2:\t{au2.printInfo()}");

            Console.ReadKey();
        }
    }
}
