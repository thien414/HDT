using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai5
{
    class MonHoc
    {
        //Fields
        private string tenMon;
        private int soTC;
        private double diem;

        public string TenMon
        {
            get
            {
                return tenMon;
            }

            set
            {
                tenMon = value;
            }
        }

        public int SoTC
        {
            get
            {
                return soTC;
            }

            set
            {
                soTC = value;
            }
        }

        public double Diem
        {
            get
            {
                return diem;
            }

            set
            {
                diem = value;
            }
        }

        //Methods
        public MonHoc()
        {
            this.tenMon = "";
            this.soTC = 0;
            this.diem = 0;
        }
        public MonHoc(string tenMon,int soTC,int diem)
        {
            this.tenMon = tenMon;
            this.soTC = soTC;
            this.diem = diem;
        }
        public string print()
        {
            string result = $"\n Ten mon:{this.tenMon} \n So tin chi:{this.soTC} \n Diem:{this.diem}";
            return result;
        }
    }
}
