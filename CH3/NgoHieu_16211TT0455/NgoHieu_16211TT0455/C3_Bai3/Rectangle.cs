using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai3
{
    class Rectangle:Shape
    {
        private double _width;
        private double _length;

        public double Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        public double Length
        {
            get
            {
                return _length;
            }

            set
            {
                _length = value;
            }
        }

        public Rectangle()
        {
            this._width = 1.0;
            this._length = 1.0;
        }
        public Rectangle(double width, double length)
        {
            this._width = width;
            this._length = length;
        }
        public Rectangle(string color, bool filled, double width, double length) : base(color, filled)
        {
            this.Color = color;
            this.Filled = filled;
            this._width = width;
            this._length = length;
        }

        public double getWidth()
        {
            return this._width;
        }
        public void setWidth(double width)
        {
            this._width = width;
        }

        public double getLength()
        {
            return this._length;
        }
        public void setLength(double length)
        {
            this._length = length;
        }

        public double getArea()

        {
            double areaRec =this._width * this._length;
            return areaRec;
        }
        public double getPerRec()
        {
            double perRec = (this._width + this._length) * 2;
            return perRec;

        }
        public override string toString()
        {
            return base.toString() + $"Rectangle: \n width:{this._width} \n length:{this._length}\n AreaRec :{getArea()}\n perRec: {getPerRec()}" ;
        }


    }
}
