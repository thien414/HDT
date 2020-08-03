using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_bt1
{
    class Circle
    {
        private double radius;
        private string color;

        public double Radius
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

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public Circle()
        {
            this.radius = 1.0;
            this.color = "red";
        }

        public Circle(double _radius)
        {
            this.radius = _radius;
            this.color = "red";
        }

        public Circle(double _radius, string _color)
        {
            this.radius = _radius;
            this.color = _color;
        }

        public void setRadius(double _radius)
        {
            this.radius = _radius;
        }

        public void setColor(string _color)
        {
            this.color = _color;
        }

        public double getArea()
        {
            double result = 0;
            result = this.radius * this.radius * 2;
            return result;
        }

        public string toString()
        {
            string result = $"radius: {this.radius}\tcolor: {this.color}\tArea: {getArea()}\n";
            return result;
        }
    }
}
