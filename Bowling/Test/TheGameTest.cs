using CodingDojo.Bowling;
using CodingDojo.Bowling.Main.Frames;
using NUnit.Framework;

namespace NUnitTestProject1
{
    internal class TheGameTest
    {
        private TheGame _theGame;

        [SetUp]
        public void Setup()
        {
            _theGame = new TheGame(new Bonus());
        }

        [Test]
        public void When_notKnockDownAnyPin_return_0()
        {
            RollAllFrames(0, 0);

            int score = _theGame.Score();
            Assert.That(score, Is.EqualTo(0));
        }

        [Test]
        public void When_EachFrameKnockDownOnePin_return_10()
        {
            RollAllFrames(1, 0);

            int score = _theGame.Score();
            Assert.That(score, Is.EqualTo(10));
        }

        [Test]
        public void When_InOneFrameKnockDownAllPinsUsingTwoRolls_then_SumScoreFromNextRoll()
        {
            var spareFrame = new SpareFrame(4);
            var nextFrame = new DefaultFrame(3, 3);

            _theGame.Roll(spareFrame);
            _theGame.Roll(nextFrame);

            int score = _theGame.Score();
            Assert.That(score, Is.EqualTo(19));
        }

        [Test]
        public void When_InFirstRollOfFrameKnockDownAllPins_then_SumScoreFromNextFrame()
        {
            var strikeFrame = new StrikeFrame();
            var nextFrame = new DefaultFrame(3, 4);

            _theGame.Roll(strikeFrame);
            _theGame.Roll(nextFrame);

            int score = _theGame.Score();
            Assert.That(score, Is.EqualTo(24));
        }

        [Test]
        public void When_AllRollsAreStrike_then_scoreIs300()
        {
            for (int i = 0; i < 10; i++)
            {
                _theGame.Roll(new StrikeFrame());
            }
            _theGame.AddFinalBonus(new StrikeFrame());
            _theGame.AddFinalBonus(new StrikeFrame());

            int score = _theGame.Score();

            Assert.That(score, Is.EqualTo(300));
        }

        [Test]
        public void When_AllRollsAreSpareWithFirstRoll5_then_scoreIs150()
        {
            for (int i = 0; i < 10; i++)
            {
                _theGame.Roll(new SpareFrame(5));
            }
            _theGame.AddFinalBonus(new SpareFrame(5));

            int score = _theGame.Score();

            Assert.That(score, Is.EqualTo(150));
        }

        private void RollAllFrames(int firstRollValue, int? secondRollValue)
        {
            int secondRoll = secondRollValue ?? 0;

            for (int i = 0; i < 10; i++)
            {
                _theGame.Roll(new DefaultFrame(firstRollValue, secondRoll));
            }
        }
    }
}