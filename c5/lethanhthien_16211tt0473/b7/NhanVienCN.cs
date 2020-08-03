using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH5
{
    class NhanVienCN : NhanVien, INhanVien
    {
        private int _ngayLam;

        public int NgayLam
        {
            get
            {
                return _ngayLam;
            }

            set
            {
                _ngayLam = value;
            }
        }

        public NhanVienCN() : base()
        {
        }
        public NhanVienCN(int ngayLam, NgaySinh ngaySinh, string name, string adrres) : base(name, ngaySinh, adrres)
        {
            this._ngayLam = ngayLam;
        }
        public double Luong()
        {
            double tinhLuong = this._ngayLam * 40000;
            return tinhLuong;
        }
        public override string toString()
        {
            return base.toString() + $"San Pham:{NgayLam}\t Luong: {Luong()}";
        }
    }
}
