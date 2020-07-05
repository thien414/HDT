using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeThanhThien_CH2_Cau4
{
    class Program
    {
        static void Main(string[] args)
        {
            Author authorA = new Author("hieu", 'm', new DateTime(1990,5,14), "hieu@gmail.com");
            Author authorB = new Author("hieu", 'm', new DateTime(1950,5,14), "hieu@gmail.com");

            Book[] book = new Book[2];
            book[0] = new Book("truyen kieu", new Author[] { authorA }, 150.500, 1992);
            book[1] = new Book("tieu thuyet", new Author[] { authorA, authorB }, 10.500, 1995);

            foreach(Book i in book)
            {
                Console.WriteLine(i.printToString() + "\n\n\n");
            }

            Console.ReadKey();

        }
    }
}
