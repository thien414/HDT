using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b5
{
    class BienLai:KhachHang
    {
        //Fields
        private int chiSoCu;
        private int chiSoMoi;

        public int ChiSoCu
        {
            get
            {
                return chiSoCu;
            }

            set
            {
                chiSoCu = value;
            }
        }

        public int ChiSoMoi
        {
            get
            {
                return chiSoMoi;
            }

            set
            {
                chiSoMoi = value;
            }
        }

        //Methods
        public BienLai() : base()
        {
            this.chiSoCu = 0;
            this.chiSoMoi = 0;
        }
        public BienLai(int chiSoCu, int chiSoMoi, string hoTen, int soNha, string maSoCongTo) : base(hoTen, soNha, maSoCongTo)
        {
            this.chiSoCu = chiSoCu;
            this.chiSoMoi = chiSoMoi;
        }
        public int tinhTienDien()
        {
            int money = 0;
            money = (this.chiSoMoi - this.chiSoCu) * 750;
            return money;
        }
        
        public override string toString()
        {
            return base.toString() + $"\n Chi so cu:{this.chiSoCu} \n Chi so moi:{this.chiSoMoi} \n So tien dien phai tra cua ho:{tinhTienDien()}";
        }
    }
}
