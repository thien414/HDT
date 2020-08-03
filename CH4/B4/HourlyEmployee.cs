using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b4
{
    class HourlyEmployee : Employee
    {
        private double rate;
        private double workingHours;

        public double Rate
        {
            get
            {
                return rate;
            }

            set
            {
                rate = value;
            }
        }

        public double WorkingHours
        {
            get
            {
                return workingHours;
            }

            set
            {
                workingHours = value;
            }
        }

        public HourlyEmployee():base()
        {
            this.rate = 0;
            this.workingHours = 0;
        }

        public HourlyEmployee(double _rate, double _workingHours,int empCode, string firstName, string lastName):base(empCode, firstName, lastName)
        {
            this.workingHours = _workingHours;
            this.rate = _rate;
        }

        public override double pay()
        {
            double result = this.rate * this.workingHours;
            return result;

        }

        public override string toString()
        {
            string result = $"{this.FirstName} {this.LastName} : {this.WorkingHours},{this.Rate}";
            return result;
        }
    }
}
