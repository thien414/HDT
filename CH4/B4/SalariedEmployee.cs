using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b4
{
    class SalariedEmployee : Employee
    {
        private double _commisionRate;
        private double _grossSales;
        private double _basic;

        public double CommisionRate
        {
            get
            {
                return _commisionRate;
            }

            set
            {
                _commisionRate = value;
            }
        }

        public double GrossSales
        {
            get
            {
                return _grossSales;
            }

            set
            {
                _grossSales = value;
            }
        }

        public double Basic
        {
            get
            {
                return _basic;
            }

            set
            {
                _basic = value;
            }
        }

        public SalariedEmployee():base()
        {
            this._basic = 0;
            this._commisionRate = 0;
            this._grossSales = 0;
        }
        public SalariedEmployee(double commisionRate, double grossSales, double basic, int empCode, string firstName, string lastName) : base(empCode, firstName, lastName)
        {
            this._basic = basic;
            this._commisionRate = commisionRate;
            this._grossSales = grossSales;
        }

        public override double pay()
        {
            double result = this._basic + this._commisionRate * this._grossSales;
            return result;
        }

        public override string toString()
        {
            string result = $"{this.FirstName} {this.LastName} : {this.Basic},{this.CommisionRate},{this.GrossSales}";
            return result;
        }
    }
}
