using PotterCart;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterCartTest
{
    public class Cart
    {
        private List<Book> Books;
        private readonly double[] discountTable = new double[] { 1, 0.95, 0.9, 0.8, 0.75 };
        private readonly int priceOfBook = 100;

        public Cart()
        {
            Books = new List<Book>();
        }

        public void Add(Book book)
        {
            Books.Add(book);
        }

        public int GetPrice()
        {
            return CalculatePrice(Books, 0);
        }

        private int CalculatePrice(List<Book> books, int price)
        {
            if (books.Count > 0)
            {
                var groupedBooks = books.Distinct(x => x.Volume).ToList();

                var discount = discountTable[groupedBooks.Count - 1];

                int groupedPice = Convert.ToInt32(groupedBooks.Count * priceOfBook * discount);

                var notCheckoutBooks = books.Where(x => !groupedBooks.Contains(x)).ToList();

                return groupedPice + CalculatePrice(notCheckoutBooks, price);
            }
            return price;
        }
    }
}