using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeThanhThien_CH2_bt9
{
    class KHDoanhNghiep
    {
        private string tenCTy;
        private int soDT;
        private DateTime ngayTL;
        private DiaChi diaChi;
        private ThongTinLH thongTLH;

        public string TenCTy
        {
            get
            {
                return tenCTy;
            }

            set
            {
                tenCTy = value;
            }
        }

        public int SoDT
        {
            get
            {
                return soDT;
            }

            set
            {
                soDT = value;
            }
        }

        public DateTime NgayTL
        {
            get
            {
                return ngayTL;
            }

            set
            {
                ngayTL = value;
            }
        }

        internal DiaChi DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        internal ThongTinLH ThongTLH
        {
            get
            {
                return thongTLH;
            }

            set
            {
                thongTLH = value;
            }
        }

        public KHDoanhNghiep() {
            this.tenCTy = "";
            this.soDT = 0;
            this.ngayTL = new DateTime();
            this.diaChi = _diaChi;
            this.thongTLH = _ttlh;
        }

        public KHDoanhNghiep(string _tenCTy, int _soDT, DateTime _ngayTL, DiaChi _diaChi, ThongTinLH _ttlh) {
            this.tenCTy = _tenCTy;
            this.soDT = _soDT;
            this.ngayTL = _ngayTL;
            this.diaChi = _diaChi;
            this.thongTLH = _ttlh;
        }
    }
}
