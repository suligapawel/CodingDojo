using CodingDojo.FizzBuzz.Main;
using NUnit.Framework;
using System;

namespace CodingDojo.FizzBuzz.Test
{
    public class Tests
    {
        private TheGame _theGame;

        [SetUp]
        public void Setup()
        {
            _theGame = new TheGame();
        }

        [Test]
        public void When_nextNumberIsNotDivisibleBy3And5_return_thisNumber()
        {
            string result = _theGame.Count();
            string nextResult = _theGame.Count();

            Assert.That(result, Is.EqualTo("1"));
            Assert.That(nextResult, Is.EqualTo("2"));
        }

        [Test]
        public void When_nexNumberIsDivideBy3_return_fizzWord()
        {
            ExecuteCountMethod(2);

            string result = _theGame.Count();

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void When_nexNumberIsDivideBy5_return_buzzWord()
        {
            ExecuteCountMethod(4);

            string result = _theGame.Count();

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void When_nexNumberIsDivideBy3AndBy5_return_fizzBuzzWord()
        {
            ExecuteCountMethod(14);

            string result = _theGame.Count();

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void When_isGreaterThan100_throw_OutOfRangeException()
        {
            ExecuteCountMethod(100);

            Assert.Throws<ArgumentOutOfRangeException>(() => _theGame.Count());
        }

        private void ExecuteCountMethod(int howManyTimes)
        {
            for (int i = 0; i < howManyTimes; i++)
            {
                _theGame.Count();
            }
        }
    }
}