using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH5
{
    class NhanVien
    {
        private string _hoTen;
        private NgaySinh _ngaySinh;
        private string _diaChi;


        public string HoTen
        {
            get
            {
                return _hoTen;
            }

            set
            {
                _hoTen = value;
            }
        }

        internal NgaySinh NgaySinh
        {
            get
            {
                return _ngaySinh;
            }

            set
            {
                _ngaySinh = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _diaChi;
            }

            set
            {
                _diaChi = value;
            }
        }
        ~NhanVien() { }

        public NhanVien() { }

        public NhanVien(string _hoTen, NgaySinh _ngaySinh, string _diaChi)
        {
            this._hoTen = _hoTen;
            this._ngaySinh = _ngaySinh;
            this._diaChi = _diaChi;
        }
        

        public virtual string toString()
        {
            return $"Ho ten: {HoTen}\nNgay sinh: {NgaySinh.toString()}\nDia chi: {DiaChi}\n";
        }
    }
}
