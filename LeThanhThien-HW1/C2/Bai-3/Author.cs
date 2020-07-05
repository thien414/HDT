using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeThanhThien_CH2_bt3
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
            this.birthday = new DateTime(1900,1,1);
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

        //Methods:
        //Constructor co tham so:
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
            this.birthday = _birhday;
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
            if(emailRegex.IsMatch(str) ==false)
            {
                test = false;
            }
            return test;
        }

        bool testGender(char ch)// tra ket qua true neu gender = m,f
        {
            bool test = false;
            if(ch == 'm' || ch == 'f')
            {
                test = true;
            }
            return test;
        }
        public string genderAuthor() // method 1
        {
            char ch = 'u';
            switch(ch)
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

        public string genderAuthorEmail() //method 2
        {
            string genderAuEmail = $"{genderAuthor()} and email was: {this.email}";
            return genderAuEmail;
        }

        public string authorBirthday() //method 3
        {
            string authorBirthday = $"{genderAuthorEmail()} has birthday: {this.birthday}";
            return authorBirthday;
        }

        public string creatEmail() //tao email bang ten bi luoc bo khoang trang
        {
            string email = $"{name.Replace(" ", "").ToLower()}@tdc.edu.vn";
            return email;
        }

        public int getAge()// tinh tuoi
        {
            int age = DateTime.Now.Year - getBrithday().Year;
            return age;
        }

        public string printInfo() //in thong tin tac gia len man Console.
        {
            //khai bao va khoi tao 2 bien de luu tru gia tri chuoi gioi tinh va dia chi email
            string sPhai = " ";

            if (this.gender == 'm') { sPhai = "Nam"; }
            else if (this.gender == 'f') { sPhai = "Nu"; }
            else {sPhai  = "Unknow"; }

            if (this.email == null) { this.email = this.creatEmail(); }

            //khai bao va khoi tao mot bien string de luu tru gia tri kieu string
            string infor = $"{this.name}\t({sPhai} - {getAge()})\t{this.email}";
            return infor;
        }
    }
}
