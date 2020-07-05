using System;

namespace LeThanhThien_CH2_bt2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khoi tao mot intance cua lop Time
            Time timea = new Time();

            //in thong tin len man Console
            Console.Write(timea.printTime());

            Console.ReadKey();
        }
    }
}
