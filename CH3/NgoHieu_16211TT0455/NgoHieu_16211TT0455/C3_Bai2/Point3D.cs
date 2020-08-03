using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai
{
    class Point3D : Point2D
    {
        private float _z;


        public float Z
        {
            get
            {
                return _z;
            }

            set
            {
                _z = value;
            }
        }

        public Point3D(float x, float y, float z):base(x,y)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;

        }
        public Point3D()
        {
            this._z = 0.0f;
        }

        public float getZ()
        {
            return this._z;
        }
        public void setZ(float z)
        {
            this._z = z;

        }
        public void setXYZ(float x, float y, float z)
         
        {
            this.X = x;
            this.Y = y;
            this._z = z;
        }
        public float[] getXYZ()
        {
            float[] arrXYZ = new float[] {this.X, this.Y,this._z };

            return arrXYZ;
        }

        public override string toString()
        {
            string print;
            print = $"Poit x,y,z:{this.X}.{this.Y}.{this._z}";
            return print;
        }

    }
}
