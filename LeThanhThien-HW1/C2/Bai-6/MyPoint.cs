using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeThanhThien_CH2_bt6
{
    class MyPoint
    {
        //fields
        private int x;
        private int y;

        //Properities
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        //method
        public MyPoint() {
        }

        public MyPoint(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public string toString() {
            string result = $"\tX = {this.x} \tY = {this.y}\n";
            return result;
        }
    }
}
