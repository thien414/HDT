using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai7
{
    class NhanVienCN:NhanVien,ILuong
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
            this._ngayLam = 1;
        }
        public NhanVienCN(int ngayLam, NgaySinh birthDay, string name, string adrres) : base( birthDay,  name,  adrres)
        {
            this._ngayLam = ngayLam;
        }
        public double luong()
        {
            double tinhLuong = this._ngayLam * 40000;
            return tinhLuong;
        }
        public override string toString()
        {
            return base.toString() + $"San Pham:{NgayLam}\t Luong: {luong()}";
        }
    }
}
