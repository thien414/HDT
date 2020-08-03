using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai3
{
    class Circle:Shape
    {
        private double _radius;

        public double Radius
        {
            get
            {
                return _radius;
            }

            set
            {
                _radius = value;
            }
        }

        public Circle()
        {
            this._radius = 1.0;
        }
        public Circle(double radius)
        {
            this._radius = radius;
        }
        public Circle(string color, bool filled, double radius) : base(color, filled)
        {
            this.Color = color;
            this.Filled = filled;
            this._radius = radius;
        }
        public double getRadius()
        {
            return this._radius;
        }
        public void setRadius(double radius)
        {
            this._radius = radius;
        }
        public double getArea()
        {
            double areaCricle = 2 * this._radius * 3.14;
            return areaCricle;
        }

        public double getPerimeter()
        {
            double perCircle = this._radius * this._radius * 3.14;
            return perCircle;
        }

        public override string toString()
        {
            return base.toString()+ $"Circle: \n radius:{this._radius} \n areaCircle = {getArea()} \n perCircle = {getPerimeter()}";
        }


    }
}
