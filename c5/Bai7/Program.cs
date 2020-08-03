using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NhanVienCN> listCN = new List<NhanVienCN>();
            List<NhanVienSX> listSX = new List<NhanVienSX>();
            int thoat=0;
            
            do {
                nhapCN(listCN);
                nhapSX(listSX);
                Console.WriteLine("thoat them nhan vien nhap vao -1:");
                thoat = int.Parse(Console.ReadLine());
            } while (thoat != -1);
            
        }

        static void nhapCN(List<NhanVienCN> list)
        {
            NhanVienCN cn = new NhanVienCN();
            Console.WriteLine("Nhap ho ten nhan vien:");
            cn.Name = Console.ReadLine();
            NgaySinh ass = new NgaySinh();
            Console.WriteLine("Nhap Ngay:");
            ass.Day = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang:");
            ass.Month = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam:");
            ass.Year = int.Parse(Console.ReadLine());
            cn.BirthDay = ass;
            Console.WriteLine("Nhap dia chi:");
            cn.Adrres = Console.ReadLine();
            Console.WriteLine("Nhap so ngay lam:");
            cn.NgayLam = int.Parse(Console.ReadLine());
            list.Add(cn);

        }
        static void nhapSX(List<NhanVienSX> list)
        {
            NhanVienSX sx = new NhanVienSX();
            Console.WriteLine("Nhap ho ten nhan vien:");
            sx.Name = Console.ReadLine();
            NgaySinh ass = new NgaySinh();
            Console.WriteLine("Nhap Ngay:");
            ass.Day = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang:");
            ass.Month = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam:");
            ass.Year = int.Parse(Console.ReadLine());
            sx.BirthDay = ass;
            Console.WriteLine("Nhap dia chi:");
            sx.Name = Console.ReadLine();
            Console.WriteLine("Nhap so ngay lam:");
            sx.SanPham = double.Parse(Console.ReadLine());
            list.Add(sx);

        }
        static void xuatCN(List<NhanVienCN> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Xuat nhan vien CN thu:",i+1);
                Console.WriteLine(list[i].toString());
            }
        }
        static void xuatSX(List<NhanVienSX> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Xuat nhan vien SX thu:", i + 1);
                Console.WriteLine(list[i].toString());
            }
        }


    }
}
