using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    class NVSanXuat : NhanVien
    {
        private double _tienThuong;
        private int _soSP;

        public int SoSP
        {
            get
            {
                return _soSP;
            }

            set
            {
                _soSP = value;
            }
        }

        public double TienThuong
        {
            get
            {
                return _tienThuong;
            }

            set
            {
                _tienThuong = value;
            }
        }

        public NVSanXuat() : base() { }

        public NVSanXuat(double tienThuong, int soSP, string maNV, string hoTen, DateTime ngaySinh, bool gioiTinh, string CMND, string diaChi, int soDT, double luongCB) : base(maNV, hoTen, ngaySinh, gioiTinh, CMND, diaChi, soDT, luongCB)
        {
            this._soSP = soSP;
            this._tienThuong = tienThuong;
        }

        public override double TinhLuong()
        {
            return LuongCB + SoSP * 20000 + TienThuong;
        }

        public override string toString()
        {
            return base.toString() + $"\tSố sản phẩm : {this._soSP}\n\tTiền Thưởng : {this._tienThuong}đ\n";
        }
    }
}
