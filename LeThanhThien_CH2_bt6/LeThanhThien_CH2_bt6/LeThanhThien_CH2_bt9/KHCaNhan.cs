using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeThanhThien_CH2_bt9
{
    class KHCaNhan
    {
        private string hoTen;
        private int soDT;
        private string email;
        private DiaChi diaChi;
        private ThongTinLH thongTinLH;
        private DateTime ngaySinh;

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
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

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
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

        internal ThongTinLH ThongTinLH
        {
            get
            {
                return thongTinLH;
            }

            set
            {
                thongTinLH = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public KHCaNhan() { }

        public KHCaNhan(string _hoTen, int _soDT, string _email, DiaChi _diaChi, ThongTinLH _ttlh, DateTime _ngaySinh) {
            this.hoTen = _hoTen;
            this.soDT = _soDT;
            this.email = _email;
            this.diaChi = _diaChi;
            this.thongTinLH = _ttlh;
            this.ngaySinh = _ngaySinh;
        }

        public string toString() {
            string result = "Thong tin khach hang :\n";
            result += $"Ten khach hang ca nhan: {this.hoTen}\n";
            result += $"So dien thoai : {this.soDT}\n";
            result += $"Email : {this.email}\n";
            result += $"{this.diaChi.toString()}\n";
            result += $"{this.thongTinLH.toString()}\n";
            result += "----------------------------------------------------------\n";
            return result;
        }
    }
}
