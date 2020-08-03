using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b4
{
    abstract class Employee
    {
        private int _empCode;
        private string _firstName;
        private string _lastName;

        public int EmpCode
        {
            get
            {
                return _empCode;
            }

            set
            {
                _empCode = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public Employee()
        {
            this._empCode = 1;
            this._firstName = "";
            this._lastName = "";
        }

        public Employee(int empCode, string firstName, string lastName)
        {
            this._empCode = empCode;
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public abstract double pay();

        public abstract string toString();
    }
}
