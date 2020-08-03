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

        private void ExecuteCountMethod(int howManyTimes)
        {
            for (int i = 0; i < howManyTimes; i++)
            {
                _theGame.Count();
            }
        }
    }
}