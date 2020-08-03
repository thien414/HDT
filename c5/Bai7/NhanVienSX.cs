using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai7
{
    class NhanVienSX:NhanVien,ILuong
    {
        private double _sanPham;

        public double SanPham
        {
            get
            {
                return _sanPham;
            }

            set
            {
                _sanPham = value;
            }
        }
        public NhanVienSX() : base()
        {
            this._sanPham = 1;
        }
        public NhanVienSX(double sanPham, NgaySinh birthDay, string name, string adrres) : base( birthDay,  name,  adrres)
        {
            this._sanPham = sanPham;
        }
        public double luong()
        {
            double tinhLuong = this._sanPham * 3000;
            return tinhLuong;
        }
        public override string toString()
        {
            return base.toString() + $"San Pham:{SanPham}\t Luong: {luong()}" ;
        }

    }
}
