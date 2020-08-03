using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    class NVVanPhong : NhanVien
    {
        private int _soNgayLam;
        private double _phuCap;

        public int SoNgayLam
        {
            get
            {
                return _soNgayLam;
            }

            set
            {
                _soNgayLam = value;
            }
        }

        public double PhuCap
        {
            get
            {
                return _phuCap;
            }

            set
            {
                _phuCap = value;
            }
        }

        public NVVanPhong() : base()
        {

        }
        public NVVanPhong(int soNgayLam, double phuCap, string maNV, string hoTen, DateTime ngaySinh, bool gioiTinh, string CMND, string diaChi, int soDT, double luongCB) : base(maNV, hoTen, ngaySinh, gioiTinh, CMND, diaChi, soDT, luongCB)
        {
            this._phuCap = phuCap;
            this._soNgayLam = soNgayLam;
        }

        public override double TinhLuong()
        {
            return LuongCB + SoNgayLam * 200000 + PhuCap;
        }

        public override string toString()
        {
            return base.toString() + $"\tSố ngày làm : {this._soNgayLam}\n\tPhụ cấp : {this._phuCap}đ\n";
        }
    }
}
