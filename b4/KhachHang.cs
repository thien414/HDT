using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b5
{
    class KhachHang
    {
        //Fields
        private string hoTen;
        private int soNha;
        private string maSoCongTo;

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

        public int SoNha
        {
            get
            {
                return soNha;
            }

            set
            {
                soNha = value;
            }
        }

        public string MaSoCongTo
        {
            get
            {
                return maSoCongTo;
            }

            set
            {
                maSoCongTo = value;
            }
        }

        //methods
        public KhachHang()
        {
            this.hoTen = "";
            this.soNha = 0;
            this.maSoCongTo = "";
        }
        public KhachHang(string hoTen, int soNha, string maSoCongTo)
        {
            this.hoTen = hoTen;
            this.soNha = soNha;
            this.maSoCongTo = maSoCongTo;
        }
        public virtual string toString()
        {
            string info = $"\n Ho ten chu ho:{this.hoTen} \n So nha:{this.soNha} \n Ma so cong to:{this.maSoCongTo}";
            return info;
        }
    }
}
