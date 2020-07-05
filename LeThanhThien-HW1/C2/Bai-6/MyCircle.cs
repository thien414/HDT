using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeThanhThien_CH2_bt6
{
    class MyCircle
    {
        private MyPoint center;
        private int radius;

        public int Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        internal MyPoint Center
        {
            get
            {
                return center;
            }

            set
            {
                center = value;
            }
        }

        public MyCircle()
        {
            this.center = new MyPoint(0, 0);
            this.radius = 1;
        }

        public MyCircle(MyPoint _center, int _radius)
        {
            this.center = _center;
            this.radius = _radius;
        }

        public double getArea()
        {
            double result = 3.14 * this.radius * this.radius;
            return result;
        }

        public double getCircumference()
        {
            double result = 3.14 * 2 * this.radius;
            return result;
        }

        public double distance(MyCircle another)
        {
            double result = Math.Sqrt(Math.Pow((another.center.X - this.center.X),2) + Math.Pow((another.center.Y - this.center.Y),2));
            return result;
        }

        public string toString()
        {
            string result = "";
            result += $"{this.center.toString()}";
            result += $"Dien tich hinh tron: {getArea()} \nChu vi hinh tron: {getCircumference()}\n";
            return result;
        }
        
    }
}
