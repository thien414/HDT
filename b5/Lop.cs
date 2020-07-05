using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai5
{
    class Lop
    {
        //Fields
        private string tenLop;
        private string khoa;

        public string TenLop
        {
            get
            {
                return tenLop;
            }

            set
            {
                tenLop = value;
            }
        }

        public string Khoa
        {
            get
            {
                return khoa;
            }

            set
            {
                khoa = value;
            }
        }

        //Methods
        public Lop()
        {
            this.tenLop = "";
            this.khoa = "";
        }
        public Lop(string tenLop,string khoa)
        {
            this.tenLop = tenLop;
            this.khoa = khoa;
        }
        ~Lop()
        {
            Console.WriteLine("lop {0} xin chao", this.tenLop);
        }
      
        public virtual string toString()
        {
            string info = $"\n Ten lop:{this.tenLop} \n Khoa:{this.khoa}";
            return info;
        }
    }
}
