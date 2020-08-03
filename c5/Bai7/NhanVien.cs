using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai7
{
    class NhanVien
    {
        private NgaySinh _birthDay;
        private string _name;
        private string _adrres;

       
        internal NgaySinh BirthDay
        {
            get
            {
                return _birthDay;
            }

            set
            {
                _birthDay = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Adrres
        {
            get
            {
                return _adrres;
            }

            set
            {
                _adrres = value;
            }
        }
        public NhanVien()
        {
            this._name = "";
            this._adrres = "";
        }
        public NhanVien(NgaySinh birthDay, string name, string adrres)
        {
            this._birthDay = birthDay;
            this._name = name;
            this._adrres = adrres;
        }

        public virtual string toString()
        {
            string print = $"Ho ten:{Name} \t Ngay sinh:{BirthDay} \t Dia chi:{Adrres}\n";
            return print;
        }

    }
}
