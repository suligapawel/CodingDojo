using System.Collections.Generic;
using System.Linq;

namespace CodingDojo.Potter.Main
{
    public class Basket
    {
        private readonly List<List<Book>> _groupedUniqueBooks;

        public Basket()
        {
            _groupedUniqueBooks = new List<List<Book>>
            {
                new List<Book>()
            };
        }

        public void PutBook(Book book)
        {
            bool isBookUniqueInAllGroupedBooks = _groupedUniqueBooks
                .All(x => x.Any(y => y.Equals(book)));

            if (isBookUniqueInAllGroupedBooks)
            {
                AddNewGroupedUniqueBooks(book);
                return;
            }

            foreach (var uniqueBooks in _groupedUniqueBooks)
            {
                bool isNotUniqueBook = uniqueBooks.Contains(book);
                if (isNotUniqueBook)
                    continue;

                uniqueBooks.Add(book);
            }
        }

        private void AddNewGroupedUniqueBooks(Book book)
        {
            _groupedUniqueBooks.Add(new List<Book> { book });
        }

        public decimal Buy()
        {
            decimal priceSum = 0;

            foreach (var bookGroupedByPart in _groupedUniqueBooks)
            {
                decimal price = bookGroupedByPart.Count * 8;
                decimal priceDiscount = price * GetDiscount(bookGroupedByPart);

                priceSum += price - priceDiscount;
            }

            return priceSum;
        }

        private static decimal GetDiscount(List<Book> bookGroupedByPart)
        {
            return bookGroupedByPart.Count switch
            {
                1 => 0M,
                2 => 0.05M,
                3 => 0.1M,
                4 => 0.2M,
                5 => 0.25M
            };
        }
    }
}
