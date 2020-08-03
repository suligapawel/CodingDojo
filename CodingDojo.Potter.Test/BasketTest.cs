using CodingDojo.Potter.Main;
using NUnit.Framework;

namespace CodingDojo.Potter.Test
{
    public class Tests
    {
        private Basket _basket;

        [SetUp]
        public void Setup()
        {
            _basket = new Basket();
        }

        [Test]
        public void When_BuyOneCopyOfBook_return_8euro()
        {
            _basket.InsertBook(new Book(1));

            int cost = _basket.Buy();

            Assert.That(cost, Is.EqualTo(8));
        }

        [Test]
        public void When_BuyTwoCopyOfSameBook_return_16euro()
        {
            _basket.InsertBook(new Book(1));
            _basket.InsertBook(new Book(1));

            int cost = _basket.Buy();

            Assert.That(cost, Is.EqualTo(16));
        }
    }
}