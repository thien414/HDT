using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NVQuanLy> listNVQL = new List<NVQuanLy>();
            List<NVSanXuat> listNVSX = new List<NVSanXuat>();
            List<NVVanChuyen> listNVVC = new List<NVVanChuyen>();
            List<NVVanPhong> listNVVP = new List<NVVanPhong>();
            DocFileNVQL(listNVQL);
            DocFileNVSX(listNVSX);
            DocFileNVVC(listNVVC);
            DocFileNVVP(listNVVP);
            int check = 0;
            do
            {
                Console.WriteLine("--------------Menu----------------");
                Console.WriteLine("-1.Them nhan vien!               -");
                Console.WriteLine("-2.Xoa nhan vien!                -");
                Console.WriteLine("-3.Sua nhan vien!                -");
                Console.WriteLine("-4.Tim kiem nhan vien!           -");
                Console.WriteLine("-5.Ghi file!                     -");
                Console.WriteLine("-6.Thoat!                        -");
                Console.WriteLine("---------------End----------------\n");
                Console.Write("Moi chon chuc nang menu!");
                check = int.Parse(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        int checkThem = 0;
                        do
                        {
                            Console.WriteLine("--------------Them----------------");
                            Console.WriteLine("-1.Them nhan vien QL!            -");
                            Console.WriteLine("-2.Them nhan vien VP!            -");
                            Console.WriteLine("-3.Them nhan vien SX!            -");
                            Console.WriteLine("-4.Them Nhan vien VC!            -");
                            Console.WriteLine("-5.Quay lai                      -");
                            Console.WriteLine("---------------End----------------\n");
                            Console.Write("Moi chon chuc nang menu!");
                            checkThem = int.Parse(Console.ReadLine());
                            switch (checkThem)
                            {
                                case 1:
                                    AddNVQL(listNVQL);
                                    Console.WriteLine("them thanh cong !!!");
                                    break;
                                case 2:
                                    AddNVVP(listNVVP);
                                    Console.WriteLine("them thanh cong !!!");
                                    break;
                                case 3:
                                    AddNVSX(listNVSX);
                                    Console.WriteLine("them thanh cong !!!");
                                    break;
                                case 4:
                                    AddNVVC(listNVVC);
                                    Console.WriteLine("them thanh cong !!!");
                                    break;
                                case 5:
                                    Console.WriteLine("Goobye!");
                                    break;
                                default:
                                    Console.WriteLine("Chon sai chuc nang vui long chon lai!");
                                    break;
                            }
                        } while (checkThem != 5);
                        break;
                    case 2:
                        Console.Write("Nhap ma nhan vien can xoa : ");
                        string strXoa = Console.ReadLine();
                        if (XoaNVQL(listNVQL, strXoa))
                        {
                            Console.WriteLine("xoa thanh cong !!!");
                        }else if (XoaNVSX(listNVSX, strXoa))
                        {
                            Console.WriteLine("xoa thanh cong !!!");
                        }else if (XoaNVVC(listNVVC, strXoa))
                        {
                            Console.WriteLine("xoa thanh cong !!!");
                        }else if (XoaNVVP(listNVVP, strXoa))
                        {
                            Console.WriteLine("xoa thanh cong !!!");
                        }else
                        {
                            Console.WriteLine("nhan vien khong ton tai !!!");
                        }
                        break;
                    case 3:
                        Console.Write("Nhap ma nhan vien can sua : ");
                        string strSua = Console.ReadLine();
                        if (SuaNVQL(listNVQL, strSua))
                        {
                            Console.WriteLine("sua thanh cong !!!");
                        }
                        else if (SuaNVSX(listNVSX, strSua))
                        {
                            Console.WriteLine("sua thanh cong !!!");
                        }
                        else if (SuaNVVC(listNVVC, strSua))
                        {
                            Console.WriteLine("sua thanh cong !!!");
                        }
                        else if (SuaNVVP(listNVVP, strSua))
                        {
                            Console.WriteLine("sua thanh cong !!!");
                        }
                        else
                        {
                            Console.WriteLine("nhan vien khong ton tai !!!");
                        }
                        break;
                    case 4:
                        Console.Write("Nhap ma nhan vien can tim kiem : ");
                        string strTK = Console.ReadLine();
                        if (!TK_NVQL(listNVQL, strTK).Equals(""))
                        {
                            Console.WriteLine("tim kiem thanh cong !!!");
                            Console.WriteLine("Thông tin Nhan vien can tim la : \n{0}", TK_NVQL(listNVQL, strTK));
                        }
                        else if (!TK_NVSX(listNVSX, strTK).Equals(""))
                        {
                            Console.WriteLine("tim kiem thanh cong !!!");
                            Console.WriteLine("Thông tin Nhan vien can tim la : \n{0}", TK_NVSX(listNVSX, strTK));
                        }
                        else if (!TK_NVVC(listNVVC, strTK).Equals(""))
                        {
                            Console.WriteLine("tim kiem thanh cong !!!");
                            Console.WriteLine("Thông tin Nhan vien can tim la : \n{0}", TK_NVVC(listNVVC, strTK));
                        }
                        else if (!TK_NVVP(listNVVP, strTK).Equals(""))
                        {
                            Console.WriteLine("tim kiem thanh cong !!!");
                            Console.WriteLine("Thông tin Nhan vien can tim la : \n{0}", TK_NVVP(listNVVP, strTK));
                        }
                        else
                        {
                            Console.WriteLine("nhan vien khong ton tai !!!");
                        }
                        break;
                    case 5:
                        GhiFileNVQL(listNVQL);
                        GhiFileNVSX(listNVSX);
                        GhiFileNVVC(listNVVC);
                        GhiFileNVVP(listNVVP);
                        Console.WriteLine("Ghi file thành công!");
                        break;
                    case 6:
                        Console.WriteLine("Goobye!");
                        break;
                    default:
                        Console.WriteLine("Chon sai chuc nang vui long chon lai!");
                        break;
                }

            } while (check != 6);
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
            if(nvSX.SoSP > 2000)
            {
                nvSX.TienThuong = 1000000;
            }else if(nvSX.SoSP > 1500)
            {
                nvSX.TienThuong = 700000;
            }else if(nvSX.SoSP > 1000)
            {
                nvSX.TienThuong = 500000;
            }else { nvSX.TienThuong = 0; }

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
            if (nvVC.SoDonVC > 2000)
            {
                nvVC.TienThuong = 1000000;
            }
            else if (nvVC.SoDonVC > 1500)
            {
                nvVC.TienThuong = 700000;
            }
            else if (nvVC.SoDonVC > 1000)
            {
                nvVC.TienThuong = 500000;
            }
            else { nvVC.TienThuong = 0; }

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
            foreach (NVQuanLy item in list)
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
                    Console.Write("\nNhập phụ cấp : ");
                    item.PhuCap = double.Parse(Console.ReadLine().ToString());

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
                    Console.Write("\nNhập số ngày làm việc : ");
                    item.SoNgayLam = int.Parse(Console.ReadLine().ToString());
                    Console.Write("\nNhập phụ cấp : ");
                    item.PhuCap = double.Parse(Console.ReadLine().ToString());

                    return true;
                }
            }
            return false;
        }

        static bool XoaNVQL(List<NVQuanLy> list, string maNV)
        {
            foreach (NVQuanLy item in list)
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
                    return item.toString() + $"\tThanh Luong : {item.TinhLuong()}\n";
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
                    return item.toString() + $"\tThanh Luong : {item.TinhLuong()}\n";
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
                    return item.toString() + $"\tThanh Luong : {item.TinhLuong()}\n";
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
                    return item.toString() + $"\tThanh Luong : {item.TinhLuong()}\n";
                }
            }
            return "";
        }

        static void GhiFileNVQL(List<NVQuanLy> list)
        {
            if (File.Exists("D:\\NVQuanLy.txt"))
            {
                FileStream fs = new FileStream("D:\\NVQuanLy.txt", FileMode.Truncate, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (NVQuanLy item in list)
                {
                    sWriter.WriteLine(item.MaNV);
                    sWriter.WriteLine(item.HoTen);
                    sWriter.WriteLine(item.NgaySinh);
                    sWriter.WriteLine(item.GioiTinh);
                    sWriter.WriteLine(item.CMND);
                    sWriter.WriteLine(item.DiaChi);
                    sWriter.WriteLine(item.SoDT);
                    sWriter.WriteLine(item.LuongCB);
                    sWriter.WriteLine(item.PhuCap);
                }
                sWriter.Flush();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream("D:\\NVQuanLy.txt", FileMode.Create, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (NVQuanLy item in list)
                {
                    sWriter.WriteLine(item.MaNV);
                    sWriter.WriteLine(item.HoTen);
                    sWriter.WriteLine(item.NgaySinh);
                    sWriter.WriteLine(item.GioiTinh);
                    sWriter.WriteLine(item.CMND);
                    sWriter.WriteLine(item.DiaChi);
                    sWriter.WriteLine(item.SoDT);
                    sWriter.WriteLine(item.LuongCB);
                    sWriter.WriteLine(item.PhuCap);
                }
                sWriter.Flush();
                fs.Close();
            }
        }
        static void GhiFileNVSX(List<NVSanXuat> list)
        {
            if (File.Exists("D:\\NVSanXuat.txt"))
            {
                FileStream fs = new FileStream("D:\\NVSanXuat.txt", FileMode.Truncate, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (NVSanXuat item in list)
                {
                    sWriter.WriteLine(item.MaNV);
                    sWriter.WriteLine(item.HoTen);
                    sWriter.WriteLine(item.NgaySinh);
                    sWriter.WriteLine(item.GioiTinh);
                    sWriter.WriteLine(item.CMND);
                    sWriter.WriteLine(item.DiaChi);
                    sWriter.WriteLine(item.SoDT);
                    sWriter.WriteLine(item.LuongCB);
                    sWriter.WriteLine(item.SoSP);
                    sWriter.WriteLine(item.TienThuong);
                }
                sWriter.Flush();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream("D:\\NVSanXuat.txt", FileMode.Create, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (NVSanXuat item in list)
                {
                    sWriter.WriteLine(item.MaNV);
                    sWriter.WriteLine(item.HoTen);
                    sWriter.WriteLine(item.NgaySinh);
                    sWriter.WriteLine(item.GioiTinh);
                    sWriter.WriteLine(item.CMND);
                    sWriter.WriteLine(item.DiaChi);
                    sWriter.WriteLine(item.SoDT);
                    sWriter.WriteLine(item.LuongCB);
                    sWriter.WriteLine(item.SoSP);
                    sWriter.WriteLine(item.TienThuong);
                }
                sWriter.Flush();
                fs.Close();
            }
        }
        static void GhiFileNVVC(List<NVVanChuyen> list)
        {
            if (File.Exists("D:\\NVVanChuyen.txt"))
            {
                FileStream fs = new FileStream("D:\\NVVanChuyen.txt", FileMode.Truncate, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (NVVanChuyen item in list)
                {
                    sWriter.WriteLine(item.MaNV);
                    sWriter.WriteLine(item.HoTen);
                    sWriter.WriteLine(item.NgaySinh);
                    sWriter.WriteLine(item.GioiTinh);
                    sWriter.WriteLine(item.CMND);
                    sWriter.WriteLine(item.DiaChi);
                    sWriter.WriteLine(item.SoDT);
                    sWriter.WriteLine(item.LuongCB);
                    sWriter.WriteLine(item.SoDonVC);
                    sWriter.WriteLine(item.TienThuong);
                }
                sWriter.Flush();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream("D:\\NVVanChuyen.txt", FileMode.Create, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (NVVanChuyen item in list)
                {
                    sWriter.WriteLine(item.MaNV);
                    sWriter.WriteLine(item.HoTen);
                    sWriter.WriteLine(item.NgaySinh);
                    sWriter.WriteLine(item.GioiTinh);
                    sWriter.WriteLine(item.CMND);
                    sWriter.WriteLine(item.DiaChi);
                    sWriter.WriteLine(item.SoDT);
                    sWriter.WriteLine(item.LuongCB);
                    sWriter.WriteLine(item.SoDonVC);
                    sWriter.WriteLine(item.TienThuong);
                }
                sWriter.Flush();
                fs.Close();
            }
        }
        static void GhiFileNVVP(List<NVVanPhong> list)
        {
            if (File.Exists("D:\\NVVanPhong.txt"))
            {
                FileStream fs = new FileStream("D:\\NVVanPhong.txt", FileMode.Truncate, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (NVVanPhong item in list)
                {
                    sWriter.WriteLine(item.MaNV);
                    sWriter.WriteLine(item.HoTen);
                    sWriter.WriteLine(item.NgaySinh);
                    sWriter.WriteLine(item.GioiTinh);
                    sWriter.WriteLine(item.CMND);
                    sWriter.WriteLine(item.DiaChi);
                    sWriter.WriteLine(item.SoDT);
                    sWriter.WriteLine(item.LuongCB);
                    sWriter.WriteLine(item.SoNgayLam);
                    sWriter.WriteLine(item.PhuCap);
                }
                sWriter.Flush();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream("D:\\NVVanPhong.txt", FileMode.Create, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (NVVanPhong item in list)
                {
                    sWriter.WriteLine(item.MaNV);
                    sWriter.WriteLine(item.HoTen);
                    sWriter.WriteLine(item.NgaySinh);
                    sWriter.WriteLine(item.GioiTinh);
                    sWriter.WriteLine(item.CMND);
                    sWriter.WriteLine(item.DiaChi);
                    sWriter.WriteLine(item.SoDT);
                    sWriter.WriteLine(item.LuongCB);
                    sWriter.WriteLine(item.SoNgayLam);
                    sWriter.WriteLine(item.PhuCap);
                }
                sWriter.Flush();
                fs.Close();
            }
        }

        static void DocFileNVQL(List<NVQuanLy> list)
        {
            if (File.Exists(@"D:\\NVQuanLy.txt"))
            {
                string[] lines = File.ReadAllLines(@"D:\\NVQuanLy.txt");
                for (int i = 0; i < lines.Length; i += 9)
                {
                    NVQuanLy item = new NVQuanLy();

                    item.MaNV = lines[i];
                    item.HoTen = lines[i + 1];
                    item.NgaySinh = DateTime.Parse(lines[i + 2]);
                    item.GioiTinh = bool.Parse(lines[i + 3]);
                    item.CMND = lines[i + 4];
                    item.DiaChi = lines[i + 5];
                    item.SoDT = int.Parse(lines[i + 6]);
                    item.LuongCB = double.Parse(lines[i + 7]);
                    item.PhuCap = double.Parse(lines[i + 8]);

                    list.Add(item);
                }
            }
        }
        static void DocFileNVSX(List<NVSanXuat> list)
        {
            if (File.Exists(@"D:\\NVSanXuat.txt"))
            {
                string[] lines = File.ReadAllLines(@"D:\\NVSanXuat.txt");
                for (int i = 0; i < lines.Length; i += 10)
                {
                    NVSanXuat item = new NVSanXuat();

                    item.MaNV = lines[i];
                    item.HoTen = lines[i + 1];
                    item.NgaySinh = DateTime.Parse(lines[i + 2]);
                    item.GioiTinh = bool.Parse(lines[i + 3]);
                    item.CMND = lines[i + 4];
                    item.DiaChi = lines[i + 5];
                    item.SoDT = int.Parse(lines[i + 6]);
                    item.LuongCB = double.Parse(lines[i + 7]);
                    item.SoSP = int.Parse(lines[i + 8]);
                    item.TienThuong = double.Parse(lines[i + 9]);

                    list.Add(item);
                }
            }
        }
        static void DocFileNVVC(List<NVVanChuyen> list)
        {
            if (File.Exists(@"D:\\NVVanChuyen.txt"))
            {
                string[] lines = File.ReadAllLines(@"D:\\NVVanChuyen.txt");
                for (int i = 0; i < lines.Length; i += 10)
                {
                    NVVanChuyen item = new NVVanChuyen();

                    item.MaNV = lines[i];
                    item.HoTen = lines[i + 1];
                    item.NgaySinh = DateTime.Parse(lines[i + 2]);
                    item.GioiTinh = bool.Parse(lines[i + 3]);
                    item.CMND = lines[i + 4];
                    item.DiaChi = lines[i + 5];
                    item.SoDT = int.Parse(lines[i + 6]);
                    item.LuongCB = double.Parse(lines[i + 7]);
                    item.SoDonVC = int.Parse(lines[i + 8]);
                    item.TienThuong = double.Parse(lines[i + 9]);

                    list.Add(item);
                }
            }
        }
        static void DocFileNVVP(List<NVVanPhong> list)
        {
            if (File.Exists(@"D:\\NVVanPhong.txt"))
            {
                string[] lines = File.ReadAllLines(@"D:\\NVVanPhong.txt");
                for (int i = 0; i < lines.Length; i += 10)
                {
                    NVVanPhong item = new NVVanPhong();

                    item.MaNV = lines[i];
                    item.HoTen = lines[i + 1];
                    item.NgaySinh = DateTime.Parse(lines[i + 2]);
                    item.GioiTinh = bool.Parse(lines[i + 3]);
                    item.CMND = lines[i + 4];
                    item.DiaChi = lines[i + 5];
                    item.SoDT = int.Parse(lines[i + 6]);
                    item.LuongCB = double.Parse(lines[i + 7]);
                    item.SoNgayLam = int.Parse(lines[i + 8]);
                    item.PhuCap = double.Parse(lines[i + 9]);

                    list.Add(item);
                }
            }
        }
    }
}
