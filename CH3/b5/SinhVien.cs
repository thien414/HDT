using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai5
{
    class SinhVien:Lop
    {
        //Fields
        private string maSV;
        private string tenSV;
        private MonHoc[] mHoc;

        public string MaSV
        {
            get
            {
                return maSV;
            }

            set
            {
                maSV = value;
            }
        }

        public string TenSV
        {
            get
            {
                return tenSV;
            }

            set
            {
                tenSV = value;
            }
        }

        internal MonHoc[] MHoc
        {
            get
            {
                return mHoc;
            }

            set
            {
                mHoc = value;
            }
        }

        //Methods
        public SinhVien():base()
        {
            this.maSV = "";
            this.tenSV = "";
            this.MHoc = new MonHoc[0];
        }
        public SinhVien(string maSV,string tenSV,MonHoc[] mH,string tenLop,string khoa):base(tenLop,khoa)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.MHoc = mH;
        }  
        public void printMonHoc()
        {
            for(int i=0;i<mHoc.Length;i++)
            {
                Console.WriteLine("\nThong tin mon hoc {0}", i + 1);
                Console.WriteLine(mHoc[i].print());
            }
        }
        public override string toString()
        {
            return $"\n Ho ten:{this.tenSV} \n Ma SV:{this.maSV} "+base.toString();
        }
    }
}
