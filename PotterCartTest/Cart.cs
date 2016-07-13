using PotterCart;
using System;
using System.Collections.Generic;
using System.Linq;

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
            int price = 0;
            while (Books.Count > 0)
            {
                var groupedBooks = Books.Distinct(x => x.Volume).ToList();
                price += Convert.ToInt32(groupedBooks.Count * 100 * discountTable[groupedBooks.Count - 1]);
                Books.RemoveAll(x => groupedBooks.Contains(x));
            }
            return price;
        }
    }
}