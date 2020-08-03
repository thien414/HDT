using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai3
{
    class Shape
    {
        private string _color;
        private bool _filled;

        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public bool Filled
        {
            get
            {
                return _filled;
            }

            set
            {
                _filled = value;
            }
        }

        public Shape()
        {
            this._color = "red";
            this._filled = true;
        }

        public Shape(string color, bool filled)
        {
            this._color = color;
            this._filled = filled;
        }
        public string getColor()
        {
            return this._color;
        }
        public void setColor(string color)
        {
            this._color = color;
        }
        public bool isFilled()
        {
            return this._filled;
        }
        public void setFilled(bool filled)
        {
            this._filled = filled;
        }
        public virtual string toString()
        {
            string print;
            print = $"Shape: {this._color},{this._filled}";
            return print;
        }
    }
}
