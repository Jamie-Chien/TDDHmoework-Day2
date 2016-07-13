using PotterCart;
using System;
using System.Collections.Generic;

namespace PotterCartTest
{
    class Cart
    {
        private List<Book> Books;

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
            return 100;
        }
    }
}