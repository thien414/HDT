using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai7
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
        public NgaySinh()
        {
            this._day = 1;
            this._month = 1;
            this._year = 1990;
        }
        public NgaySinh(int day, int month, int year)
        {
            this._day = day;
            this._month = month;
            this._year = year;
        }

        public string toString()
        {
            string print = $"{Day}-{Month}-{Year}";
            return print;
        }
    }
}
