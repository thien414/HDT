using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai4
{
    class NhanVien
    {
        private string _hoTen;
        private DateTime _ngaySinh;
        private string _diaChi;
        private string _soCMND;
        private double _luongCB;

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

        public DateTime NgaySinh
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

        public string SoCMND
        {
            get
            {
                return _soCMND;
            }

            set
            {
                _soCMND = value;
            }
        }

        public double LuongCB
        {
            get
            {
                return _luongCB;
            }

            set
            {
                _luongCB = value;
            }
        }
        public NhanVien()
        {
            this._hoTen = "";
            this._ngaySinh = new DateTime(2020, 1, 1);
            this._diaChi = "";
            this._soCMND = "999999999";
            this._luongCB = 300000;
        }
        public NhanVien(string hoTen, DateTime ngaySinh, string diaChi, string soCMND, double luongCB)
        {
            this._hoTen = hoTen;
            this._ngaySinh = ngaySinh;
            this._diaChi = diaChi;
            this._soCMND = soCMND;
            this._luongCB = luongCB;
        }
        public virtual string toString()
        {
            string print;
            print = $"hoten:{this._hoTen}\n ngaysinh: {this._ngaySinh.ToString("d")}\n diachi: {this._diaChi}\n soCMND: {this._soCMND}\n luongCb:{this._luongCB}";
            return print;
        }
    }
}
