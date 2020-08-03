using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B2
{
    class MyArray
    {
        private int[] arr;

        public int[] getArr()
        {
            return arr;
        }

        public void setArr(int[] a)
        {
            arr = a;
        }

        public MyArray()
        {
            arr = new int[0];
        }

        public MyArray(int[] _arr)
        {
            arr = _arr;
        }

        public string toString()
        {
            string result = "";
            for (int i = 0; i < arr.Length; i++) 
            {
                result += $"{arr[i]}, ";
            }
            return result;
        }

        public static MyArray operator +(MyArray a)
        {
            for (int i = 0; i < a.arr.Length; i++)
            {
                a.arr[i] += 1;
            }
            return a;
        }

        public static MyArray operator -(MyArray a)
        {
            for (int i = 0; i < a.arr.Length; i++)
            {
                a.arr[i] -= 1;
            }
            return a;
        }

        public static MyArray operator +(MyArray arr, int a)
        {
            for (int i = 0; i < arr.arr.Length; i++) {
                arr.arr[i] += a;
            }
            return arr;
        }

        public static MyArray operator -(MyArray arr, int a)
        {
            for (int i = 0; i < arr.arr.Length; i++)
            {
                arr.arr[i] -= a;
            }
            return arr;
        }

        public static MyArray operator +(MyArray arr, MyArray arr1)
        {
            for (int i = 0; i < arr.arr.Length; i++)
            {
                arr.arr[i] += arr1.arr[i];
            }
            return arr;
        }
    }
}
