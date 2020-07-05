using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B1
{
    class PhanSo
    {
        private readonly int _tuSo;
        private readonly int _mauSo;

        public int getTuSo()
        {
            return this._tuSo;
        }
        public int getMauSo()
        {
            return this._mauSo;
        }

        public PhanSo()
        {
            this._tuSo = 1;
            this._mauSo = 1;
        }
        public PhanSo(int x, int y)
        {
            this._tuSo = x;
            if(y != 0)
            {
                this._mauSo = y;
            }
            else
            {
                Console.WriteLine("nhap sai mau so !!!");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        ~PhanSo()
        {
            Console.WriteLine("{0} tam biet",toString());
        }

        public PhanSo rutGonPS()
        {
            int j, i, ucln = 1;
            PhanSo xy;
            j = (_tuSo < _mauSo) ? _tuSo : _mauSo;
            for(i = 1; i <= j; i++)
            {
                if (_tuSo % i == 0 && _mauSo % i == 0)
                {
                    ucln = i;
                }
            }
            xy = new PhanSo(_tuSo / ucln, _mauSo / ucln);
            return xy;
        }

        public PhanSo getTong(PhanSo ps)
        {
            PhanSo xy = new PhanSo(_tuSo * ps._mauSo + _mauSo * ps._tuSo, _mauSo * ps._mauSo);
            return xy;
        }

        public PhanSo getHieu(PhanSo ps)
        {
            PhanSo xy = new PhanSo(_tuSo * ps._mauSo - _mauSo * ps._tuSo, _mauSo * ps._mauSo);
            return xy;
        }

        public PhanSo getTich(PhanSo ps)
        {
            PhanSo xy = new PhanSo(_tuSo * ps._tuSo, _mauSo * ps._mauSo);
            return xy;
        }

        public PhanSo getThuong(PhanSo ps)
        {
            PhanSo xy = new PhanSo(_tuSo * ps._mauSo, _mauSo * ps._tuSo);
            return xy;
        }

        public string toString()
        {
            return $" { _tuSo} / {_mauSo} ";
        }

        public static PhanSo operator +(PhanSo ps1)
        {
            PhanSo ps = new PhanSo(ps1._tuSo + ps1._mauSo , ps1._mauSo);
            PhanSo ps3 = ps.rutGonPS();
            return ps3;
        }

        public static PhanSo operator -(PhanSo ps1)
        {
            PhanSo ps = new PhanSo(ps1._tuSo - ps1._mauSo, ps1._mauSo);
            PhanSo ps3 = ps.rutGonPS();
            return ps3;
        }
        public static PhanSo operator + (PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps = new PhanSo(ps1._tuSo * ps2._mauSo + ps1._mauSo * ps2._tuSo, ps1._mauSo * ps2._mauSo);
            PhanSo ps3 = ps.rutGonPS();
            return ps3;
        }
        public static PhanSo operator - (PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps = new PhanSo(ps1._tuSo * ps2._mauSo - ps1._mauSo * ps2._tuSo, ps1._mauSo * ps2._mauSo);
            PhanSo ps3 = ps.rutGonPS();
            return ps3;
        }
        public static PhanSo operator * (PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps = new PhanSo(ps1._tuSo * ps2._tuSo, ps1._mauSo * ps2._mauSo);
            PhanSo ps3 = ps.rutGonPS();
            return ps3;
        }
        public static PhanSo operator / (PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps = new PhanSo(ps1._tuSo * ps2._mauSo, ps1._mauSo * ps2._tuSo);
            PhanSo ps3 = ps.rutGonPS();
            return ps3;
        }

        public static bool operator == (PhanSo ps1, PhanSo ps2)
        {
            if(ps1._tuSo * ps2._mauSo == ps1._mauSo * ps2._tuSo)
            {
                return true;
            }
            return false;
        }

        public static bool operator != (PhanSo ps1, PhanSo ps2)
        {
            if (ps1._tuSo * ps2._mauSo != ps1._mauSo * ps2._tuSo)
            {
                return true;
            }
            return false;
        }

        public static bool operator > (PhanSo ps1, PhanSo ps2)
        {
            if (ps1._tuSo * ps2._mauSo > ps1._mauSo * ps2._tuSo)
            {
                return true;
            }
            return false;
        }

        public static bool operator < (PhanSo ps1, PhanSo ps2)
        {
            if (ps1._tuSo * ps2._mauSo < ps1._mauSo * ps2._tuSo)
            {
                return true;
            }
            return false;
        }
        public static bool operator >= (PhanSo ps1, PhanSo ps2)
        {
            if (ps1._tuSo * ps2._mauSo != ps1._mauSo * ps2._tuSo)
            {
                return true;
            }
            return false;
        }
        public static bool operator <= (PhanSo ps1, PhanSo ps2)
        {
            if (ps1._tuSo * ps2._mauSo != ps1._mauSo * ps2._tuSo)
            {
                return true;
            }
            return false;
        }
    }
}
