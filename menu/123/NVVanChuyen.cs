using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    class NVVanChuyen : NhanVien
    {
        private double _tienThuong;
        private int _soDonVC;

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

        public int SoDonVC
        {
            get
            {
                return _soDonVC;
            }

            set
            {
                _soDonVC = value;
            }
        }

        public NVVanChuyen() : base() { }

        public NVVanChuyen(double tienThuong, int soDonVC, string maNV, string hoTen, DateTime ngaySinh, bool gioiTinh, string CMND, string diaChi, int soDT, double luongCB) : base(maNV, hoTen, ngaySinh, gioiTinh, CMND, diaChi, soDT, luongCB)
        {
            this._soDonVC = soDonVC;
            this._tienThuong = tienThuong;
        }

        public override double TinhLuong()
        {
            return LuongCB + SoDonVC * 15000 + TienThuong;
        }

        public override string toString()
        {
            return base.toString() + $"\tSố đơn : {this._soDonVC}\n\tTiền thưởng : {this._tienThuong}đ\n";
        }
    }
}
