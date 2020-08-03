using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai5
{
    class Test
    {
        static void Main(string[] args)
        {
            int soSV = 0, chucNang = 0;
            Console.WriteLine("So SV:");
            int.TryParse(Console.ReadLine(), out soSV);
            SinhVien[] arrA = new SinhVien[soSV];
            do
            {
                Console.WriteLine("*************************Menu***********************");
                Console.Write("\n 1. Nhap thong tin cho n sinh vien.");
                Console.Write("\n 2. Xuat thong tin sinh vien.");
                Console.Write("\n 3. In phieu bao diem.");
                Console.Write("\n 4. Exit!");
                Console.WriteLine("****************************************************");
                Console.WriteLine("\n Chuc nang so:");
                int.TryParse(Console.ReadLine(), out chucNang);
                switch (chucNang)
                {
                    case 1:
                        nhapMangSV(arrA);
                        break;
                    case 2:
                        for (int i = 0; i < arrA.Length; i++)
                        {
                            Console.WriteLine("Thong tin sinh vien so {0}:", i + 1);
                            Console.WriteLine(arrA[i].toString());
                            arrA[i].printMonHoc();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Phieu Bao Diem");
                        for(int i=0;i<arrA.Length;i++)
                        {
                            Console.WriteLine("{0, -20} {1, -15} {2, -20} {3, -15}", "Ma sinh vien:", arrA[i].MaSV, "Ten sinh vien:", arrA[i].TenSV);
                            Console.WriteLine("{0, -20} {1, -15} {2, -20} {3, -15} ","Lop:", arrA[i].TenLop, "Khoa:", arrA[i].Khoa);
                            Console.WriteLine("Bang diem");
                            Console.WriteLine("{0, -20} {1, -20} {2, -20}", "Ten mon", "So tin chi", "Diem");
                            for(int j=0;j<arrA[i].MHoc.Length;j++)
                            {
                                Console.WriteLine("{0, -20} {1, -20} {2, -20}", arrA[i].MHoc[j].TenMon, arrA[i].MHoc[j].SoTC, arrA[i].MHoc[j].Diem);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Ban da thoat khoi chung trinh!");
                        break;
                }
                Console.ReadLine();
            } while (chucNang > 0 && chucNang < 5);
        }
        static void nhapMangSV(SinhVien[] SV)
        {
            for (int i = 0; i < SV.Length; i++)
            {
                SV[i] = new SinhVien();
                Console.WriteLine("\n Nhap thong tin SV so {0}:", i + 1);
                Console.Write("\n Ho ten:");
                SV[i].TenSV = Console.ReadLine();
                Console.Write("\n MSSV:");
                SV[i].MaSV = Console.ReadLine();
                Console.Write("\n Ten lop:");
                SV[i].TenLop = Console.ReadLine();
                Console.Write("\n Khoa:");
                SV[i].Khoa = Console.ReadLine();
                int soMon = 0;
                Console.WriteLine("So mon hoc:");
                int.TryParse(Console.ReadLine(), out soMon);
                SV[i].MHoc = new MonHoc[soMon];
                nhapMangMonHOc(SV[i].MHoc);
            }
        }
        static void nhapMangMonHOc(MonHoc[] MH)
        {
            for (int j = 0; j < MH.Length; j++)
            {
                MH[j] = new MonHoc();
                Console.Write("\n Ten mon:");
                MH[j].TenMon = Console.ReadLine();
                Console.Write("\n So tin chi:");
                MH[j].SoTC = int.Parse(Console.ReadLine());
                Console.Write("\n Diem:");
                MH[j].Diem = double.Parse(Console.ReadLine());
            }
        }
    }
}
