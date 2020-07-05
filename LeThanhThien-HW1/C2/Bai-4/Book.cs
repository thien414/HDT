using System;
using System.Collections.Generic;
using System.Text;

namespace LeThanhThien_CH2_bt4
{
    class Book
    {
        //field
        private string bookName;
        private Author author;
        private double price;
        private int qty;

        //properities

        public string BookName
        {
            get
            {
                return bookName;
            }

            set
            {
                bookName = value;
            }
        }

        public Author Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Qty
        {
            get
            {
                return qty;
            }

            set
            {
                qty = value;
            }
        }

        //methods

        public void setAuthor(Author author)
        {
            this.author = author;
        }
        public Author getAuthor()
        {
            return author;
        }


        //constructor
        public Book(string bName, Author author, double _price)
        {
            this.bookName = bName;
            this.author = author;
            this.price = _price;
        }

        public Book(string bName, Author author, double _price, int _qty)
        {
            this.bookName = bName;
            this.author = author;
            this.price = _price;
            this.qty = _qty;
        }

        /// <summary>
        /// Xuat
        /// </summary>
        /// <returns></returns>
        public string printToString()
        {
            string result = "";
            result += this.author.printInfo() + "\n";
            string ifor = $"{this.bookName}:\n{result}\n{this.price}$\n{this.qty}";
            return ifor;
        }
    }
}
