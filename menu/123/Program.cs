using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NVQuanLy> listNVQL = new List<NVQuanLy>();
            List<NVSanXuat> listNVSX = new List<NVSanXuat>();
            List<NVVanChuyen> listNVVC = new List<NVVanChuyen>();
            List<NVVanPhong> listNVVP = new List<NVVanPhong>();

            
        }
        static void AddNVQL(List<NVQuanLy> list)
        {
            NVQuanLy nvQL = new NVQuanLy();

            Console.Write("Nhập mã : ");
            nvQL.MaNV = Console.ReadLine().ToString();
            Console.Write("\nNhập tên : ");
            nvQL.HoTen = Console.ReadLine().ToString();
            Console.Write("\nNhập ngày sinh : ");
            nvQL.NgaySinh = DateTime.Parse(Console.ReadLine().ToString());
            Console.Write("\nNhập giới tính : ");
            nvQL.GioiTinh = Console.ReadLine().ToString().Equals("Nam") ? true : false;
            Console.Write("\nNhập CMND : ");
            nvQL.CMND = Console.ReadLine().ToString();
            Console.Write("\nNhập địa chỉ : ");
            nvQL.DiaChi = Console.ReadLine().ToString();
            Console.Write("\nNhập số điện thoại : ");
            nvQL.SoDT = int.Parse(Console.ReadLine().ToString());
            Console.Write("\nNhập Lương cơ bản : ");
            nvQL.LuongCB = double.Parse(Console.ReadLine().ToString());
            Console.Write("\nNhập phụ cấp : ");
            nvQL.PhuCap = double.Parse(Console.ReadLine().ToString());

            list.Add(nvQL);
        }
        static void AddNVSX(List<NVSanXuat> list)
        {
            NVSanXuat nvSX = new NVSanXuat();

            Console.Write("Nhập mã : ");
            nvSX.MaNV = Console.ReadLine().ToString();
            Console.Write("\nNhập tên : ");
            nvSX.HoTen = Console.ReadLine().ToString();
            Console.Write("\nNhập ngày sinh : ");
            nvSX.NgaySinh = DateTime.Parse(Console.ReadLine().ToString());
            Console.Write("\nNhập giới tính : ");
            nvSX.GioiTinh = Console.ReadLine().ToString().Equals("Nam") ? true : false;
            Console.Write("\nNhập CMND : ");
            nvSX.CMND = Console.ReadLine().ToString();
            Console.Write("\nNhập địa chỉ : ");
            nvSX.DiaChi = Console.ReadLine().ToString();
            Console.Write("\nNhập số điện thoại : ");
            nvSX.SoDT = int.Parse(Console.ReadLine().ToString());
            Console.Write("\nNhập Lương cơ bản : ");
            nvSX.LuongCB = double.Parse(Console.ReadLine().ToString());
            Console.Write("\nNhập số sản phẩm : ");
            nvSX.SoSP = int.Parse(Console.ReadLine().ToString());

            list.Add(nvSX);
        }
        static void AddNVVC(List<NVVanChuyen> list)
        {
            NVVanChuyen nvVC = new NVVanChuyen();

            Console.Write("Nhập mã : ");
            nvVC.MaNV = Console.ReadLine().ToString();
            Console.Write("\nNhập tên : ");
            nvVC.HoTen = Console.ReadLine().ToString();
            Console.Write("\nNhập ngày sinh : ");
            nvVC.NgaySinh = DateTime.Parse(Console.ReadLine().ToString());
            Console.Write("\nNhập giới tính : ");
            nvVC.GioiTinh = Console.ReadLine().ToString().Equals("Nam") ? true : false;
            Console.Write("\nNhập CMND : ");
            nvVC.CMND = Console.ReadLine().ToString();
            Console.Write("\nNhập địa chỉ : ");
            nvVC.DiaChi = Console.ReadLine().ToString();
            Console.Write("\nNhập số điện thoại : ");
            nvVC.SoDT = int.Parse(Console.ReadLine().ToString());
            Console.Write("\nNhập Lương cơ bản : ");
            nvVC.LuongCB = double.Parse(Console.ReadLine().ToString());
            Console.Write("\nNhập số đơn : ");
            nvVC.SoDonVC = int.Parse(Console.ReadLine().ToString());

            list.Add(nvVC);

        }
        static void AddNVVP(List<NVVanPhong> list)
        {
            NVVanPhong nvVP = new NVVanPhong();

            Console.Write("Nhập mã : ");
            nvVP.MaNV = Console.ReadLine().ToString();
            Console.Write("\nNhập tên : ");
            nvVP.HoTen = Console.ReadLine().ToString();
            Console.Write("\nNhập ngày sinh : ");
            nvVP.NgaySinh = DateTime.Parse(Console.ReadLine().ToString());
            Console.Write("\nNhập giới tính : ");
            nvVP.GioiTinh = Console.ReadLine().ToString().Equals("Nam") ? true : false;
            Console.Write("\nNhập CMND : ");
            nvVP.CMND = Console.ReadLine().ToString();
            Console.Write("\nNhập địa chỉ : ");
            nvVP.DiaChi = Console.ReadLine().ToString();
            Console.Write("\nNhập số điện thoại : ");
            nvVP.SoDT = int.Parse(Console.ReadLine().ToString());
            Console.Write("\nNhập Lương cơ bản : ");
            nvVP.LuongCB = double.Parse(Console.ReadLine().ToString());
            Console.Write("\nNhập số ngày làm việc : ");
            nvVP.SoNgayLam = int.Parse(Console.ReadLine().ToString());
            Console.Write("\nNhập phụ cấp : ");
            nvVP.PhuCap = double.Parse(Console.ReadLine().ToString());

            list.Add(nvVP);

        }

        static bool SuaNVQL(List<NVQuanLy> list, string maNV)
        {
            foreach(NVQuanLy item in list)
            {
                if (item.MaNV.Equals(maNV))
                {
                    Console.Write("\nNhập tên : ");
                    item.HoTen = Console.Read().ToString();
                    Console.Write("\nNhập ngày sinh : ");
                    item.NgaySinh = DateTime.Parse(Console.Read().ToString());
                    Console.Write("\nNhập giới tính : ");
                    item.GioiTinh = Console.Read().ToString().Equals("Nam") ? true : false;
                    Console.Write("\nNhập CMND : ");
                    item.CMND = Console.Read().ToString();
                    Console.Write("\nNhập địa chỉ : ");
                    item.DiaChi = Console.Read().ToString();
                    Console.Write("\nNhập số điện thoại : ");
                    item.SoDT = int.Parse(Console.Read().ToString());
                    Console.Write("\nNhập Lương cơ bản : ");
                    item.LuongCB = double.Parse(Console.Read().ToString());
                    Console.Write("\nNhập phụ cấp : ");
                    item.PhuCap = double.Parse(Console.Read().ToString());

                    return true;
                }
            }
            return false;
        }

        static bool SuaNVSX(List<NVSanXuat> list, string maNV)
        {
            foreach (NVSanXuat item in list)
            {
                if (item.MaNV.Equals(maNV))
                {
                    Console.Write("\nNhập tên : ");
                    item.HoTen = Console.ReadLine().ToString();
                    Console.Write("\nNhập ngày sinh : ");
                    item.NgaySinh = DateTime.Parse(Console.ReadLine().ToString());
                    Console.Write("\nNhập giới tính : ");
                    item.GioiTinh = Console.ReadLine().ToString().Equals("Nam") ? true : false;
                    Console.Write("\nNhập CMND : ");
                    item.CMND = Console.ReadLine().ToString();
                    Console.Write("\nNhập địa chỉ : ");
                    item.DiaChi = Console.ReadLine().ToString();
                    Console.Write("\nNhập số điện thoại : ");
                    item.SoDT = int.Parse(Console.ReadLine().ToString());
                    Console.Write("\nNhập Lương cơ bản : ");
                    item.LuongCB = double.Parse(Console.ReadLine().ToString());
                    Console.Write("\nNhập số sản phẩm : ");
                    item.SoSP = int.Parse(Console.ReadLine().ToString());

                    return true;
                }
            }
            return false;
        }

        static bool SuaNVVC(List<NVVanChuyen> list, string maNV)
        {
            foreach (NVVanChuyen item in list)
            {
                if (item.MaNV.Equals(maNV))
                {
                    Console.Write("\nNhập tên : ");
                    item.HoTen = Console.Read().ToString();
                    Console.Write("\nNhập ngày sinh : ");
                    item.NgaySinh = DateTime.Parse(Console.Read().ToString());
                    Console.Write("\nNhập giới tính : ");
                    item.GioiTinh = Console.Read().ToString().Equals("Nam") ? true : false;
                    Console.Write("\nNhập CMND : ");
                    item.CMND = Console.Read().ToString();
                    Console.Write("\nNhập địa chỉ : ");
                    item.DiaChi = Console.Read().ToString();
                    Console.Write("\nNhập số điện thoại : ");
                    item.SoDT = int.Parse(Console.Read().ToString());
                    Console.Write("\nNhập Lương cơ bản : ");
                    item.LuongCB = double.Parse(Console.Read().ToString());
                    Console.Write("\nNhập số đơn : ");
                    item.SoDonVC = int.Parse(Console.ReadLine().ToString());

                    return true;
                }
            }
            return false;
        }

        static bool SuaNVVP(List<NVVanPhong> list, string maNV)
        {
            foreach (NVVanPhong item in list)
            {
                if (item.MaNV.Equals(maNV))
                {
                    Console.Write("\nNhập tên : ");
                    item.HoTen = Console.Read().ToString();
                    Console.Write("\nNhập ngày sinh : ");
                    item.NgaySinh = DateTime.Parse(Console.Read().ToString());
                    Console.Write("\nNhập giới tính : ");
                    item.GioiTinh = Console.Read().ToString().Equals("Nam") ? true : false;
                    Console.Write("\nNhập CMND : ");
                    item.CMND = Console.Read().ToString();
                    Console.Write("\nNhập địa chỉ : ");
                    item.DiaChi = Console.Read().ToString();
                    Console.Write("\nNhập số điện thoại : ");
                    item.SoDT = int.Parse(Console.Read().ToString());
                    Console.Write("\nNhập Lương cơ bản : ");
                    item.LuongCB = double.Parse(Console.Read().ToString());
                    Console.Write("\nNhập phụ cấp : ");
                    item.PhuCap = double.Parse(Console.Read().ToString());

                    return true;
                }
            }
            return false;
        }

        static bool XoaNVQL(List<NVQuanLy> list, string maNV)
        {
            foreach(NVQuanLy item in list)
            {
                if (item.MaNV.Equals(maNV))
                {
                    list.Remove(item);
                    return true;
                }
            }
            return false;
        }

        static bool XoaNVSX(List<NVSanXuat> list, string maNV)
        {
            foreach (NVSanXuat item in list)
            {
                if (item.MaNV.Equals(maNV))
                {
                    list.Remove(item);
                    return true;
                }
            }
            return false;
        }

        static bool XoaNVVC(List<NVVanChuyen> list, string maNV)
        {
            foreach (NVVanChuyen item in list)
            {
                if (item.MaNV.Equals(maNV))
                {
                    list.Remove(item);
                    return true;
                }
            }
            return false;
        }

        static bool XoaNVVP(List<NVVanPhong> list, string maNV)
        {
            foreach (NVVanPhong item in list)
            {
                if (item.MaNV.Equals(maNV))
                {
                    list.Remove(item);
                    return true;
                }
            }
            return false;
        }

        static string TK_NVQL(List<NVQuanLy> list, string maNV)
        {
            foreach (NVQuanLy item in list)
            {
                if (item.MaNV.Equals(maNV))
                {
                    return item.toString();
                }
            }
            return "";
        }

        static string TK_NVSX(List<NVSanXuat> list, string maNV)
        {
            foreach (NVSanXuat item in list)
            {
                if (item.MaNV.Equals(maNV))
                {
                    return item.toString();
                }
            }
            return "";
        }

        static string TK_NVVC(List<NVVanChuyen> list, string maNV)
        {
            foreach (NVVanChuyen item in list)
            {
                if (item.MaNV.Equals(maNV))
                {
                    return item.toString();
                }
            }
            return "";
        }

        static string TK_NVVP(List<NVVanPhong> list, string maNV)
        {
            foreach (NVVanPhong item in list)
            {
                if (item.MaNV.Equals(maNV))
                {
                    return item.toString();
                }
            }
            return "";
        }

        static void GhiFileNVQL(List<NVQuanLy> list)
        {
            if (File.Exists("D:\\BankAccount.txt"))
            {
                FileStream fs = new FileStream("D:\\BankAccount.txt", FileMode.Truncate, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (BankAccount AC in list)
                {
                    sWriter.WriteLine(AC.ID);
                    sWriter.WriteLine(AC.Password);
                    sWriter.WriteLine(AC.TenTK);
                    sWriter.WriteLine(AC.LoaiTien);
                    sWriter.WriteLine(AC.SoDu);
                }
                sWriter.Flush();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream("D:\\BankAccount.txt", FileMode.Create, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (BankAccount AC in list)
                {
                    sWriter.WriteLine(AC.ID);
                    sWriter.WriteLine(AC.Password);
                    sWriter.WriteLine(AC.TenTK);
                    sWriter.WriteLine(AC.LoaiTien);
                    sWriter.WriteLine(AC.SoDu);
                }
                sWriter.Flush();
                fs.Close();
            }
        }

        static void GhiFileNVSX(List<NVSanXuat> list)
        {
            if (File.Exists("D:\\BankAccount.txt"))
            {
                FileStream fs = new FileStream("D:\\BankAccount.txt", FileMode.Truncate, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (BankAccount AC in list)
                {
                    sWriter.WriteLine(AC.ID);
                    sWriter.WriteLine(AC.Password);
                    sWriter.WriteLine(AC.TenTK);
                    sWriter.WriteLine(AC.LoaiTien);
                    sWriter.WriteLine(AC.SoDu);
                }
                sWriter.Flush();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream("D:\\BankAccount.txt", FileMode.Create, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (BankAccount AC in list)
                {
                    sWriter.WriteLine(AC.ID);
                    sWriter.WriteLine(AC.Password);
                    sWriter.WriteLine(AC.TenTK);
                    sWriter.WriteLine(AC.LoaiTien);
                    sWriter.WriteLine(AC.SoDu);
                }
                sWriter.Flush();
                fs.Close();
            }
        }

        static void GhiFileNVVC(List<NVVanChuyen> list)
        {
            if (File.Exists("D:\\BankAccount.txt"))
            {
                FileStream fs = new FileStream("D:\\BankAccount.txt", FileMode.Truncate, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (BankAccount AC in list)
                {
                    sWriter.WriteLine(AC.ID);
                    sWriter.WriteLine(AC.Password);
                    sWriter.WriteLine(AC.TenTK);
                    sWriter.WriteLine(AC.LoaiTien);
                    sWriter.WriteLine(AC.SoDu);
                }
                sWriter.Flush();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream("D:\\BankAccount.txt", FileMode.Create, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (BankAccount AC in list)
                {
                    sWriter.WriteLine(AC.ID);
                    sWriter.WriteLine(AC.Password);
                    sWriter.WriteLine(AC.TenTK);
                    sWriter.WriteLine(AC.LoaiTien);
                    sWriter.WriteLine(AC.SoDu);
                }
                sWriter.Flush();
                fs.Close();
            }
        }

        static void GhiFileNVVP(List<NVVanPhong> list)
        {
            if (File.Exists("D:\\BankAccount.txt"))
            {
                FileStream fs = new FileStream("D:\\BankAccount.txt", FileMode.Truncate, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (BankAccount AC in list)
                {
                    sWriter.WriteLine(AC.ID);
                    sWriter.WriteLine(AC.Password);
                    sWriter.WriteLine(AC.TenTK);
                    sWriter.WriteLine(AC.LoaiTien);
                    sWriter.WriteLine(AC.SoDu);
                }
                sWriter.Flush();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream("D:\\BankAccount.txt", FileMode.Create, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (BankAccount AC in list)
                {
                    sWriter.WriteLine(AC.ID);
                    sWriter.WriteLine(AC.Password);
                    sWriter.WriteLine(AC.TenTK);
                    sWriter.WriteLine(AC.LoaiTien);
                    sWriter.WriteLine(AC.SoDu);
                }
                sWriter.Flush();
                fs.Close();
            }
        }

        static void DocFile()
        {
            if (File.Exists(@"D:\\.txt"))
            {
                string[] lines = File.ReadAllLines(@"D:\\BankAccount.txt");
                for (int i = 0; i < lines.Length; i += 5)
                {
                    BankAccount AC = new BankAccount();

                    AC.ID = lines[i];
                    AC.Password = lines[i + 1];
                    AC.TenTK = lines[i + 2];
                    AC.LoaiTien = lines[i + 3];
                    AC.SoDu = int.Parse(lines[i + 4]);

                    list.Add(AC);
                }
            }
        }
    }
}
