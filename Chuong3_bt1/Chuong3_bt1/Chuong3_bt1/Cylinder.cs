using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_bt1
{
    class Cylinder : Circle
    {
        private double height;

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public Cylinder()
        {
            this.height = 1.0;
        }

        public Cylinder(double _radius,double _height)
        {
            this.Radius = _radius;
            this.height = _height;
        }

        public Cylinder(double _radius, double _height, string _color)
        {
            this.Radius = _radius;
            this.Color = _color;
            this.height = _height;
        }

        public void setHeight(double _height)
        {
            this.height = _height;
        }

        public double getVolume()
        {
            double result = this.height * 3.14 * this.Radius * this.Radius;
            return result;
        }

    }
}
