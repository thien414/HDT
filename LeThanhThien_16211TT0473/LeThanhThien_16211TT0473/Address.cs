using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeThanhThien_16211TT0473
{
    class Address
    {
        private string street;
        private string ward;
        private string city;

        public string Street
        {
            get
            {
                return street;
            }

            set
            {
                street = value;
            }
        }

        public string Ward
        {
            get
            {
                return ward;
            }

            set
            {
                ward = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public Address(string _street, string _ward, string _city)
        {
            this.city = _city;
            this.street = _street;
            this.ward = _ward;
        }

        public string toString()
        {
            string result = "";
            result += $"Address:\n\tstreet: {this.street}.\n\tward: {this.ward}.\n\tcity: {this.city}.";
            return result;
        }
    }
}
