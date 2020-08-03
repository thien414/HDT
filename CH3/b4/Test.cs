using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b5
{
    class Test
    {
        static void Main(string[] args)
        {
            int soHo = 0, chucNang = 0;
            Console.WriteLine("So ho:");
            int.TryParse(Console.ReadLine(), out soHo);
            BienLai[] arrA = new BienLai[soHo];
            do
            {
                Console.WriteLine("*************************Menu***********************");
                Console.Write("\n 1. Nhap thong tin cho n bien lai va xuat thong tin vua nhap.");
                Console.Write("\n 2. Tinh tong tien dien thu duoc tu cac ho gia dinh.");
                Console.Write("\n 3. Exit!");
                Console.WriteLine("****************************************************");
                Console.WriteLine("\n Chuc nang so:");
                int.TryParse(Console.ReadLine(), out chucNang);
                switch (chucNang)
                {
                    case 1:
                        nhapMangBienLai(arrA);
                        for (int i = 0; i < arrA.Length; i++)
                        {
                            Console.WriteLine("Thong tin bien lai so {0}:", i + 1);
                            Console.WriteLine(arrA[i].toString());
                        }
                        break;
                    case 2:
                        int tongTien = 0;
                        for (int i = 0; i < arrA.Length; i++)
                        {
                            tongTien += arrA[i].tinhTienDien();
                        }
                        Console.WriteLine("Tong tien nguoi quan ly thu duoc tu cac bien lai:{0}", tongTien);
                        break;
                    default:
                        Console.WriteLine("Ban da thoat khoi chung trinh!");
                        break;
                }
                Console.ReadLine();
            } while (chucNang > 0 && chucNang < 4);
        }
        static void nhapMangBienLai(BienLai[] BL)
        {
            for (int i = 0; i < BL.Length; i++)
            {
                BL[i] = new BienLai();
                Console.WriteLine("\nNhap bien lai so {0}:", i + 1);
                Console.Write("\n Ho ten:");
                BL[i].HoTen = Console.ReadLine();
                Console.Write("\n So nha:");
                BL[i].SoNha = int.Parse(Console.ReadLine());
                Console.Write("\n Ma so cong to:");
                BL[i].MaSoCongTo = Console.ReadLine();
                Console.Write("\n Chi so cu:");
                BL[i].ChiSoCu = int.Parse(Console.ReadLine());
                Console.Write("\n Chi so moi:");
                BL[i].ChiSoMoi = int.Parse(Console.ReadLine());
            }
        }
    }
}
