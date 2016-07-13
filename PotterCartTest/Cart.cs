using PotterCart;
using System;
using System.Collections.Generic;

namespace PotterCartTest
{
    class Cart
    {
        private List<Book> Books;
        private readonly double[] discountTable = new double[] { 1, 0.95, 0.9, 0.8, 0.75 };

        public Cart()
        {
            Books = new List<Book>();
        }

        internal void Add(Book book)
        {
            Books.Add(book);
        }

        internal int GetPrice()
        {
            return Convert.ToInt32(Books.Count * 100 * discountTable[Books.Count - 1]);
        }
    }
}