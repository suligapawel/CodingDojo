using System;

namespace CodingDojo.Potter.Main
{
    public class Book
    {
        private readonly int _partOfSeries;

        public Book(int partOfSeries)
        {
            _partOfSeries = partOfSeries;
        }

        public override bool Equals(object obj)
        {
            return obj is Book book &&
                   _partOfSeries == book._partOfSeries;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_partOfSeries);
        }
    }
}
