using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace btThem
{
    class ThoiHan : SoTietKiem
    {
        private int _soThangGui;

        public int SoThangGui
        {
            get
            {
                return _soThangGui;
            }

            set
            {
                _soThangGui = value;
            }
        }

        public ThoiHan() : base() { }

        public ThoiHan(int soThangGui, string CMND, string hoTen, double sotien, DateTime ngayLapSo, double laiXuat) : base(CMND, hoTen, sotien, ngayLapSo, laiXuat)
        {
            this._soThangGui = soThangGui;  
        }

        public override double TienLai()
        {
            double result = 0;
            if (DateTime.Now.Month - this.NgayLapSo.Month > this._soThangGui)
            {
                result = this.SoTien * this.LaiXuat * this._soThangGui;
            }
            return result;
        }

        public override string toString()
        {
            return base.toString() + $"\nSo Thang Gui : {this._soThangGui}";
        }
    }
}
