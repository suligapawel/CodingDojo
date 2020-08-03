using System.Collections.Generic;

namespace CodingDojo.Potter.Main
{
    public class Basket
    {
        private readonly List<Book> _booksInBasket;

        public Basket()
        {
            _booksInBasket = new List<Book>();
        }

        public void InsertBook(Book book)
        {
            _booksInBasket.Add(book);
        }

        public int Buy()
        {
            return _booksInBasket.Count * 8;
        }
    }
}
