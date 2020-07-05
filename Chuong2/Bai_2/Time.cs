using System;
namespace NguyenTruongThinh_Chuong2_Bai2
{
    class Time
    {
        //fields:
        private int hour;
        private int minute;
        private int second;

        //properity:
        public int Hour
        {
            get
            {
                return hour;
            }

            set
            {
                hour = value;
            }
        }

        public int Minute
        {
            get
            {
                return minute;
            }

            set
            {
                minute = value;
            }
        }

        public int Second
        {
            get
            {
                return second;
            }

            set
            {
                second = value;
            }
        }

        //methods:
        public string time()//tao thoi gian
        {
            string time = $"{DateTime.Now.ToString()}";
            return time; 
        }

        public string getNextSecond()// tang them 1 giay
        {
            string nextSecond = $"{ DateTime.Now.AddSeconds(1.0).ToLongTimeString()}";
            return nextSecond;
        }

        public string getPreviousSecond()//giam di 1 giay
        {
            string previousSecond = $"{DateTime.Now.AddSeconds(-1.0).ToLongTimeString()}";
            return previousSecond;
        }

        public string getTimeToString()//ToString()
        {
            string timeToString = $"{DateTime.Now.ToString("hh:mm:ss")}";
            return timeToString;
        }

        public string printTime()
        {
            string result = $"Thoi gian hien tai la: {time()}\nNext Second: {getNextSecond()}\nPrevious Second: {getPreviousSecond()} \nTime To String: {getTimeToString()}";
            return result;
        }

    }
}
