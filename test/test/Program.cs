using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<NVQuanLy> listNVQL = new List<NVQuanLy>();
            IList<NVSanXuat> listNVSX = new List<NVSanXuat>();
            IList<NVVanChuyen> listNVVC = new List<NVVanChuyen>();
            IList<NVVanPhong> listNVVP = new List<NVVanPhong>();
        }
        static public void AddNVQL(IList<NVQuanLy> list)
        {
            NVQuanLy nvQL = new NVQuanLy();

            Console.Write("Nhập mã : ");
            nvQL.MaNV = Console.Read().ToString();
            Console.Write("\nNhập tên : ");
            nvQL.HoTen = Console.Read().ToString();
            Console.Write("\nNhập ngày sinh : ");
            nvQL.NgaySinh = DateTime.Parse(Console.Read().ToString());
            Console.Write("\nNhập giới tính : ");
            nvQL.GioiTinh = Console.Read().ToString().Equals("Nam") ? true : false;
            Console.Write("\nNhập CMND : ");
            nvQL.CMND = Console.Read().ToString();
            Console.Write("\nNhập địa chỉ : ");
            nvQL.DiaChi = Console.Read().ToString();
            Console.Write("\nNhập số điện thoại : ");
            nvQL.SoDT = int.Parse(Console.Read().ToString());
            Console.Write("\nNhập Lương cơ bản : ");
            nvQL.LuongCB = double.Parse(Console.Read().ToString());
            Console.Write("\nNhập phụ cấp : ");
            nvQL.PhuCap = double.Parse(Console.Read().ToString());

            list.Add(nvQL);
        }
        static public void AddNVSX(IList<NVSanXuat> list)
        {
            NVSanXuat nvSX = new NVSanXuat();

            Console.Write("Nhập mã : ");
            nvSX.MaNV = Console.Read().ToString();
            Console.Write("\nNhập tên : ");
            nvSX.HoTen = Console.Read().ToString();
            Console.Write("\nNhập ngày sinh : ");
            nvSX.NgaySinh = DateTime.Parse(Console.Read().ToString());
            Console.Write("\nNhập giới tính : ");
            nvSX.GioiTinh = Console.Read().ToString().Equals("Nam") ? true : false;
            Console.Write("\nNhập CMND : ");
            nvSX.CMND = Console.Read().ToString();
            Console.Write("\nNhập địa chỉ : ");
            nvSX.DiaChi = Console.Read().ToString();
            Console.Write("\nNhập số điện thoại : ");
            nvSX.SoDT = int.Parse(Console.Read().ToString());
            Console.Write("\nNhập Lương cơ bản : ");
            nvSX.LuongCB = double.Parse(Console.Read().ToString());
            Console.Write("\nNhập số sản phẩm : ");
            nvSX.SoSP = int.Parse(Console.Read().ToString());

            list.Add(nvSX);
        }
        static public void AddNVVC(IList<NVVanChuyen> list)
        {
            NVVanChuyen nvVC = new NVVanChuyen();

            Console.Write("Nhập mã : ");
            nvVC.MaNV = Console.Read().ToString();
            Console.Write("\nNhập tên : ");
            nvVC.HoTen = Console.Read().ToString();
            Console.Write("\nNhập ngày sinh : ");
            nvVC.NgaySinh = DateTime.Parse(Console.Read().ToString());
            Console.Write("\nNhập giới tính : ");
            nvVC.GioiTinh = Console.Read().ToString().Equals("Nam") ? true : false;
            Console.Write("\nNhập CMND : ");
            nvVC.CMND = Console.Read().ToString();
            Console.Write("\nNhập địa chỉ : ");
            nvVC.DiaChi = Console.Read().ToString();
            Console.Write("\nNhập số điện thoại : ");
            nvVC.SoDT = int.Parse(Console.Read().ToString());
            Console.Write("\nNhập Lương cơ bản : ");
            nvVC.LuongCB = double.Parse(Console.Read().ToString());
            Console.Write("\nNhập số đơn : ");
            nvVC.SoDonVC = int.Parse(Console.Read().ToString());

            list.Add(nvVC);

        }
        static public void AddNVVP(IList<NVVanPhong> list)
        {
            NVVanPhong nvVP = new NVVanPhong();

            Console.Write("Nhập mã : ");
            nvVP.MaNV = Console.Read().ToString();
            Console.Write("\nNhập tên : ");
            nvVP.HoTen = Console.Read().ToString();
            Console.Write("\nNhập ngày sinh : ");
            nvVP.NgaySinh = DateTime.Parse(Console.Read().ToString());
            Console.Write("\nNhập giới tính : ");
            nvVP.GioiTinh = Console.Read().ToString().Equals("Nam") ? true : false;
            Console.Write("\nNhập CMND : ");
            nvVP.CMND = Console.Read().ToString();
            Console.Write("\nNhập địa chỉ : ");
            nvVP.DiaChi = Console.Read().ToString();
            Console.Write("\nNhập số điện thoại : ");
            nvVP.SoDT = int.Parse(Console.Read().ToString());
            Console.Write("\nNhập Lương cơ bản : ");
            nvVP.LuongCB = double.Parse(Console.Read().ToString());
            Console.Write("\nNhập số ngày làm việc : ");
            nvVP.SoNgayLam = int.Parse(Console.Read().ToString());
            Console.Write("\nNhập phụ cấp : ");
            nvVP.PhuCap = double.Parse(Console.Read().ToString());

            list.Add(nvVP);

        }
    }
}
