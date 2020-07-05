using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeThanhThien_16211TT0473
{
    class Money
    {
        private int dollar;
        private int cent;

        public int Dollar
        {
            get
            {
                return dollar;
            }

            set
            {
                dollar = value;
            }
        }

        public int Cent
        {
            get
            {
                return cent;
            }

            set
            {
                cent = value;
            }
        }

        public Money()
        {
            this.dollar = 0;
            this.cent = 0;
        }

        public Money(int _dollar, int _cent)
        {
            this.cent = _cent;
            this.dollar = _dollar;
        }

        public int getDollar()
        {
            return this.dollar;
        }

        public int getCent()
        {
            return this.cent;
        }

        public void setDollar(int _dollar)
        {
            this.dollar = _dollar;
        }

        public void setCent(int _cent)
        {
            this.cent = _cent;
        }

        public double getValue()
        {
            string txt = $"{this.dollar}.{this.cent}";
            double result = Double.Parse(txt);
            return result;
        }

        public string toString()
        {
            string result = "";
            result = $"Money : {this.dollar}${this.cent}";
            return result;
        }
    }
}
