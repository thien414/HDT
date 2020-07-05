using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeThanhThien_16211TT0473
{
    class Person
    {
        private string firstName;
        private string lastName;
        private Address address;
        static int countOfPerson;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        internal Address Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public static int CountOfPerson
        {
            get
            {
                return countOfPerson;
            }

            set
            {
                countOfPerson = value;
            }
        }

        public Person(string _firstName, string _lastName, Address _address)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.address = _address;
            countOfPerson += 1;
        }

        public string getFirstName()
        {
            return this.firstName;
        }
        
        public string getLastName()
        {
            return this.lastName;
        }

        public void setHome(string _street, string _ward, string _city)
        {
            this.address.City = _city;
            this.address.Street = _street;
            this.address.Ward = _ward;
        }

        public string toString()
        {
            string result = "";
            result += $"Person:\n\tFirstName: {this.firstName}.\n\tLastName: {this.lastName}.\n\t{this.address.toString()}";
            return result;
        }
    }
}
