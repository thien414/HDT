using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LeThanhThien_CH2_bt4
{
    class Author
    {
        //fields:
        private string name;
        private char gender;
        private DateTime birthday;
        private string email;

        //Properities:
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public char Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        //Properities of BirthDay{private get, set}
        public void setBirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }
        private DateTime getBrithday()
        {
            return this.birthday;
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        //Methods
        public Author()
        {
            this.name = "";
            this.gender = 'u';
            this.birthday = new DateTime(1900, 1, 1);
            this.email = "";
        }
        public Author(string _name, char _gender, DateTime _birhday, string _email)
        {
            this.name = _name;
            if (testGender(_gender) == true)
            {
                this.gender = _gender;
            }
            else
            {
                this.gender = 'u';
            }
            if (_birhday.ToString() == "")
            {
                this.birthday = new DateTime(1900, 1, 1);
            }
            else { this.birthday = _birhday; }

            if (testEmail(_email) == true)
            {
                this.email = _email;
            }
            else
            {
                this.email = null;
            }
        }
        bool testEmail(string str)
        {
            bool test = true;
            string pattern = "^[_A-Za_z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@" + "[_A-Za_z0-9-]+ (\\.[_A-Za_z0-9-]+)*(\\.[A-Za-z]{2,})$";
            Regex emailRegex = new Regex(pattern);
            if (emailRegex.IsMatch(str) == false)
            {
                test = false;
            }
            return test;
        }
        /// <summary>
        /// tra ket qua true neu gender = m,f
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        bool testGender(char ch)
        {
            bool test = false;
            if (ch == 'm' || ch == 'f')
            {
                test = true;
            }
            return test;
        }
        public string genderAuthor()
        {
            char ch = 'u';
            switch (ch)
            {
                case 'm':
                    Console.Write("Nam");
                    break;
                case 'n':
                    Console.Write("Nu");
                    break;
                default:
                    Console.Write("Unknow");
                    break;
            }

            string genderAu = $"{this.name} has gender {testGender(ch)}";
            return genderAu;
        }

        public string genderAuthorEmail()
        {
            string genderAuEmail = $"{genderAuthor()} and email was: {this.email}";
            return genderAuEmail;
        }

        public string authorBirthday()
        {
            string authorBirthday = $"{genderAuthorEmail()} has birthday: {this.birthday}";
            return authorBirthday;
        }
        /// <summary>
        /// tao email bang ten bi luoc bo khoang trang
        /// </summary>
        /// <returns></returns>
        public string creatEmail()
        {
            string email = $"{name.Replace(" ", "").ToLower()}@tdc.edu.vn";
            return email;
        }
        /// <summary>
        /// tinh tuoi
        /// </summary>
        /// <returns></returns>
        public int getAge()
        {
            int age = DateTime.Now.Year - getBrithday().Year;
            return age;
        }

        public string printInfo()
        {

            string sPhai = " ";

            if (this.gender == 'm') { sPhai = "Nam"; }
            else if (this.gender == 'f') { sPhai = "Nu"; }
            else { sPhai = "Unknow"; }

            if (this.email == null) { this.email = this.creatEmail(); }


            string infor = $"{this.name}\t({sPhai} - {getBrithday().Year} {getAge()})\t{this.email}";
            return infor;
        }
    }
}
