using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[] temp = new int[n];
            int[] temp1 = new int[n];
            Console.WriteLine("Nhap vao mang: ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap vao phan tu thu {0} :", i + 1);
                temp[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nhap vao mang: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap vao phan tu thu {0} :", i + 1);
                temp1[i] = int.Parse(Console.ReadLine());
            }


            MyArray arr1 = new MyArray(temp);
            MyArray arr2 = new MyArray(temp1);
            Console.WriteLine("Mang vua nhap la:\n arr1: [{0}] \n arr1: [{1}] ", arr1.toString(), arr2.toString());
            
            Console.WriteLine("\nMang sau khi cong: arr1 + arr2 = [{0}]", (arr1 + arr2).toString());

            Console.ReadKey();
        }
    }
}
