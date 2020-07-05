using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeThanhThien_CH2_bt9
{
    class DiaChi
    {
        private string soNha;
        private string tenDuong;
        private string tenQuan;
        private string tenThanhPho;

        public string SoNha
        {
            get
            {
                return soNha;
            }

            set
            {
                soNha = value;
            }
        }

        public string TenDuong
        {
            get
            {
                return tenDuong;
            }

            set
            {
                tenDuong = value;
            }
        }

        public string TenQuan
        {
            get
            {
                return tenQuan;
            }

            set
            {
                tenQuan = value;
            }
        }

        public string TenThanhPho
        {
            get
            {
                return tenThanhPho;
            }

            set
            {
                tenThanhPho = value;
            }
        }

        public DiaChi() { }

        public DiaChi(string _soNha, string _tenDuong, string _tenQuan, string _tenThanhPho) {
            this.soNha = _soNha;
            this.tenDuong = _tenDuong;
            this.tenQuan = _tenQuan;
            this.tenThanhPho = _tenThanhPho;
        }

        public string toString() {
            string result = $"Dia Chi: {this.soNha} {this.tenDuong}, {this.tenQuan}, {this.tenThanhPho}.";
            return result;
        }
    }
}
