using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeThanhThien_CH2_bt7
{
    class SinhVien
    {
        private string hoTen;
        private string lop;
        private double dtb;

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

        public string Lop
        {
            get
            {
                return lop;
            }

            set
            {
                lop = value;
            }
        }

        public double Dtb
        {
            get
            {
                return dtb;
            }

            set
            {
                dtb = value;
            }
        }

        public SinhVien() { }

        public SinhVien(string _hoTen, string _lop, double _dtb)
        {
            this.hoTen = _hoTen;
            this.lop = _lop;
            this.dtb = _dtb;
        }

        public string xepLoai()
        {
            string result = "";
            if (this.dtb > 8.5)
                result = $"{this.hoTen} ({this.dtb}): Gioi\n";
            else if (this.dtb >= 7)
                result = $"{this.hoTen} ({this.dtb}): Kha\n";
            else if (this.dtb >= 5)
                result = $"{this.hoTen} ({this.dtb}): Trung binh\n";
            else
                result = $"{this.hoTen} ({this.dtb}): Yeu\n";
            return result;
        }
    }
}
