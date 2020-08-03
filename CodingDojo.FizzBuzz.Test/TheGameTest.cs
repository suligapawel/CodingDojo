using CodingDojo.FizzBuzz.Main;
using NUnit.Framework;

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
        public void When_nexNumberIsDivideByThree_return_fizzWord()
        {
            _theGame.Count();
            _theGame.Count();

            string result = _theGame.Count();

            Assert.That(result, Is.EqualTo("Fizz"));
        }
    }
}