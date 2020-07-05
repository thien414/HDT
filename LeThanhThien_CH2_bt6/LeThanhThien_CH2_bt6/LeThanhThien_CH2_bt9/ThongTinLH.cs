using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeThanhThien_CH2_bt9
{
    class ThongTinLH
    {
        private string hoTenNLH;
        private int soDT;
        private string email;
        private DiaChi diaChi;

        public string HoTenNLH
        {
            get
            {
                return hoTenNLH;
            }

            set
            {
                hoTenNLH = value;
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

        public ThongTinLH() { }

        public ThongTinLH(string _hoTen, int _soDT)
        {
            this.hoTenNLH = _hoTen;
            this.soDT = _soDT;
            this.email = "";
            this.diaChi = new DiaChi();
        }

        public ThongTinLH(string _hoTen, int _soDT, string _email, DiaChi _diaChi)
        {
            this.hoTenNLH = _hoTen;
            this.soDT = _soDT;
            this.email = _email;
            this.diaChi = _diaChi;
        }

        public string toString() {
            string result = "Thong tin nguoi co the lien he: \n";
            result += $"\tHo ten : {this.hoTenNLH}\n";
            result += $"\tSo dien thoai : {this.soDT}\n";
            result += $"\tEmail : {this.email}\n";
            result += $"\t{this.diaChi.toString()}\n";
            return result;
        }
    }
}
