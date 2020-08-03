using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai3
{
    class Square:Rectangle
    {
        private double _side;

        public double Side
        {
            get
            {
                return _side;
            }

            set
            {
                _side = value;
            }
        }
        public Square():base()
        {
            this._side = 1.0;
        }
        public Square(double side)
        {
            this._side= side;
        }
        public Square(string color, bool filled, double width, double length, double side) : base(color, filled, width,length)
        {
            this._side = side;
        }

        public double getSide()
        {
            return this._side;
        }
        public void setSide(double side)
        {
            this._side = side;
        }
        public void setWidth(double side)
        {
            this._side = side;
        }
        public void setLength(double side)
        {
            this._side = side;
        }
        public override string toString()
        {
            return base.toString() + $"\n Side: {this._side}";
        }
    }
}
