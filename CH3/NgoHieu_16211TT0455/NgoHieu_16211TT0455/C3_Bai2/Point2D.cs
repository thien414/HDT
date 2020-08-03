using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai
{
    class Point2D
    {
        private float _x;
        private float _y;

       

        public float X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public float Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }
        public Point2D(float x, float y)
        {
            this._x = x;
            this._y = y;
        }
        public Point2D()
        {
            this._x =0.0f;
            this._y = 0.0f;

        }
        public float getX()
        {
            return this._x;
        }
        public void setX(float x)
        {
            this._x = x;
        }
        public float getY()
        {
            return this._y;
        }
        public void setY(float y)
        {
            this._y = y;
        }

        public void setXY(float x, float y)
        {
            this._x = x;
            this._y = y;
        }

        public float[] getXY()
        {
            float[] arrXY = new float[] { this._x, this._y };

            return arrXY;
        }

        public virtual string toString()
        {
            string print;
            print = $"Poit x,y:{this._x}.{this._y} ";
            return print;
        }
    }
}
