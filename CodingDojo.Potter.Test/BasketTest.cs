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
            _basket.PutBook(new Book(1));

            decimal cost = _basket.Buy();

            Assert.That(cost, Is.EqualTo(8));
        }

        [Test]
        public void When_BuyTwoCopyOfSameBook_return_priceWthoutDiscount()
        {
            _basket.PutBook(new Book(1));
            _basket.PutBook(new Book(1));

            decimal cost = _basket.Buy();

            Assert.That(cost, Is.EqualTo(16));
        }

        [Test]
        public void When_BuyTwoCopyOfOtherBook_return_priceWith5PercentDiscount()
        {
            _basket.PutBook(new Book(1));
            _basket.PutBook(new Book(2));

            decimal cost = _basket.Buy();

            Assert.That(cost, Is.EqualTo(15.2));
        }

        [Test]
        public void When_BuyThreeCopyOfOtherBook_return_priceWith10PercentDiscount()
        {
            _basket.PutBook(new Book(1));
            _basket.PutBook(new Book(2));
            _basket.PutBook(new Book(3));

            decimal cost = _basket.Buy();

            Assert.That(cost, Is.EqualTo(21.6));
        }

        [Test]
        public void When_BuyFourCopyOfOtherBook_return_priceWith20PercentDiscount()
        {
            _basket.PutBook(new Book(1));
            _basket.PutBook(new Book(2));
            _basket.PutBook(new Book(3));
            _basket.PutBook(new Book(4));

            decimal cost = _basket.Buy();

            Assert.That(cost, Is.EqualTo(25.6));
        }

        [Test]
        public void When_BuyFiveCopyOfOtherBook_return_priceWith25PercentDiscount()
        {
            _basket.PutBook(new Book(1));
            _basket.PutBook(new Book(2));
            _basket.PutBook(new Book(3));
            _basket.PutBook(new Book(4));
            _basket.PutBook(new Book(5));

            decimal cost = _basket.Buy();

            Assert.That(cost, Is.EqualTo(30));
        }

        [Test]
        public void When_BuyFourCopyOfTwoSameBook_return_priceWith5PercentDiscount()
        {
            _basket.PutBook(new Book(1));
            _basket.PutBook(new Book(2));
            _basket.PutBook(new Book(1));
            _basket.PutBook(new Book(2));

            decimal cost = _basket.Buy();

            Assert.That(cost, Is.EqualTo(30.4));
        }
    }
}