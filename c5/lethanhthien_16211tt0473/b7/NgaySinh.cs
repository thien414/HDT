using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH5
{
    class NgaySinh
    {
        private int _day;
        private int _month;
        private int _year;
        
        public int Day
        {
            get
            {
                return _day;
            }

            set
            {
                _day = value;
            }
        }

        public int Month
        {
            get
            {
                return _month;
            }

            set
            {
                _month = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }

            set
            {
                _year = value;
            }
        }

        ~NgaySinh() { }

        public NgaySinh() { }

        public NgaySinh(int _day, int _month, int _year)
        {
            this._day = _day;
            this._month = _month;
            this._year = _year;
        }

        public string toString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
