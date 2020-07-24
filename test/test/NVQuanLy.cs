using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class NVQuanLy : NhanVien
    {
        private double _phuCap;

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

        public NVQuanLy() : base()
        {

        }

        public NVQuanLy(double phuCap, string maNV, string hoTen, DateTime ngaySinh, bool gioiTinh, string CMND, string diaChi, int soDT, double luongCB) : base(maNV, hoTen, ngaySinh, gioiTinh, CMND, diaChi, soDT, luongCB)
        {
            this._phuCap = phuCap;
        }

        public override double TinhLuong()
        {
            return LuongCB + PhuCap;
        }

        public override string toString()
        {
            return base.toString() + $"\tPhụ cấp : {this._phuCap}đ\n";
        }

    }
}
