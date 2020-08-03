using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b5
{
    class Money
    {
        private readonly int _dollars;
        private readonly int _cents;

        public int Dollars
        {
            get
            {
                return _dollars;
            }
        }

        public int Cents
        {
            get
            {
                return _cents;
            }
        }

        public Money()
        {
            this._cents = 0;
            this._dollars = 0;
        }

        public Money(int dollars, int cents)
        {
            this._dollars = dollars;
            this._cents = cents;
        }

        public string toString()
        {
            string result = $"{this.Dollars}.{this.Cents}";
            return result;
        }

        public static Money operator +(Money m1,Money m2)
        {
            if(m1.Cents + m2.Cents >= 100)
            {
                Money result = new Money(m1.Dollars + m2.Dollars + 1, m1.Cents + m2.Cents - 100);
                return result;
            }
            else
            {
                Money result = new Money(m1.Dollars + m2.Dollars, m1.Cents + m2.Cents);
                return result;
            }
        }
        public static Money operator -(Money m1, Money m2)
        {
            if(m1.Cents - m2.Cents < 0)
            {
                Money result = new Money(m1.Dollars - m2.Dollars - 1, (m1.Cents - m2.Cents)*-1);
                return result;
            }
            else
            {
                Money result = new Money(m1.Dollars - m2.Dollars, m1.Cents - m2.Cents);
                return result;
            }
        }
    }
}
