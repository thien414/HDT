using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    abstract class NhanVien
    {
        private string _maNV;
        private string _hoTen;
        private DateTime _ngaySinh;
        private bool _gioiTinh;
        private string _CMND;
        private string _diaChi;
        private int _soDT;
        private double _luongCB;

        public string MaNV
        {
            get
            {
                return _maNV;
            }

            set
            {
                _maNV = value;
            }
        }

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

        public bool GioiTinh
        {
            get
            {
                return _gioiTinh;
            }

            set
            {
                _gioiTinh = value;
            }
        }

        public string CMND
        {
            get
            {
                return _CMND;
            }

            set
            {
                _CMND = value;
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

        public int SoDT
        {
            get
            {
                return _soDT;
            }

            set
            {
                _soDT = value;
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

        public NhanVien() { }

        public NhanVien(string maNV, string hoTen, DateTime ngaySinh, bool gioiTinh, string CMND, string diaChi, int soDT, double luongCB)
        {
            this._maNV = maNV;
            this._hoTen = hoTen;
            this._ngaySinh = ngaySinh;
            this._gioiTinh = gioiTinh;
            this._CMND = CMND;
            this._diaChi = diaChi;
            this._soDT = soDT;
            this._luongCB = luongCB;
        }
        
        public abstract double TinhLuong();

        public virtual string toString()
        {
            string result = $"\tMã nhân viên : {this._maNV}\n";
            result += $"\tTên nhân viên : {this._hoTen}\n";
            result += $"\tNgày sinh : {this._ngaySinh}\n";
            result += $"\tGiới tính : {this._gioiTinh}\n";
            result += $"\tCMND : {this._CMND}\n";
            result += $"\tĐịa chỉ : {this._diaChi}\n";
            result += $"\tSố điện thoại : {this._soDT}\n";
            result += $"\tLương cơ bản : {this._luongCB}đ\n";
            return result;
        }
    }
}
