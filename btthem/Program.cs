using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace btThem
{
    class Program
    {
        static void Main(string[] args)
        {
            int soSTK = 0, chucNang = 0;
            Console.WriteLine("So so thoi han:");
            int.TryParse(Console.ReadLine(), out soSTK);
            ThoiHan[] arrA = new ThoiHan[soSTK];
            Console.WriteLine("So so khong thoi han:");
            int.TryParse(Console.ReadLine(), out soSTK);
            KhongThoiHan[] arrB = new KhongThoiHan[soSTK];
            do
            {
                Console.WriteLine("*************************Menu***********************");
                Console.WriteLine(" 1. Nhap thong tin cho STK thoi han.");
                Console.WriteLine(" 2. Nhap thong tin cho STK khong thoi han.");
                Console.WriteLine(" 3. Xuat STK thoi han.");
                Console.WriteLine(" 4. Xuat STK khong thoi han.");
                Console.WriteLine("****************************************************");
                Console.WriteLine("\n Chuc nang so:");
                int.TryParse(Console.ReadLine(), out chucNang);
                switch (chucNang)
                {
                    case 1:
                        nhapThoiHan(arrA);
                        break;
                    case 2:
                        nhapKhongThoiHan(arrB);
                        break;
                    case 3:
                        xuatThoiHan(arrA);
                        break;
                    case 4:
                        xuatKhongThoiHan(arrB);
                        break;
                    default:
                        Console.WriteLine("Ban da thoat khoi chung trinh!");
                        break;
                }
                Console.ReadLine();
            } while (chucNang > 0 && chucNang < 5);
        }
        static void nhapThoiHan(ThoiHan[] TH)
        {
            for (int i = 0; i < TH.Length; i++)
            {
                TH[i] = new ThoiHan();
                Console.WriteLine("\nNhap so thoi han thu {0}:", i + 1);
                Console.Write("\n Thoi han:");
                TH[i].SoThangGui = int.Parse(Console.ReadLine());
                Console.Write("\n Ho Ten:");
                TH[i].HoTenKH = Console.ReadLine();
                Console.Write("\n CMND:");
                TH[i].CMND = Console.ReadLine();
                Console.Write("\n So Tien:");
                TH[i].SoTien = double.Parse(Console.ReadLine());
                Console.Write("\n Ngay lap:");
                TH[i].NgayLapSo = DateTime.Parse(Console.ReadLine());
                Console.Write("\n Lai Xuat:");
                TH[i].LaiXuat = double.Parse(Console.ReadLine());
            }
        }
        static void nhapKhongThoiHan(KhongThoiHan[] KTH)
        {
            for (int i = 0; i < KTH.Length; i++)
            {
                KTH[i] = new KhongThoiHan();
                Console.WriteLine("\nNhap so khong thoi han thu {0}:", i + 1);
                Console.Write("\n Ho Ten:");
                KTH[i].HoTenKH = Console.ReadLine();
                Console.Write("\n CMND:");
                KTH[i].CMND = Console.ReadLine();
                Console.Write("\n So Tien:");
                KTH[i].SoTien = double.Parse(Console.ReadLine());
                Console.Write("\n Ngay lap:");
                KTH[i].NgayLapSo = DateTime.Parse(Console.ReadLine());
                Console.Write("\n Lai Xuat:");
                KTH[i].LaiXuat = double.Parse(Console.ReadLine());
            }
        }
        static void xuatThoiHan(ThoiHan[] TH)
        {
            for (int i = 0; i < TH.Length; i++)
            {
                Console.WriteLine("/nThong tin bien lai so {0}:", i + 1);
                Console.WriteLine(TH[i].toString());
                Console.WriteLine("Tong tien lai hien tai la {0}:", TH[i].TienLai());
            }
        }
        static void xuatKhongThoiHan(KhongThoiHan[] KTH)
        {
            for (int i = 0; i < KTH.Length; i++)
            {
                Console.WriteLine("/nThong tin bien lai so {0}:", i + 1);
                Console.WriteLine(KTH[i].toString());
                Console.WriteLine("Tong tien lai hien tai la {0}:", KTH[i].TienLai());
            }
        }
    }
}
