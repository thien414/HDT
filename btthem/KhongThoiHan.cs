using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace btThem
{
    class KhongThoiHan : SoTietKiem
    {
        public override double TienLai()
        {
            int n = 0;
            double result;
            int month = DateTime.Now.Month - this.NgayLapSo.Month;
            int year = DateTime.Now.Year - this.NgayLapSo.Year;
            int day = DateTime.Now.Day - this.NgayLapSo.Day;

            if (year >= 1)
            {
                if (month > 0)
                {
                     n += year * 12;
                }
                else
                    {
                    n += (year - 1) * 12;
                }
                
            }
            if (month >= 1)
            {
                if (day >= 0)
                {
                    n += month;
                }
                else
                {
                    n += month - 1;
                }
            }
            result = this.SoTien * this.LaiXuat * n;
            return result;
        }
        public override string toString()
        {
            return base.toString();
        }
    }
}
