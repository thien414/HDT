using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace btThem
{
    abstract class SoTietKiem
    {
        private string _CMND;
        private string _hoTenKH;
        private double _soTien;
        private DateTime _ngayLapSo;
        private double _laiXuat;

        public double LaiXuat
        {
            get
            {
                return _laiXuat;
            }

            set
            {
                _laiXuat = value;
            }
        }

        public DateTime NgayLapSo
        {
            get
            {
                return _ngayLapSo;
            }

            set
            {
                _ngayLapSo = value;
            }
        }

        public double SoTien
        {
            get
            {
                return _soTien;
            }

            set
            {
                _soTien = value;
            }
        }

        public string HoTenKH
        {
            get
            {
                return _hoTenKH;
            }

            set
            {
                _hoTenKH = value;
            }
        }

        public string CMND
        {
            get
            {
                return _CMND;
            }

            set
            {
                _CMND = value;
            }
        }

        public SoTietKiem() {
            //this._ngayLapSo.GetDateTimeFormats('dddd/mmmm/yyyy',)
        }
        public SoTietKiem(string CMND, string hoTen, double sotien, DateTime ngayLapSo, double laiXuat)
        {
            this._CMND = CMND;
            this._hoTenKH = hoTen;
            this._laiXuat = laiXuat;
            this._ngayLapSo = ngayLapSo;
            this._soTien = sotien;
        }

        public abstract double TienLai();

        public virtual string toString()
        {
            string result = $"CMND : {this._CMND}\nHo Ten KH : {this._hoTenKH}\nSo Tien Gui : {this._soTien}\nNgay Lap So : {this._ngayLapSo}\nLai Xuat : {this._laiXuat}";
            return result;
        }
    }
}
