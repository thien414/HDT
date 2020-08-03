using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai1
{
    class Point:Movable
    {
        private int _x;
        private int _y;
        private int _xSpeed;
        private int _ySpeed;

        internal int X
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

        internal int Y
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

        internal int XSpeed
        {
            get
            {
                return _xSpeed;
            }

            set
            {
                _xSpeed = value;
            }
        }

        internal int YSpeed
        {
            get
            {
                return _ySpeed;
            }

            set
            {
                _ySpeed = value;
            }
        }
        public Point(int x, int y , int xSpeed, int ySpeed)
        {
            this._x = x;
            this._y = y;
            this._xSpeed=xSpeed;
            this._ySpeed = ySpeed;

        }
        public string toString()
        {
            string print = $"";
            return print;
        }

        public void moveUp()
        {
            
        }
        public void moveDow()
        {

        }
        public void moveRight()
        {

        }

        public void moveLeft()
        {
           
        }
    }
}
