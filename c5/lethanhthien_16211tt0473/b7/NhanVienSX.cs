using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH5
{
    class NhanVienSX : NhanVien, INhanVien
    {

        private int _sanPham;

        public NhanVienSX(): base() { }

        public NhanVienSX(int _sanpham, string _hoTen, NgaySinh _ngaySinh, string _diaChi) : base(_hoTen,_ngaySinh,_diaChi)
        {
            this._sanPham = _sanpham;
        }

        public int SanPham
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

        public double Luong()
        {
            return SanPham * 3000;
        }

        public override string toString()
        {
            return base.toString() + $"San pham: {SanPham}\nLuong: {Luong()}";
        }
    }
}
